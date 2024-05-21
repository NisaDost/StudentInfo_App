namespace StudentInfo_App
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.MenuBar = new System.Windows.Forms.Panel();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.AbscenceButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CanteenButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DashboardText2 = new System.Windows.Forms.Label();
            this.DasboardText3 = new System.Windows.Forms.Label();
            this.DashboardText4 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.StudentFirstNameLbl = new System.Windows.Forms.Label();
            this.StudentFirstNameTB = new System.Windows.Forms.TextBox();
            this.CanteenPanel = new System.Windows.Forms.Panel();
            this.AbscencePanel = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateAndTime = new System.Windows.Forms.Label();
            this.StudentLastNameLbl = new System.Windows.Forms.Label();
            this.StudentLastNameTB = new System.Windows.Forms.TextBox();
            this.StudentBirthdayLbl = new System.Windows.Forms.Label();
            this.StudentGenderLbl = new System.Windows.Forms.Label();
            this.StudentBirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.StudentGenderCB = new System.Windows.Forms.ComboBox();
            this.StudentCityLbl = new System.Windows.Forms.Label();
            this.StudentCityCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentDistrictCB = new System.Windows.Forms.ComboBox();
            this.StudentAdressLbl = new System.Windows.Forms.Label();
            this.ParentNameTB = new System.Windows.Forms.TextBox();
            this.ParentNameLbl = new System.Windows.Forms.Label();
            this.StudentAdressTB = new System.Windows.Forms.TextBox();
            this.ParentEmailLbl = new System.Windows.Forms.Label();
            this.ParentEmailTB = new System.Windows.Forms.TextBox();
            this.ParentPhoneLbl = new System.Windows.Forms.Label();
            this.ParentPhoneTB = new System.Windows.Forms.TextBox();
            this.SaveStudentBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.StudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuBar.Controls.Add(this.StudentsButton);
            this.MenuBar.Controls.Add(this.AbscenceButton);
            this.MenuBar.Controls.Add(this.LogoutButton);
            this.MenuBar.Controls.Add(this.CanteenButton);
            this.MenuBar.Controls.Add(this.HomeButton);
            this.MenuBar.Controls.Add(this.Logo);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(2);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(172, 484);
            this.MenuBar.TabIndex = 0;
            // 
            // StudentsButton
            // 
            this.StudentsButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StudentsButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.StudentsButton.Location = new System.Drawing.Point(9, 167);
            this.StudentsButton.Margin = new System.Windows.Forms.Padding(2);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(148, 33);
            this.StudentsButton.TabIndex = 1;
            this.StudentsButton.Text = "Students";
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // AbscenceButton
            // 
            this.AbscenceButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AbscenceButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AbscenceButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AbscenceButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AbscenceButton.Location = new System.Drawing.Point(9, 244);
            this.AbscenceButton.Margin = new System.Windows.Forms.Padding(2);
            this.AbscenceButton.Name = "AbscenceButton";
            this.AbscenceButton.Size = new System.Drawing.Size(148, 33);
            this.AbscenceButton.TabIndex = 1;
            this.AbscenceButton.Text = "Abscence";
            this.AbscenceButton.UseVisualStyleBackColor = false;
            this.AbscenceButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LogoutButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LogoutButton.Location = new System.Drawing.Point(9, 441);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(148, 33);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CanteenButton
            // 
            this.CanteenButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CanteenButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CanteenButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CanteenButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CanteenButton.Location = new System.Drawing.Point(9, 206);
            this.CanteenButton.Margin = new System.Windows.Forms.Padding(2);
            this.CanteenButton.Name = "CanteenButton";
            this.CanteenButton.Size = new System.Drawing.Size(148, 33);
            this.CanteenButton.TabIndex = 1;
            this.CanteenButton.Text = "Canteen";
            this.CanteenButton.UseVisualStyleBackColor = false;
            this.CanteenButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HomeButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.HomeButton.Location = new System.Drawing.Point(9, 129);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(148, 33);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(49, 25);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(72, 84);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WelcomeText.Location = new System.Drawing.Point(19, 26);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(439, 37);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "Welcome to your dashboard, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Your School";
            // 
            // DashboardText2
            // 
            this.DashboardText2.AutoSize = true;
            this.DashboardText2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DashboardText2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DashboardText2.Location = new System.Drawing.Point(50, 136);
            this.DashboardText2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DashboardText2.Name = "DashboardText2";
            this.DashboardText2.Size = new System.Drawing.Size(154, 22);
            this.DashboardText2.TabIndex = 1;
            this.DashboardText2.Text = "Add other admins";
            // 
            // DasboardText3
            // 
            this.DasboardText3.AutoSize = true;
            this.DasboardText3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DasboardText3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DasboardText3.Location = new System.Drawing.Point(50, 187);
            this.DasboardText3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DasboardText3.Name = "DasboardText3";
            this.DasboardText3.Size = new System.Drawing.Size(107, 22);
            this.DasboardText3.TabIndex = 1;
            this.DasboardText3.Text = "Add classes ";
            // 
            // DashboardText4
            // 
            this.DashboardText4.AutoSize = true;
            this.DashboardText4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DashboardText4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DashboardText4.Location = new System.Drawing.Point(50, 236);
            this.DashboardText4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DashboardText4.Name = "DashboardText4";
            this.DashboardText4.Size = new System.Drawing.Size(118, 22);
            this.DashboardText4.TabIndex = 1;
            this.DashboardText4.Text = "Add students";
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomePanel.Controls.Add(this.WelcomeText);
            this.HomePanel.Controls.Add(this.label1);
            this.HomePanel.Controls.Add(this.DashboardText2);
            this.HomePanel.Controls.Add(this.DasboardText3);
            this.HomePanel.Controls.Add(this.DashboardText4);
            this.HomePanel.Location = new System.Drawing.Point(188, 55);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(676, 410);
            this.HomePanel.TabIndex = 2;
            // 
            // StudentPanel
            // 
            this.StudentPanel.BackColor = System.Drawing.Color.Brown;
            this.StudentPanel.Controls.Add(this.SaveStudentBtn);
            this.StudentPanel.Controls.Add(this.StudentAdressTB);
            this.StudentPanel.Controls.Add(this.ParentPhoneTB);
            this.StudentPanel.Controls.Add(this.ParentEmailTB);
            this.StudentPanel.Controls.Add(this.ParentNameTB);
            this.StudentPanel.Controls.Add(this.StudentDistrictCB);
            this.StudentPanel.Controls.Add(this.StudentCityCB);
            this.StudentPanel.Controls.Add(this.StudentGenderCB);
            this.StudentPanel.Controls.Add(this.StudentBirthdayDTP);
            this.StudentPanel.Controls.Add(this.label3);
            this.StudentPanel.Controls.Add(this.ParentPhoneLbl);
            this.StudentPanel.Controls.Add(this.ParentEmailLbl);
            this.StudentPanel.Controls.Add(this.ParentNameLbl);
            this.StudentPanel.Controls.Add(this.StudentAdressLbl);
            this.StudentPanel.Controls.Add(this.StudentCityLbl);
            this.StudentPanel.Controls.Add(this.StudentGenderLbl);
            this.StudentPanel.Controls.Add(this.StudentBirthdayLbl);
            this.StudentPanel.Controls.Add(this.StudentLastNameLbl);
            this.StudentPanel.Controls.Add(this.StudentFirstNameLbl);
            this.StudentPanel.Controls.Add(this.StudentLastNameTB);
            this.StudentPanel.Controls.Add(this.StudentFirstNameTB);
            this.StudentPanel.Location = new System.Drawing.Point(188, 55);
            this.StudentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(688, 410);
            this.StudentPanel.TabIndex = 2;
            // 
            // StudentFirstNameLbl
            // 
            this.StudentFirstNameLbl.AutoSize = true;
            this.StudentFirstNameLbl.Location = new System.Drawing.Point(51, 44);
            this.StudentFirstNameLbl.Name = "StudentFirstNameLbl";
            this.StudentFirstNameLbl.Size = new System.Drawing.Size(66, 13);
            this.StudentFirstNameLbl.TabIndex = 1;
            this.StudentFirstNameLbl.Text = "First Name : ";
            // 
            // StudentFirstNameTB
            // 
            this.StudentFirstNameTB.Location = new System.Drawing.Point(140, 41);
            this.StudentFirstNameTB.Name = "StudentFirstNameTB";
            this.StudentFirstNameTB.Size = new System.Drawing.Size(125, 20);
            this.StudentFirstNameTB.TabIndex = 0;
            // 
            // CanteenPanel
            // 
            this.CanteenPanel.BackColor = System.Drawing.Color.Maroon;
            this.CanteenPanel.Location = new System.Drawing.Point(188, 55);
            this.CanteenPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CanteenPanel.Name = "CanteenPanel";
            this.CanteenPanel.Size = new System.Drawing.Size(702, 410);
            this.CanteenPanel.TabIndex = 2;
            // 
            // AbscencePanel
            // 
            this.AbscencePanel.BackColor = System.Drawing.Color.LightGreen;
            this.AbscencePanel.Location = new System.Drawing.Point(188, 55);
            this.AbscencePanel.Margin = new System.Windows.Forms.Padding(2);
            this.AbscencePanel.Name = "AbscencePanel";
            this.AbscencePanel.Size = new System.Drawing.Size(716, 410);
            this.AbscencePanel.TabIndex = 2;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.IndianRed;
            this.QuitButton.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuitButton.ForeColor = System.Drawing.Color.Transparent;
            this.QuitButton.Location = new System.Drawing.Point(848, 7);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(55, 33);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(182, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "TrackSchool";
            // 
            // DateAndTime
            // 
            this.DateAndTime.AutoSize = true;
            this.DateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateAndTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateAndTime.Location = new System.Drawing.Point(672, 467);
            this.DateAndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.Size = new System.Drawing.Size(115, 13);
            this.DateAndTime.TabIndex = 1;
            this.DateAndTime.Text = "00.00.2002 - 00.00";
            // 
            // StudentLastNameLbl
            // 
            this.StudentLastNameLbl.AutoSize = true;
            this.StudentLastNameLbl.Location = new System.Drawing.Point(51, 74);
            this.StudentLastNameLbl.Name = "StudentLastNameLbl";
            this.StudentLastNameLbl.Size = new System.Drawing.Size(67, 13);
            this.StudentLastNameLbl.TabIndex = 1;
            this.StudentLastNameLbl.Text = "Last Name : ";
            // 
            // StudentLastNameTB
            // 
            this.StudentLastNameTB.Location = new System.Drawing.Point(140, 71);
            this.StudentLastNameTB.Name = "StudentLastNameTB";
            this.StudentLastNameTB.Size = new System.Drawing.Size(125, 20);
            this.StudentLastNameTB.TabIndex = 0;
            // 
            // StudentBirthdayLbl
            // 
            this.StudentBirthdayLbl.AutoSize = true;
            this.StudentBirthdayLbl.Location = new System.Drawing.Point(51, 107);
            this.StudentBirthdayLbl.Name = "StudentBirthdayLbl";
            this.StudentBirthdayLbl.Size = new System.Drawing.Size(54, 13);
            this.StudentBirthdayLbl.TabIndex = 1;
            this.StudentBirthdayLbl.Text = "Birthday : ";
            // 
            // StudentGenderLbl
            // 
            this.StudentGenderLbl.AutoSize = true;
            this.StudentGenderLbl.Location = new System.Drawing.Point(51, 139);
            this.StudentGenderLbl.Name = "StudentGenderLbl";
            this.StudentGenderLbl.Size = new System.Drawing.Size(51, 13);
            this.StudentGenderLbl.TabIndex = 1;
            this.StudentGenderLbl.Text = "Gender : ";
            // 
            // StudentBirthdayDTP
            // 
            this.StudentBirthdayDTP.Location = new System.Drawing.Point(140, 103);
            this.StudentBirthdayDTP.Name = "StudentBirthdayDTP";
            this.StudentBirthdayDTP.Size = new System.Drawing.Size(200, 20);
            this.StudentBirthdayDTP.TabIndex = 2;
            // 
            // StudentGenderCB
            // 
            this.StudentGenderCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.StudentGenderCB.FormattingEnabled = true;
            this.StudentGenderCB.Location = new System.Drawing.Point(140, 136);
            this.StudentGenderCB.Name = "StudentGenderCB";
            this.StudentGenderCB.Size = new System.Drawing.Size(121, 21);
            this.StudentGenderCB.TabIndex = 3;
            // 
            // StudentCityLbl
            // 
            this.StudentCityLbl.AutoSize = true;
            this.StudentCityLbl.Location = new System.Drawing.Point(51, 174);
            this.StudentCityLbl.Name = "StudentCityLbl";
            this.StudentCityLbl.Size = new System.Drawing.Size(33, 13);
            this.StudentCityLbl.TabIndex = 1;
            this.StudentCityLbl.Text = "City : ";
            // 
            // StudentCityCB
            // 
            this.StudentCityCB.FormattingEnabled = true;
            this.StudentCityCB.Location = new System.Drawing.Point(140, 171);
            this.StudentCityCB.Name = "StudentCityCB";
            this.StudentCityCB.Size = new System.Drawing.Size(121, 21);
            this.StudentCityCB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "District : ";
            // 
            // StudentDistrictCB
            // 
            this.StudentDistrictCB.FormattingEnabled = true;
            this.StudentDistrictCB.Location = new System.Drawing.Point(346, 171);
            this.StudentDistrictCB.Name = "StudentDistrictCB";
            this.StudentDistrictCB.Size = new System.Drawing.Size(121, 21);
            this.StudentDistrictCB.TabIndex = 4;
            // 
            // StudentAdressLbl
            // 
            this.StudentAdressLbl.AutoSize = true;
            this.StudentAdressLbl.Location = new System.Drawing.Point(51, 205);
            this.StudentAdressLbl.Name = "StudentAdressLbl";
            this.StudentAdressLbl.Size = new System.Drawing.Size(48, 13);
            this.StudentAdressLbl.TabIndex = 1;
            this.StudentAdressLbl.Text = "Adress : ";
            // 
            // ParentNameTB
            // 
            this.ParentNameTB.Location = new System.Drawing.Point(140, 231);
            this.ParentNameTB.Name = "ParentNameTB";
            this.ParentNameTB.Size = new System.Drawing.Size(121, 20);
            this.ParentNameTB.TabIndex = 5;
            // 
            // ParentNameLbl
            // 
            this.ParentNameLbl.AutoSize = true;
            this.ParentNameLbl.Location = new System.Drawing.Point(51, 234);
            this.ParentNameLbl.Name = "ParentNameLbl";
            this.ParentNameLbl.Size = new System.Drawing.Size(78, 13);
            this.ParentNameLbl.TabIndex = 1;
            this.ParentNameLbl.Text = "Parent Name : ";
            // 
            // StudentAdressTB
            // 
            this.StudentAdressTB.Location = new System.Drawing.Point(140, 202);
            this.StudentAdressTB.Name = "StudentAdressTB";
            this.StudentAdressTB.Size = new System.Drawing.Size(327, 20);
            this.StudentAdressTB.TabIndex = 5;
            // 
            // ParentEmailLbl
            // 
            this.ParentEmailLbl.AutoSize = true;
            this.ParentEmailLbl.Location = new System.Drawing.Point(51, 261);
            this.ParentEmailLbl.Name = "ParentEmailLbl";
            this.ParentEmailLbl.Size = new System.Drawing.Size(75, 13);
            this.ParentEmailLbl.TabIndex = 1;
            this.ParentEmailLbl.Text = "Parent Email : ";
            // 
            // ParentEmailTB
            // 
            this.ParentEmailTB.Location = new System.Drawing.Point(140, 258);
            this.ParentEmailTB.Name = "ParentEmailTB";
            this.ParentEmailTB.Size = new System.Drawing.Size(121, 20);
            this.ParentEmailTB.TabIndex = 5;
            // 
            // ParentPhoneLbl
            // 
            this.ParentPhoneLbl.AutoSize = true;
            this.ParentPhoneLbl.Location = new System.Drawing.Point(51, 286);
            this.ParentPhoneLbl.Name = "ParentPhoneLbl";
            this.ParentPhoneLbl.Size = new System.Drawing.Size(81, 13);
            this.ParentPhoneLbl.TabIndex = 1;
            this.ParentPhoneLbl.Text = "Parent Phone : ";
            // 
            // ParentPhoneTB
            // 
            this.ParentPhoneTB.Location = new System.Drawing.Point(140, 284);
            this.ParentPhoneTB.Name = "ParentPhoneTB";
            this.ParentPhoneTB.Size = new System.Drawing.Size(121, 20);
            this.ParentPhoneTB.TabIndex = 5;
            // 
            // SaveStudentBtn
            // 
            this.SaveStudentBtn.Location = new System.Drawing.Point(502, 349);
            this.SaveStudentBtn.Name = "SaveStudentBtn";
            this.SaveStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveStudentBtn.TabIndex = 6;
            this.SaveStudentBtn.Text = "Save";
            this.SaveStudentBtn.UseVisualStyleBackColor = true;
            this.SaveStudentBtn.Click += new System.EventHandler(this.SaveStudentBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 484);
            this.Controls.Add(this.DateAndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.CanteenPanel);
            this.Controls.Add(this.AbscencePanel);
            this.Controls.Add(this.StudentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.StudentPanel.ResumeLayout(false);
            this.StudentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button CanteenButton;
        private System.Windows.Forms.Button AbscenceButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DashboardText2;
        private System.Windows.Forms.Label DasboardText3;
        private System.Windows.Forms.Label DashboardText4;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.Panel CanteenPanel;
        private System.Windows.Forms.Panel AbscencePanel;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateAndTime;
        private System.Windows.Forms.TextBox StudentFirstNameTB;
        private System.Windows.Forms.Label StudentFirstNameLbl;
        private System.Windows.Forms.Label StudentGenderLbl;
        private System.Windows.Forms.Label StudentBirthdayLbl;
        private System.Windows.Forms.Label StudentLastNameLbl;
        private System.Windows.Forms.TextBox StudentLastNameTB;
        private System.Windows.Forms.DateTimePicker StudentBirthdayDTP;
        private System.Windows.Forms.ComboBox StudentGenderCB;
        private System.Windows.Forms.Label StudentCityLbl;
        private System.Windows.Forms.ComboBox StudentCityCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StudentDistrictCB;
        private System.Windows.Forms.Label StudentAdressLbl;
        private System.Windows.Forms.TextBox ParentNameTB;
        private System.Windows.Forms.TextBox StudentAdressTB;
        private System.Windows.Forms.Label ParentNameLbl;
        private System.Windows.Forms.Label ParentEmailLbl;
        private System.Windows.Forms.TextBox ParentEmailTB;
        private System.Windows.Forms.Label ParentPhoneLbl;
        private System.Windows.Forms.TextBox ParentPhoneTB;
        private System.Windows.Forms.Button SaveStudentBtn;
        private System.Windows.Forms.Timer timer1;
    }
}