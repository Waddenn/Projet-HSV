namespace Projet_HSV
{
    public partial class Form1 : Form
    {

        private User _currentUser;
        private UserService _userService = new UserService();
        public bool IsDisconnecting { get; private set; } = false;

        public Form1(User user)
        {
            InitializeComponent();
            InitializeSpecialityComboBox();
            InitializeTimePicker();
            _currentUser = user;
            ShowUserNameLabel.Text = $"Bonjour {_currentUser.FirstName} {_currentUser.LastName} !";
            label1.Text = "Vous pouvez réserver,\nvotre rendez-vous médical.";
            FillAppointmentsListView();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void InitializeSpecialityComboBox()
        {
            SpecialityComboBox.Items.Add("Généraliste");
            SpecialityComboBox.Items.Add("Cardiologie");
            SpecialityComboBox.Items.Add("Dermatologie");
            SpecialityComboBox.Items.Add("Endocrinologie");
            SpecialityComboBox.Items.Add("Gastro-entérologie");
            SpecialityComboBox.Items.Add("Neurologie");
            SpecialityComboBox.SelectedIndex = 0;
            SpecialityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void InitializeTimePicker()
        {
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "HH:mm";
            TimePicker.ShowUpDown = true;
        }
        private void FillAppointmentsListView()
        {
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Spécialité", 200);
                listView1.Columns.Add("Date", 150);
                listView1.Columns.Add("Heure", 100);
                listView1.Columns.Add("Statut", 150);
                listView1.Columns.Add("Médecin", 200);
            }

            foreach (var appointment in _currentUser.Appointments)
            {
                var item = new ListViewItem(new string[]
                {
            appointment.Speciality,
            appointment.Date,
            appointment.Time,
            appointment.Status,
            appointment.DoctorConfirmed
                });

                listView1.Items.Add(item);
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.Gray;
                }
            }
        }

        private void ValidButton_Click(object sender, EventArgs e)
        {
            var newAppointment = new Appointment
            {
                Speciality = SpecialityComboBox.SelectedItem.ToString(),
                Date = monthCalendar.SelectionStart.ToString("yyyy-MM-dd"),
                Time = TimePicker.Value.ToString("HH:mm")
            };

            if (_currentUser.Appointments.Any(app => app.Equals(newAppointment)))
            {
                MessageBox.Show("Ce rendez-vous existe déjà !");
            }
            else
            {
                _currentUser.Appointments.Add(newAppointment);

                _userService.SaveUser(_currentUser);

                MessageBox.Show("Rendez-vous enregistré !");
                FillAppointmentsListView();
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            this.IsDisconnecting = true;
            this.Close();
        }
    }
}