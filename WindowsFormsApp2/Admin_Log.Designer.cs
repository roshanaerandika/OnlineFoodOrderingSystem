namespace WindowsFormsApp2
{
    partial class LOGIN
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
            this.Admin_username = new System.Windows.Forms.Label();
            this.tb_admin = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.Admin_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forget_pw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_ShowPassword = new System.Windows.Forms.CheckBox();
            this.bt_Admin_login = new System.Windows.Forms.Button();
            this.lable_Admin_login = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.bt_adm_Clear = new System.Windows.Forms.Button();
            this.bt_ad_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_username
            // 
            this.Admin_username.AutoSize = true;
            this.Admin_username.BackColor = System.Drawing.Color.Transparent;
            this.Admin_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Admin_username.Location = new System.Drawing.Point(110, 174);
            this.Admin_username.Name = "Admin_username";
            this.Admin_username.Size = new System.Drawing.Size(109, 19);
            this.Admin_username.TabIndex = 1;
            this.Admin_username.Text = "USERNAME :";
            this.Admin_username.Click += new System.EventHandler(this.Admin_username_Click);
            // 
            // tb_admin
            // 
            this.tb_admin.Location = new System.Drawing.Point(239, 175);
            this.tb_admin.Name = "tb_admin";
            this.tb_admin.Size = new System.Drawing.Size(185, 20);
            this.tb_admin.TabIndex = 2;
            this.tb_admin.TextChanged += new System.EventHandler(this.textbox_admin_TextChanged);
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(239, 234);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(185, 20);
            this.tb_pw.TabIndex = 4;
            // 
            // Admin_password
            // 
            this.Admin_password.AutoSize = true;
            this.Admin_password.BackColor = System.Drawing.Color.Transparent;
            this.Admin_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Admin_password.Location = new System.Drawing.Point(113, 235);
            this.Admin_password.Name = "Admin_password";
            this.Admin_password.Size = new System.Drawing.Size(106, 19);
            this.Admin_password.TabIndex = 3;
            this.Admin_password.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "AGNI";
            // 
            // forget_pw
            // 
            this.forget_pw.BackColor = System.Drawing.Color.Transparent;
            this.forget_pw.FlatAppearance.BorderSize = 0;
            this.forget_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forget_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.forget_pw.Location = new System.Drawing.Point(357, 260);
            this.forget_pw.Name = "forget_pw";
            this.forget_pw.Size = new System.Drawing.Size(101, 26);
            this.forget_pw.TabIndex = 6;
            this.forget_pw.Text = "Forget password";
            this.forget_pw.UseVisualStyleBackColor = false;
            this.forget_pw.Click += new System.EventHandler(this.forget_pw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(2, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "FOOD";
            // 
            // CB_ShowPassword
            // 
            this.CB_ShowPassword.AutoSize = true;
            this.CB_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.CB_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CB_ShowPassword.Location = new System.Drawing.Point(447, 237);
            this.CB_ShowPassword.Name = "CB_ShowPassword";
            this.CB_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.CB_ShowPassword.TabIndex = 9;
            this.CB_ShowPassword.Text = "Show Password";
            this.CB_ShowPassword.UseVisualStyleBackColor = false;
            this.CB_ShowPassword.CheckedChanged += new System.EventHandler(this.CB_ShowPassword_CheckedChanged);
            // 
            // bt_Admin_login
            // 
            this.bt_Admin_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Admin_login.AutoSize = true;
            this.bt_Admin_login.BackColor = System.Drawing.Color.IndianRed;
            this.bt_Admin_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Admin_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Admin_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Admin_login.Location = new System.Drawing.Point(239, 300);
            this.bt_Admin_login.Name = "bt_Admin_login";
            this.bt_Admin_login.Size = new System.Drawing.Size(107, 41);
            this.bt_Admin_login.TabIndex = 2;
            this.bt_Admin_login.Text = "Log in";
            this.bt_Admin_login.UseVisualStyleBackColor = false;
            this.bt_Admin_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lable_Admin_login
            // 
            this.lable_Admin_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lable_Admin_login.AutoSize = true;
            this.lable_Admin_login.BackColor = System.Drawing.Color.Transparent;
            this.lable_Admin_login.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_Admin_login.ForeColor = System.Drawing.Color.Salmon;
            this.lable_Admin_login.Location = new System.Drawing.Point(297, 44);
            this.lable_Admin_login.Name = "lable_Admin_login";
            this.lable_Admin_login.Size = new System.Drawing.Size(216, 36);
            this.lable_Admin_login.TabIndex = 13;
            this.lable_Admin_login.Text = "Admin Log In ";
            this.lable_Admin_login.Click += new System.EventHandler(this.lable_Admin_login_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.subtract_30;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(720, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 22);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.maximize_window_30;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(746, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cut
            // 
            this.cut.BackColor = System.Drawing.Color.Transparent;
            this.cut.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.close_30;
            this.cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cut.Location = new System.Drawing.Point(775, 4);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(22, 22);
            this.cut.TabIndex = 10;
            this.cut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // bt_adm_Clear
            // 
            this.bt_adm_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_adm_Clear.AutoSize = true;
            this.bt_adm_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.bt_adm_Clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_adm_Clear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adm_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_adm_Clear.Location = new System.Drawing.Point(368, 300);
            this.bt_adm_Clear.Name = "bt_adm_Clear";
            this.bt_adm_Clear.Size = new System.Drawing.Size(100, 41);
            this.bt_adm_Clear.TabIndex = 2;
            this.bt_adm_Clear.Text = "Clear";
            this.bt_adm_Clear.UseVisualStyleBackColor = false;
            this.bt_adm_Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ad_home
            // 
            this.bt_ad_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_ad_home.FlatAppearance.BorderSize = 0;
            this.bt_ad_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_ad_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ad_home.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ad_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_ad_home.Location = new System.Drawing.Point(614, 2);
            this.bt_ad_home.Name = "bt_ad_home";
            this.bt_ad_home.Size = new System.Drawing.Size(100, 31);
            this.bt_ad_home.TabIndex = 14;
            this.bt_ad_home.Text = "Home";
            this.bt_ad_home.UseVisualStyleBackColor = false;
            this.bt_ad_home.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.bt_ad_home);
            this.Controls.Add(this.lable_Admin_login);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.CB_ShowPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forget_pw);
            this.Controls.Add(this.bt_adm_Clear);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.bt_Admin_login);
            this.Controls.Add(this.Admin_password);
            this.Controls.Add(this.tb_admin);
            this.Controls.Add(this.Admin_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LOGIN_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Admin_username;
        private System.Windows.Forms.TextBox tb_admin;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label Admin_password;
        private System.Windows.Forms.Button bt_Admin_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button forget_pw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CB_ShowPassword;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lable_Admin_login;
        private System.Windows.Forms.Button bt_adm_Clear;
        private System.Windows.Forms.Button bt_ad_home;
    }
}