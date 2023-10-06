using System.Data;


namespace Projet_HSV
{
    public partial class DoctorForm : Form
    {
        public bool IsDisconnecting { get; private set; } = false;
        private UserService _userService = new UserService();
        private User _currentUser;

        public DoctorForm(User user)
        {
            InitializeComponent();
            FillDoctorAppointmentsListView();
            InitializeComboBoxes();
            _currentUser = user;
            ShowUserNameLabel.Text = $"Bonjour Docteur {_currentUser.FirstName} {_currentUser.LastName} !";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void InitializeComboBoxes()
        {
            var allUsers = _userService.GetAllUsers();

            userComboBox.Items.Add("");
            var usersWithAppointments = allUsers.Where(u => u.Appointments.Any()).ToList();
            var userNames = usersWithAppointments.Select(u => u.FirstName + " " + u.LastName).Distinct().ToList();
            userComboBox.Items.AddRange(userNames.ToArray());

            specialityComboBox.Items.Add("");
            var specialities = usersWithAppointments
                .SelectMany(u => u.Appointments.Select(a => a.Speciality))
                .Distinct()
                .ToList();
            specialityComboBox.Items.AddRange(specialities.ToArray());
        }


        private void FillDoctorAppointmentsListView()
        {
            listView1.Items.Clear();

            var allUsers = _userService.GetAllUsers();

            var selectedUserName = userComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedUserName))
            {
                allUsers = allUsers.Where(u => $"{u.FirstName} {u.LastName}" == selectedUserName).ToList();
            }

            var selectedSpeciality = specialityComboBox.SelectedItem?.ToString();
            var allAppointments = allUsers
                .SelectMany(u => u.Appointments.Select(a => new { User = u, Appointment = a }))
                .Where(a => string.IsNullOrEmpty(selectedSpeciality) || a.Appointment.Speciality == selectedSpeciality)
                .ToList();

            InitializeListView();

            foreach (var data in allAppointments)
            {
                var item = new ListViewItem(new string[]
                {
            data.User.FirstName,
            data.User.LastName,
            data.Appointment.Speciality,
            data.Appointment.Date,
            data.Appointment.Time,
            data.Appointment.Status,
            data.Appointment.DoctorConfirmed
                });

                listView1.Items.Add(item);
            }

            StyleListView();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.AddRange(new ColumnHeader[]
                {
            new ColumnHeader() { Text = "Prénom", Width = 100 },
            new ColumnHeader() { Text = "Nom", Width = 100 },
            new ColumnHeader() { Text = "Spécialité", Width = 150 },
            new ColumnHeader() { Text = "Date", Width = 150 },
            new ColumnHeader() { Text = "Heure", Width = 100 },
            new ColumnHeader() { Text = "Statut", Width = 100 },
            new ColumnHeader() { Text = "Médecin", Width = 100 }
                });
            }
        }

        private void StyleListView()
        {
            for (int i = 0; i < listView1.Items.Count; i += 2)
            {
                listView1.Items[i].BackColor = System.Drawing.Color.Gray;
            }
        }

        private void ChangeAppointmentStatus(string newStatus)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var selected = listView1.SelectedItems[0];
            var userFirstName = selected.SubItems[0].Text;
            var userLastName = selected.SubItems[1].Text;

            var user = _userService.GetUser(userFirstName, userLastName);
            var appointment = user.Appointments.First(app =>
                app.Speciality == selected.SubItems[2].Text &&
                app.Date == selected.SubItems[3].Text &&
                app.Time == selected.SubItems[4].Text);

            appointment.Status = newStatus;
            appointment.DoctorConfirmed = $"{_currentUser.FirstName} {_currentUser.LastName}";

            _userService.SaveUser(user);

            FillDoctorAppointmentsListView();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ChangeAppointmentStatus("Confirmé");
        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            ChangeAppointmentStatus("Refusé");
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            this.IsDisconnecting = true;
            this.Close();
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDoctorAppointmentsListView();
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDoctorAppointmentsListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
