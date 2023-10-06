namespace Projet_HSV
{
    partial class SignUpForm
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
            comboBox1 = new ComboBox();
            password = new TextBox();
            PasswordHidebox = new CheckBox();
            SignUp = new Button();
            label1 = new Label();
            lastname = new TextBox();
            firstname = new TextBox();
            errorMsgLabel = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(224, 224, 224);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 125);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 40);
            comboBox1.TabIndex = 6;
            comboBox1.TabStop = false;
            // 
            // password
            // 
            password.AcceptsTab = true;
            password.BackColor = Color.FromArgb(224, 224, 224);
            password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.Gray;
            password.Location = new Point(119, 276);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PlaceholderText = "Mot de passe";
            password.Size = new Size(230, 38);
            password.TabIndex = 19;
            password.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordHidebox
            // 
            PasswordHidebox.AutoSize = true;
            PasswordHidebox.Location = new Point(367, 289);
            PasswordHidebox.Name = "PasswordHidebox";
            PasswordHidebox.Size = new Size(18, 17);
            PasswordHidebox.TabIndex = 18;
            PasswordHidebox.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.Teal;
            SignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignUp.ForeColor = Color.White;
            SignUp.Location = new Point(160, 359);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(150, 51);
            SignUp.TabIndex = 17;
            SignUp.Text = "S'inscrire";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(86, 40);
            label1.Name = "label1";
            label1.Size = new Size(329, 54);
            label1.TabIndex = 16;
            label1.Text = "Inscription HSV";
            // 
            // lastname
            // 
            lastname.BackColor = Color.FromArgb(224, 224, 224);
            lastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lastname.ForeColor = Color.Gray;
            lastname.Location = new Point(119, 226);
            lastname.Margin = new Padding(3, 4, 3, 4);
            lastname.Name = "lastname";
            lastname.PlaceholderText = "Nom";
            lastname.Size = new Size(230, 38);
            lastname.TabIndex = 14;
            lastname.TextAlign = HorizontalAlignment.Center;
            // 
            // firstname
            // 
            firstname.BackColor = Color.FromArgb(224, 224, 224);
            firstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            firstname.ForeColor = Color.Gray;
            firstname.Location = new Point(119, 177);
            firstname.Name = "firstname";
            firstname.PlaceholderText = "Prénom";
            firstname.Size = new Size(230, 38);
            firstname.TabIndex = 13;
            firstname.TextAlign = HorizontalAlignment.Center;
            // 
            // errorMsgLabel
            // 
            errorMsgLabel.AutoSize = true;
            errorMsgLabel.ForeColor = Color.Red;
            errorMsgLabel.Location = new Point(116, 325);
            errorMsgLabel.Name = "errorMsgLabel";
            errorMsgLabel.Size = new Size(0, 20);
            errorMsgLabel.TabIndex = 20;
            // 
            // SignUpForm
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
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.Manual;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private TextBox password;
        private CheckBox PasswordHidebox;
        private Button SignUp;
        private Label label1;
        private TextBox lastname;
        private TextBox firstname;
        private Label errorMsgLabel;
    }
}