
namespace Projet_HSV
{
    public partial class SignUpForm : Form
    {
        private static readonly List<string> Roles = new List<string> { "client", "doctor" };

        private readonly UserService _userService = new UserService();

        public SignUpForm()
        {
            InitializeComponent();
            InitializeComboBoxRoles();
            password.UseSystemPasswordChar = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void InitializeComboBoxRoles()
        {
            comboBox1.Items.AddRange(Roles.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";

            var firstName = firstname.Text.Trim();
            var lastName = lastname.Text.Trim();
            var userPassword = password.Text.Trim();
            var selectedRole = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(selectedRole))
            {
                errorMsgLabel.Text = "Veuillez renseigner tous les champs.";
                return;
            }

            if (_userService.GetUser(firstName, lastName) != null)
            {
                errorMsgLabel.Text = "Un utilisateur avec ces identifiants existe déjà.";
                return;
            }

            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Password = userPassword,
                Role = selectedRole
            };

            _userService.SaveUser(user);
            errorMsgLabel.Text = "Inscription réussie !";
            this.Close();
        }


    private void PasswordHidebox_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !PasswordHidebox.Checked;
        }
    }
}
