namespace Projet_HSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            Disconnect = new Button();
            TimePicker = new DateTimePicker();
            monthCalendar = new MonthCalendar();
            SpecialityComboBox = new ComboBox();
            ShowUserNameLabel = new Label();
            ValidButton = new Button();
            listView2 = new ListView();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(-1, -3);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(804, 541);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Disconnect);
            tabPage1.Controls.Add(TimePicker);
            tabPage1.Controls.Add(monthCalendar);
            tabPage1.Controls.Add(SpecialityComboBox);
            tabPage1.Controls.Add(ShowUserNameLabel);
            tabPage1.Controls.Add(ValidButton);
            tabPage1.Controls.Add(listView2);
            tabPage1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 40);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(796, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Réservation";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 103);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.ForeColor = Color.FromArgb(50, 50, 50);
            label2.Location = new Point(634, 430);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 8;
            label2.Text = "heures";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(31, 125);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Disconnect
            // 
            Disconnect.BackColor = Color.DarkGray;
            Disconnect.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Disconnect.ForeColor = Color.Teal;
            Disconnect.Location = new Point(31, 377);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(335, 93);
            Disconnect.TabIndex = 5;
            Disconnect.Text = "Se déconnecter";
            Disconnect.UseVisualStyleBackColor = false;
            Disconnect.Click += Disconnect_Click;
            // 
            // TimePicker
            // 
            TimePicker.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TimePicker.CalendarForeColor = Color.Gray;
            TimePicker.CalendarTitleForeColor = Color.Gray;
            TimePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TimePicker.Location = new Point(512, 428);
            TimePicker.Margin = new Padding(3, 4, 3, 4);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(107, 38);
            TimePicker.TabIndex = 4;
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = Color.Black;
            monthCalendar.CalendarDimensions = new Size(1, 2);
            monthCalendar.Location = new Point(512, 27);
            monthCalendar.Margin = new Padding(10, 12, 10, 12);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 3;
            // 
            // SpecialityComboBox
            // 
            SpecialityComboBox.BackColor = Color.FromArgb(224, 224, 224);
            SpecialityComboBox.FlatStyle = FlatStyle.Flat;
            SpecialityComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SpecialityComboBox.ForeColor = Color.Gray;
            SpecialityComboBox.FormattingEnabled = true;
            SpecialityComboBox.Location = new Point(31, 211);
            SpecialityComboBox.Margin = new Padding(3, 4, 3, 4);
            SpecialityComboBox.Name = "SpecialityComboBox";
            SpecialityComboBox.Size = new Size(334, 39);
            SpecialityComboBox.TabIndex = 2;
            SpecialityComboBox.TabStop = false;
            // 
            // ShowUserNameLabel
            // 
            ShowUserNameLabel.AutoSize = true;
            ShowUserNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShowUserNameLabel.ForeColor = Color.Teal;
            ShowUserNameLabel.Location = new Point(31, 51);
            ShowUserNameLabel.Name = "ShowUserNameLabel";
            ShowUserNameLabel.Size = new Size(290, 37);
            ShowUserNameLabel.TabIndex = 1;
            ShowUserNameLabel.Text = "ShowUserNameLabel";
            // 
            // ValidButton
            // 
            ValidButton.BackColor = Color.Teal;
            ValidButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ValidButton.ForeColor = Color.Transparent;
            ValidButton.Location = new Point(31, 275);
            ValidButton.Margin = new Padding(3, 4, 3, 4);
            ValidButton.Name = "ValidButton";
            ValidButton.Size = new Size(335, 96);
            ValidButton.TabIndex = 0;
            ValidButton.Text = "Réserver";
            ValidButton.UseVisualStyleBackColor = false;
            ValidButton.Click += ValidButton_Click;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(224, 224, 224);
            listView2.Location = new Point(466, 0);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(334, 497);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(224, 224, 224);
            tabPage2.Controls.Add(listView1);
            tabPage2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 40);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(804, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Suivi";
            // 
            // listView1
            // 
            listView1.BackColor = Color.DarkGray;
            listView1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = Color.White;
            listView1.Location = new Point(25, 25);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(755, 449);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 537);
            Controls.Add(tabControl1);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker TimePicker;
        private MonthCalendar monthCalendar;
        private ComboBox SpecialityComboBox;
        private Label ShowUserNameLabel;
        private Button ValidButton;
        private ListView listView1;
        private Button Disconnect;
        private ListView listView2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}