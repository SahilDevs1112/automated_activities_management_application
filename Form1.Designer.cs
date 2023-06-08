namespace Automated_Activities
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LogoText = new System.Windows.Forms.Label();
            this.CopyRightText = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ShowPasswordCB = new System.Windows.Forms.CheckBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInPanel1 = new System.Windows.Forms.Panel();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.ExitLoginBtn = new System.Windows.Forms.Label();
            this.LogInPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoText
            // 
            this.LogoText.BackColor = System.Drawing.Color.Black;
            this.LogoText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoText.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.LogoText.Location = new System.Drawing.Point(324, 39);
            this.LogoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoText.Name = "LogoText";
            this.LogoText.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.LogoText.Size = new System.Drawing.Size(283, 56);
            this.LogoText.TabIndex = 0;
            this.LogoText.Text = "Activites Automated";
            this.LogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyRightText
            // 
            this.CopyRightText.AutoSize = true;
            this.CopyRightText.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRightText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CopyRightText.Location = new System.Drawing.Point(728, 371);
            this.CopyRightText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyRightText.Name = "CopyRightText";
            this.CopyRightText.Size = new System.Drawing.Size(107, 15);
            this.CopyRightText.TabIndex = 1;
            this.CopyRightText.Text = "@By Sahil Khunita";
            this.CopyRightText.UseMnemonic = false;
            // 
            // UserNameTB
            // 
            this.UserNameTB.BackColor = System.Drawing.Color.Black;
            this.UserNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTB.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.ForeColor = System.Drawing.Color.White;
            this.UserNameTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserNameTB.Location = new System.Drawing.Point(357, 135);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(211, 19);
            this.UserNameTB.TabIndex = 3;
            this.UserNameTB.Text = "User Name";
            this.UserNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.Black;
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.Color.White;
            this.PasswordTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordTB.Location = new System.Drawing.Point(357, 190);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(211, 19);
            this.PasswordTB.TabIndex = 4;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowPasswordCB
            // 
            this.ShowPasswordCB.AutoSize = true;
            this.ShowPasswordCB.ForeColor = System.Drawing.Color.Black;
            this.ShowPasswordCB.Location = new System.Drawing.Point(577, 191);
            this.ShowPasswordCB.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPasswordCB.Name = "ShowPasswordCB";
            this.ShowPasswordCB.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCB.TabIndex = 5;
            this.ShowPasswordCB.Text = "Show Password";
            this.ShowPasswordCB.UseVisualStyleBackColor = true;
            this.ShowPasswordCB.CheckedChanged += new System.EventHandler(this.ShowPasswordCB_CheckedChanged);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Black;
            this.LogInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogInBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogInBtn.FlatAppearance.BorderSize = 20;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.LogInBtn.Location = new System.Drawing.Point(413, 250);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(105, 33);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Black;
            this.SignUpBtn.Location = new System.Drawing.Point(504, 301);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(53, 17);
            this.SignUpBtn.TabIndex = 7;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(361, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "New to the App Please ->";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogInPanel1
            // 
            this.LogInPanel1.BackColor = System.Drawing.Color.Gray;
            this.LogInPanel1.Controls.Add(this.LogoImage);
            this.LogInPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogInPanel1.Location = new System.Drawing.Point(0, 0);
            this.LogInPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.LogInPanel1.Name = "LogInPanel1";
            this.LogInPanel1.Size = new System.Drawing.Size(192, 395);
            this.LogInPanel1.TabIndex = 10;
            // 
            // LogoImage
            // 
            this.LogoImage.Image = global::Automated_Activities.Properties.Resources.logo;
            this.LogoImage.Location = new System.Drawing.Point(55, 117);
            this.LogoImage.Margin = new System.Windows.Forms.Padding(4);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(104, 92);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // ExitLoginBtn
            // 
            this.ExitLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitLoginBtn.AutoSize = true;
            this.ExitLoginBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ExitLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLoginBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitLoginBtn.Location = new System.Drawing.Point(832, 0);
            this.ExitLoginBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitLoginBtn.Name = "ExitLoginBtn";
            this.ExitLoginBtn.Size = new System.Drawing.Size(16, 16);
            this.ExitLoginBtn.TabIndex = 11;
            this.ExitLoginBtn.Text = "X";
            this.ExitLoginBtn.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(848, 395);
            this.Controls.Add(this.ExitLoginBtn);
            this.Controls.Add(this.LogInPanel1);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.ShowPasswordCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.CopyRightText);
            this.Controls.Add(this.LogoText);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Activites";
            this.LogInPanel1.ResumeLayout(false);
            this.LogInPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Label CopyRightText;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.CheckBox ShowPasswordCB;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label SignUpBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LogInPanel1;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Label ExitLoginBtn;
    }
}

