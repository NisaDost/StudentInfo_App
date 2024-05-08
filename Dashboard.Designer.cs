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
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(229, 596);
            this.MenuBar.TabIndex = 0;
            // 
            // StudentsButton
            // 
            this.StudentsButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StudentsButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.StudentsButton.Location = new System.Drawing.Point(12, 206);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(198, 41);
            this.StudentsButton.TabIndex = 1;
            this.StudentsButton.Text = "Students";
            this.StudentsButton.UseVisualStyleBackColor = false;
            this.StudentsButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // AbscenceButton
            // 
            this.AbscenceButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AbscenceButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AbscenceButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AbscenceButton.Location = new System.Drawing.Point(12, 300);
            this.AbscenceButton.Name = "AbscenceButton";
            this.AbscenceButton.Size = new System.Drawing.Size(198, 41);
            this.AbscenceButton.TabIndex = 1;
            this.AbscenceButton.Text = "Abscence";
            this.AbscenceButton.UseVisualStyleBackColor = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.LogoutButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LogoutButton.Location = new System.Drawing.Point(12, 543);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(198, 41);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            // 
            // CanteenButton
            // 
            this.CanteenButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CanteenButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CanteenButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CanteenButton.Location = new System.Drawing.Point(12, 253);
            this.CanteenButton.Name = "CanteenButton";
            this.CanteenButton.Size = new System.Drawing.Size(198, 41);
            this.CanteenButton.TabIndex = 1;
            this.CanteenButton.Text = "Canteen";
            this.CanteenButton.UseVisualStyleBackColor = false;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.HomeButton.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.HomeButton.Location = new System.Drawing.Point(12, 159);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(198, 41);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(65, 31);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(96, 104);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WelcomeText.Location = new System.Drawing.Point(388, 97);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(634, 38);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "Welcome to your dashboard, Emre Olca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(390, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Your School";
            // 
            // DashboardText2
            // 
            this.DashboardText2.AutoSize = true;
            this.DashboardText2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DashboardText2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DashboardText2.Location = new System.Drawing.Point(430, 209);
            this.DashboardText2.Name = "DashboardText2";
            this.DashboardText2.Size = new System.Drawing.Size(195, 27);
            this.DashboardText2.TabIndex = 1;
            this.DashboardText2.Text = "Add other admins";
            // 
            // DasboardText3
            // 
            this.DasboardText3.AutoSize = true;
            this.DasboardText3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DasboardText3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DasboardText3.Location = new System.Drawing.Point(430, 300);
            this.DasboardText3.Name = "DasboardText3";
            this.DasboardText3.Size = new System.Drawing.Size(134, 27);
            this.DasboardText3.TabIndex = 1;
            this.DasboardText3.Text = "Add classes ";
            // 
            // DashboardText4
            // 
            this.DashboardText4.AutoSize = true;
            this.DashboardText4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DashboardText4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DashboardText4.Location = new System.Drawing.Point(430, 406);
            this.DashboardText4.Name = "DashboardText4";
            this.DashboardText4.Size = new System.Drawing.Size(148, 27);
            this.DashboardText4.TabIndex = 1;
            this.DashboardText4.Text = "Add students";
            // 
            // StudentPanel
            // 
            this.StudentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentPanel.Location = new System.Drawing.Point(229, 0);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(987, 596);
            this.StudentPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 596);
            this.Controls.Add(this.StudentPanel);
            this.Controls.Add(this.DashboardText4);
            this.Controls.Add(this.DasboardText3);
            this.Controls.Add(this.DashboardText2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
        private System.Windows.Forms.Panel StudentPanel;
    }
}