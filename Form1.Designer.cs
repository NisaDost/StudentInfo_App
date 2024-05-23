namespace StudentInfo_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoginButton.Location = new System.Drawing.Point(557, 386);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(232, 48);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(113, 105);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.UsernameLabel.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(116, 131);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.PasswordLabel.TabIndex = 2;
            // 
            // EmailInput
            // 
            this.EmailInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailInput.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailInput.Location = new System.Drawing.Point(557, 242);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.MaxLength = 30;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(232, 20);
            this.EmailInput.TabIndex = 1;
            this.EmailInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AppName.Location = new System.Drawing.Point(524, 61);
            this.AppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(334, 66);
            this.AppName.TabIndex = 6;
            this.AppName.Text = "TrackSchool";
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.BackColor = System.Drawing.Color.Transparent;
            this.LoginText.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginText.Location = new System.Drawing.Point(599, 131);
            this.LoginText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(165, 33);
            this.LoginText.TabIndex = 6;
            this.LoginText.Text = "Please Login";
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.BackColor = System.Drawing.Color.Transparent;
            this.EmailText.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailText.Location = new System.Drawing.Point(554, 218);
            this.EmailText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(58, 22);
            this.EmailText.TabIndex = 6;
            this.EmailText.Text = "Email:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordInput.Location = new System.Drawing.Point(557, 308);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordInput.MaxLength = 15;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(232, 20);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            this.PasswordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordInput_KeyDown);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.BackColor = System.Drawing.Color.Transparent;
            this.PasswordText.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordText.Location = new System.Drawing.Point(554, 284);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(90, 22);
            this.PasswordText.TabIndex = 6;
            this.PasswordText.Text = "Password:";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.LightCoral;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.QuitButton.Location = new System.Drawing.Point(815, 10);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(41, 27);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 540);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Button QuitButton;
    }
}

