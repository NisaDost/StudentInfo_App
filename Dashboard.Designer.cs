﻿namespace StudentInfo_App
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
            this.StudentPanelRegistrationPanel = new System.Windows.Forms.Panel();
            this.StudentSchoolNumberTB = new System.Windows.Forms.TextBox();
            this.StudentSchoolNumberLbl = new System.Windows.Forms.Label();
            this.StudentClassCB = new System.Windows.Forms.ComboBox();
            this.StudentClassLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveStudentBtn = new System.Windows.Forms.Button();
            this.StudentAdressTB = new System.Windows.Forms.TextBox();
            this.ParentPhoneTB = new System.Windows.Forms.TextBox();
            this.ParentEmailTB = new System.Windows.Forms.TextBox();
            this.ParentNameTB = new System.Windows.Forms.TextBox();
            this.StudentDistrictCB = new System.Windows.Forms.ComboBox();
            this.StudentCityCB = new System.Windows.Forms.ComboBox();
            this.StudentGenderCB = new System.Windows.Forms.ComboBox();
            this.StudentBirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ParentPhoneLbl = new System.Windows.Forms.Label();
            this.ParentEmailLbl = new System.Windows.Forms.Label();
            this.ParentNameLbl = new System.Windows.Forms.Label();
            this.StudentAdressLbl = new System.Windows.Forms.Label();
            this.StudentCityLbl = new System.Windows.Forms.Label();
            this.StudentGenderLbl = new System.Windows.Forms.Label();
            this.StudentBirthdayLbl = new System.Windows.Forms.Label();
            this.StudentLastNameLbl = new System.Windows.Forms.Label();
            this.StudentFirstNameLbl = new System.Windows.Forms.Label();
            this.StudentLastNameTB = new System.Windows.Forms.TextBox();
            this.StudentFirstNameTB = new System.Windows.Forms.TextBox();
            this.CanteenPanel = new System.Windows.Forms.Panel();
            this.AbscencePanel = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateAndTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StudentListPanel = new System.Windows.Forms.Panel();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.StudentListBtn = new System.Windows.Forms.Button();
            this.StudentRegistrationBtn = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.StudentPanelRegistrationPanel.SuspendLayout();
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
            // StudentPanelRegistrationPanel
            // 
            this.StudentPanelRegistrationPanel.BackColor = System.Drawing.Color.Brown;
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentSchoolNumberTB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentSchoolNumberLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentClassCB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentClassLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.label4);
            this.StudentPanelRegistrationPanel.Controls.Add(this.SaveStudentBtn);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentAdressTB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.ParentPhoneTB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.ParentEmailTB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.ParentNameTB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentDistrictCB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentCityCB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentGenderCB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentBirthdayDTP);
            this.StudentPanelRegistrationPanel.Controls.Add(this.label3);
            this.StudentPanelRegistrationPanel.Controls.Add(this.ParentPhoneLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.ParentEmailLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.ParentNameLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentAdressLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentCityLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentGenderLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentBirthdayLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentLastNameLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentFirstNameLbl);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentLastNameTB);
            this.StudentPanelRegistrationPanel.Controls.Add(this.StudentFirstNameTB);
            this.StudentPanelRegistrationPanel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentPanelRegistrationPanel.Location = new System.Drawing.Point(188, 55);
            this.StudentPanelRegistrationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.StudentPanelRegistrationPanel.Name = "StudentPanelRegistrationPanel";
            this.StudentPanelRegistrationPanel.Size = new System.Drawing.Size(688, 410);
            this.StudentPanelRegistrationPanel.TabIndex = 2;
            // 
            // StudentSchoolNumberTB
            // 
            this.StudentSchoolNumberTB.Location = new System.Drawing.Point(399, 231);
            this.StudentSchoolNumberTB.Name = "StudentSchoolNumberTB";
            this.StudentSchoolNumberTB.Size = new System.Drawing.Size(100, 23);
            this.StudentSchoolNumberTB.TabIndex = 12;
            // 
            // StudentSchoolNumberLbl
            // 
            this.StudentSchoolNumberLbl.AutoSize = true;
            this.StudentSchoolNumberLbl.Location = new System.Drawing.Point(277, 236);
            this.StudentSchoolNumberLbl.Name = "StudentSchoolNumberLbl";
            this.StudentSchoolNumberLbl.Size = new System.Drawing.Size(116, 18);
            this.StudentSchoolNumberLbl.TabIndex = 11;
            this.StudentSchoolNumberLbl.Text = "School Number :";
            // 
            // StudentClassCB
            // 
            this.StudentClassCB.FormattingEnabled = true;
            this.StudentClassCB.Location = new System.Drawing.Point(140, 231);
            this.StudentClassCB.Name = "StudentClassCB";
            this.StudentClassCB.Size = new System.Drawing.Size(121, 26);
            this.StudentClassCB.TabIndex = 10;
            // 
            // StudentClassLbl
            // 
            this.StudentClassLbl.AutoSize = true;
            this.StudentClassLbl.Location = new System.Drawing.Point(51, 234);
            this.StudentClassLbl.Name = "StudentClassLbl";
            this.StudentClassLbl.Size = new System.Drawing.Size(46, 18);
            this.StudentClassLbl.TabIndex = 9;
            this.StudentClassLbl.Text = "Class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Registration";
            // 
            // SaveStudentBtn
            // 
            this.SaveStudentBtn.Location = new System.Drawing.Point(585, 342);
            this.SaveStudentBtn.Name = "SaveStudentBtn";
            this.SaveStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveStudentBtn.TabIndex = 6;
            this.SaveStudentBtn.Text = "Save";
            this.SaveStudentBtn.UseVisualStyleBackColor = true;
            this.SaveStudentBtn.Click += new System.EventHandler(this.SaveStudentBtn_Click);
            // 
            // StudentAdressTB
            // 
            this.StudentAdressTB.Location = new System.Drawing.Point(140, 202);
            this.StudentAdressTB.Name = "StudentAdressTB";
            this.StudentAdressTB.Size = new System.Drawing.Size(327, 23);
            this.StudentAdressTB.TabIndex = 5;
            // 
            // ParentPhoneTB
            // 
            this.ParentPhoneTB.Location = new System.Drawing.Point(162, 321);
            this.ParentPhoneTB.Name = "ParentPhoneTB";
            this.ParentPhoneTB.Size = new System.Drawing.Size(121, 23);
            this.ParentPhoneTB.TabIndex = 5;
            // 
            // ParentEmailTB
            // 
            this.ParentEmailTB.Location = new System.Drawing.Point(162, 292);
            this.ParentEmailTB.Name = "ParentEmailTB";
            this.ParentEmailTB.Size = new System.Drawing.Size(121, 23);
            this.ParentEmailTB.TabIndex = 5;
            // 
            // ParentNameTB
            // 
            this.ParentNameTB.Location = new System.Drawing.Point(162, 263);
            this.ParentNameTB.Name = "ParentNameTB";
            this.ParentNameTB.Size = new System.Drawing.Size(121, 23);
            this.ParentNameTB.TabIndex = 5;
            // 
            // StudentDistrictCB
            // 
            this.StudentDistrictCB.FormattingEnabled = true;
            this.StudentDistrictCB.Location = new System.Drawing.Point(360, 171);
            this.StudentDistrictCB.Name = "StudentDistrictCB";
            this.StudentDistrictCB.Size = new System.Drawing.Size(121, 26);
            this.StudentDistrictCB.TabIndex = 4;
            // 
            // StudentCityCB
            // 
            this.StudentCityCB.FormattingEnabled = true;
            this.StudentCityCB.Location = new System.Drawing.Point(140, 171);
            this.StudentCityCB.Name = "StudentCityCB";
            this.StudentCityCB.Size = new System.Drawing.Size(121, 26);
            this.StudentCityCB.TabIndex = 4;
            // 
            // StudentGenderCB
            // 
            this.StudentGenderCB.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.StudentGenderCB.FormattingEnabled = true;
            this.StudentGenderCB.Location = new System.Drawing.Point(140, 136);
            this.StudentGenderCB.Name = "StudentGenderCB";
            this.StudentGenderCB.Size = new System.Drawing.Size(121, 26);
            this.StudentGenderCB.TabIndex = 3;
            // 
            // StudentBirthdayDTP
            // 
            this.StudentBirthdayDTP.Location = new System.Drawing.Point(140, 103);
            this.StudentBirthdayDTP.Name = "StudentBirthdayDTP";
            this.StudentBirthdayDTP.Size = new System.Drawing.Size(200, 23);
            this.StudentBirthdayDTP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(292, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "District : ";
            // 
            // ParentPhoneLbl
            // 
            this.ParentPhoneLbl.AutoSize = true;
            this.ParentPhoneLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParentPhoneLbl.Location = new System.Drawing.Point(51, 324);
            this.ParentPhoneLbl.Name = "ParentPhoneLbl";
            this.ParentPhoneLbl.Size = new System.Drawing.Size(107, 18);
            this.ParentPhoneLbl.TabIndex = 1;
            this.ParentPhoneLbl.Text = "Parent Phone : ";
            // 
            // ParentEmailLbl
            // 
            this.ParentEmailLbl.AutoSize = true;
            this.ParentEmailLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParentEmailLbl.Location = new System.Drawing.Point(51, 295);
            this.ParentEmailLbl.Name = "ParentEmailLbl";
            this.ParentEmailLbl.Size = new System.Drawing.Size(101, 18);
            this.ParentEmailLbl.TabIndex = 1;
            this.ParentEmailLbl.Text = "Parent Email : ";
            // 
            // ParentNameLbl
            // 
            this.ParentNameLbl.AutoSize = true;
            this.ParentNameLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParentNameLbl.Location = new System.Drawing.Point(51, 266);
            this.ParentNameLbl.Name = "ParentNameLbl";
            this.ParentNameLbl.Size = new System.Drawing.Size(105, 18);
            this.ParentNameLbl.TabIndex = 1;
            this.ParentNameLbl.Text = "Parent Name : ";
            // 
            // StudentAdressLbl
            // 
            this.StudentAdressLbl.AutoSize = true;
            this.StudentAdressLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentAdressLbl.Location = new System.Drawing.Point(51, 205);
            this.StudentAdressLbl.Name = "StudentAdressLbl";
            this.StudentAdressLbl.Size = new System.Drawing.Size(60, 18);
            this.StudentAdressLbl.TabIndex = 1;
            this.StudentAdressLbl.Text = "Adress : ";
            // 
            // StudentCityLbl
            // 
            this.StudentCityLbl.AutoSize = true;
            this.StudentCityLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentCityLbl.Location = new System.Drawing.Point(51, 174);
            this.StudentCityLbl.Name = "StudentCityLbl";
            this.StudentCityLbl.Size = new System.Drawing.Size(41, 18);
            this.StudentCityLbl.TabIndex = 1;
            this.StudentCityLbl.Text = "City : ";
            // 
            // StudentGenderLbl
            // 
            this.StudentGenderLbl.AutoSize = true;
            this.StudentGenderLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentGenderLbl.Location = new System.Drawing.Point(51, 140);
            this.StudentGenderLbl.Name = "StudentGenderLbl";
            this.StudentGenderLbl.Size = new System.Drawing.Size(66, 18);
            this.StudentGenderLbl.TabIndex = 1;
            this.StudentGenderLbl.Text = "Gender : ";
            // 
            // StudentBirthdayLbl
            // 
            this.StudentBirthdayLbl.AutoSize = true;
            this.StudentBirthdayLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentBirthdayLbl.Location = new System.Drawing.Point(51, 107);
            this.StudentBirthdayLbl.Name = "StudentBirthdayLbl";
            this.StudentBirthdayLbl.Size = new System.Drawing.Size(73, 18);
            this.StudentBirthdayLbl.TabIndex = 1;
            this.StudentBirthdayLbl.Text = "Birthday : ";
            // 
            // StudentLastNameLbl
            // 
            this.StudentLastNameLbl.AutoSize = true;
            this.StudentLastNameLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentLastNameLbl.Location = new System.Drawing.Point(51, 74);
            this.StudentLastNameLbl.Name = "StudentLastNameLbl";
            this.StudentLastNameLbl.Size = new System.Drawing.Size(88, 18);
            this.StudentLastNameLbl.TabIndex = 1;
            this.StudentLastNameLbl.Text = "Last Name : ";
            // 
            // StudentFirstNameLbl
            // 
            this.StudentFirstNameLbl.AutoSize = true;
            this.StudentFirstNameLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentFirstNameLbl.Location = new System.Drawing.Point(51, 44);
            this.StudentFirstNameLbl.Name = "StudentFirstNameLbl";
            this.StudentFirstNameLbl.Size = new System.Drawing.Size(88, 18);
            this.StudentFirstNameLbl.TabIndex = 1;
            this.StudentFirstNameLbl.Text = "First Name : ";
            // 
            // StudentLastNameTB
            // 
            this.StudentLastNameTB.Location = new System.Drawing.Point(140, 71);
            this.StudentLastNameTB.Name = "StudentLastNameTB";
            this.StudentLastNameTB.Size = new System.Drawing.Size(125, 23);
            this.StudentLastNameTB.TabIndex = 0;
            // 
            // StudentFirstNameTB
            // 
            this.StudentFirstNameTB.Location = new System.Drawing.Point(140, 41);
            this.StudentFirstNameTB.Name = "StudentFirstNameTB";
            this.StudentFirstNameTB.Size = new System.Drawing.Size(125, 23);
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
            // StudentListPanel
            // 
            this.StudentListPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.StudentListPanel.Location = new System.Drawing.Point(177, 45);
            this.StudentListPanel.Name = "StudentListPanel";
            this.StudentListPanel.Size = new System.Drawing.Size(696, 409);
            this.StudentListPanel.TabIndex = 1;
            // 
            // StudentPanel
            // 
            this.StudentPanel.BackColor = System.Drawing.Color.OliveDrab;
            this.StudentPanel.Controls.Add(this.StudentListBtn);
            this.StudentPanel.Controls.Add(this.StudentRegistrationBtn);
            this.StudentPanel.Location = new System.Drawing.Point(224, 47);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(591, 318);
            this.StudentPanel.TabIndex = 17;
            // 
            // StudentListBtn
            // 
            this.StudentListBtn.Location = new System.Drawing.Point(195, 145);
            this.StudentListBtn.Name = "StudentListBtn";
            this.StudentListBtn.Size = new System.Drawing.Size(198, 38);
            this.StudentListBtn.TabIndex = 0;
            this.StudentListBtn.Text = "Student List";
            this.StudentListBtn.UseVisualStyleBackColor = true;
            this.StudentListBtn.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // StudentRegistrationBtn
            // 
            this.StudentRegistrationBtn.Location = new System.Drawing.Point(195, 92);
            this.StudentRegistrationBtn.Name = "StudentRegistrationBtn";
            this.StudentRegistrationBtn.Size = new System.Drawing.Size(198, 38);
            this.StudentRegistrationBtn.TabIndex = 0;
            this.StudentRegistrationBtn.Text = "Student Registration";
            this.StudentRegistrationBtn.UseVisualStyleBackColor = true;
            this.StudentRegistrationBtn.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 484);
            this.Controls.Add(this.StudentListPanel);
            this.Controls.Add(this.DateAndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.StudentPanel);
            this.Controls.Add(this.StudentPanelRegistrationPanel);
            this.Controls.Add(this.CanteenPanel);
            this.Controls.Add(this.AbscencePanel);
            this.Controls.Add(this.HomePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.StudentPanelRegistrationPanel.ResumeLayout(false);
            this.StudentPanelRegistrationPanel.PerformLayout();
            this.StudentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel StudentPanelRegistrationPanel;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StudentClassLbl;
        private System.Windows.Forms.ComboBox StudentClassCB;
        private System.Windows.Forms.TextBox StudentSchoolNumberTB;
        private System.Windows.Forms.Label StudentSchoolNumberLbl;
        private System.Windows.Forms.Panel StudentListPanel;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.Button StudentListBtn;
        private System.Windows.Forms.Button StudentRegistrationBtn;
    }
}