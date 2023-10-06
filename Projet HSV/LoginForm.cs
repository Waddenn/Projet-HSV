using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Projet_HSV
{
    public partial class LoginForm : Form
    {
        private UserService _userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
            errorMsgLabel.Text = "";

            string firstName = firstname.Text.Trim();
            string lastName = lastname.Text.Trim();
            string inputPassword = password.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(inputPassword))
            {
                errorMsgLabel.Text = "Veuillez renseigner tous les champs.";
                return;
            }

            if (!_userService.IsUserExist(firstName, lastName))
            {
                errorMsgLabel.Text = "Cet utilisateur n'existe pas. Veuillez créer un compte.";
                return;
            }

            if (!_userService.ValidateCredentials(firstName, lastName, inputPassword))
            {
                errorMsgLabel.Text = "Mot de passe incorrect.";
                return;
            }

            LaunchUserForm(firstName, lastName);
        }

        private void LaunchUserForm(string firstName, string lastName)
        {
            var user = _userService.GetUser(firstName, lastName);

            if (user.Role == "doctor")
            {
                LaunchDoctorForm(user);
            }
            else
            {
                LaunchClientForm(user); 
            }
            this.Hide();
        }

        private void LaunchDoctorForm(User user)
        {
            DoctorForm doctorForm = new DoctorForm(user);
            doctorForm.Location = this.Location;
            doctorForm.FormClosed += (s, args) =>
            {
                if (doctorForm.IsDisconnecting)
                {
                    this.Location = doctorForm.Location;
                    this.Show();
                }
                else
                    this.Close();
            };
            doctorForm.Show();
        }

        private void LaunchClientForm(User user)
        {
            Form1 form1 = new Form1(user);
            form1.Location = this.Location;
            form1.FormClosed += (s, args) =>
            {
                if (form1.IsDisconnecting)
                {
                    this.Location = form1.Location;
                    this.Show();
                }
                else
                    this.Close();
            };
            form1.Show();
        }



        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signUpForm = new SignUpForm();
            signUpForm.Location = this.Location;
            signUpForm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordHidebox_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !PasswordHidebox.Checked;
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
