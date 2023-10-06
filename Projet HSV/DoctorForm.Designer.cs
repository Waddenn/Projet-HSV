namespace Projet_HSV
{
    partial class DoctorForm
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
            listView1 = new ListView();
            ConfirmButton = new Button();
            RefuseButton = new Button();
            Disconnect = new Button();
            userComboBox = new ComboBox();
            specialityComboBox = new ComboBox();
            ShowUserNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.DarkGray;
            listView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.Location = new Point(26, 52);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(802, 456);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Teal;
            ConfirmButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(883, 229);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(199, 80);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Accepter";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // RefuseButton
            // 
            RefuseButton.BackColor = Color.DarkGray;
            RefuseButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RefuseButton.ForeColor = Color.White;
            RefuseButton.Location = new Point(883, 317);
            RefuseButton.Margin = new Padding(3, 4, 3, 4);
            RefuseButton.Name = "RefuseButton";
            RefuseButton.Size = new Size(199, 79);
            RefuseButton.TabIndex = 2;
            RefuseButton.Text = "Refuser";
            RefuseButton.UseVisualStyleBackColor = false;
            RefuseButton.Click += RefuseButton_Click;
            // 
            // Disconnect
            // 
            Disconnect.BackColor = Color.FromArgb(224, 224, 224);
            Disconnect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Disconnect.ForeColor = Color.Teal;
            Disconnect.Location = new Point(883, 437);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(199, 70);
            Disconnect.TabIndex = 6;
            Disconnect.Text = "Se déconnecter";
            Disconnect.UseVisualStyleBackColor = false;
            Disconnect.Click += Disconnect_Click;
            // 
            // userComboBox
            // 
            userComboBox.FlatStyle = FlatStyle.Flat;
            userComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userComboBox.ForeColor = Color.Black;
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(883, 90);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(199, 36);
            userComboBox.TabIndex = 7;
            userComboBox.SelectedIndexChanged += userComboBox_SelectedIndexChanged;
            // 
            // specialityComboBox
            // 
            specialityComboBox.FlatStyle = FlatStyle.Flat;
            specialityComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            specialityComboBox.ForeColor = Color.Black;
            specialityComboBox.FormattingEnabled = true;
            specialityComboBox.Location = new Point(883, 168);
            specialityComboBox.Name = "specialityComboBox";
            specialityComboBox.Size = new Size(199, 36);
            specialityComboBox.TabIndex = 8;
            specialityComboBox.SelectedIndexChanged += specialityComboBox_SelectedIndexChanged;
            // 
            // ShowUserNameLabel
            // 
            ShowUserNameLabel.AutoSize = true;
            ShowUserNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShowUserNameLabel.ForeColor = Color.Teal;
            ShowUserNameLabel.Location = new Point(26, 5);
            ShowUserNameLabel.Name = "ShowUserNameLabel";
            ShowUserNameLabel.Size = new Size(290, 37);
            ShowUserNameLabel.TabIndex = 9;
            ShowUserNameLabel.Text = "ShowUserNameLabel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(883, 52);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 10;
            label1.Text = "Trier par patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(883, 137);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 11;
            label2.Text = "Trier par spécialité";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1119, 536);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ShowUserNameLabel);
            Controls.Add(specialityComboBox);
            Controls.Add(userComboBox);
            Controls.Add(Disconnect);
            Controls.Add(RefuseButton);
            Controls.Add(ConfirmButton);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorForm";
            StartPosition = FormStartPosition.Manual;
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button ConfirmButton;
        private Button RefuseButton;
        private Button Disconnect;
        private ComboBox userComboBox;
        private ComboBox specialityComboBox;
        private Label ShowUserNameLabel;
        private Label label1;
        private Label label2;
    }
}