namespace Projet_HSV
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            firstname = new TextBox();
            lastname = new TextBox();
            login = new Button();
            label1 = new Label();
            SignUp = new Button();
            PasswordHidebox = new CheckBox();
            password = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorMsgLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.BackColor = Color.FromArgb(224, 224, 224);
            firstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstname.ForeColor = Color.Gray;
            firstname.Location = new Point(118, 140);
            firstname.Name = "firstname";
            firstname.PlaceholderText = "Prénom";
            firstname.Size = new Size(230, 38);
            firstname.TabIndex = 0;
            firstname.TextAlign = HorizontalAlignment.Center;
            // 
            // lastname
            // 
            lastname.BackColor = Color.FromArgb(224, 224, 224);
            lastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lastname.ForeColor = Color.Gray;
            lastname.Location = new Point(118, 196);
            lastname.Margin = new Padding(3, 4, 3, 4);
            lastname.Name = "lastname";
            lastname.PlaceholderText = "Nom";
            lastname.Size = new Size(230, 38);
            lastname.TabIndex = 1;
            lastname.TextAlign = HorizontalAlignment.Center;
            // 
            // login
            // 
            login.BackColor = Color.Teal;
            login.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = Color.White;
            login.Location = new Point(254, 344);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(150, 51);
            login.TabIndex = 3;
            login.Text = "Connexion";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(119, 37);
            label1.Name = "label1";
            label1.Size = new Size(248, 54);
            label1.TabIndex = 4;
            label1.Text = "Portail HSV";
            label1.Click += label1_Click;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.DarkGray;
            SignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp.ForeColor = Color.Teal;
            SignUp.Location = new Point(70, 344);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(150, 51);
            SignUp.TabIndex = 5;
            SignUp.Text = "S'inscrire";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            // 
            // PasswordHidebox
            // 
            PasswordHidebox.AutoSize = true;
            PasswordHidebox.Location = new Point(365, 269);
            PasswordHidebox.Name = "PasswordHidebox";
            PasswordHidebox.Size = new Size(18, 17);
            PasswordHidebox.TabIndex = 11;
            PasswordHidebox.UseVisualStyleBackColor = true;
            PasswordHidebox.CheckedChanged += PasswordHidebox_CheckedChanged;
            // 
            // password
            // 
            password.AcceptsTab = true;
            password.BackColor = Color.FromArgb(224, 224, 224);
            password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.Gray;
            password.Location = new Point(118, 256);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PlaceholderText = "Mot de passe";
            password.Size = new Size(230, 38);
            password.TabIndex = 12;
            password.TextAlign = HorizontalAlignment.Center;
            password.TextChanged += password_TextChanged_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.ForeColor = Color.Red;
            errorMsgLabel.Location = new Point(111, 305);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 20);
            errorMsgLabel.TabIndex = 13;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(482, 453);
            Controls.Add(errorMsgLabel);
            Controls.Add(password);
            Controls.Add(PasswordHidebox);
            Controls.Add(SignUp);
            Controls.Add(label1);
            Controls.Add(login);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.Manual;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstname;
        private TextBox lastname;
        private Button login;
        private Label label1;
        private Button SignUp;
        private CheckBox PasswordHidebox;
        private TextBox password;
        private ErrorProvider errorProvider1;
        private Label errorMsgLabel;
    }
}