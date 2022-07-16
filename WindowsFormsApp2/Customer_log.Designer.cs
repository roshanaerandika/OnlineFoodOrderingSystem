namespace WindowsFormsApp2
{
    partial class Customer_log
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lable_Customer_login = new System.Windows.Forms.Label();
            this.CB_ShowPassword = new System.Windows.Forms.CheckBox();
            this.bt_cu_forget_pw = new System.Windows.Forms.Button();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.bt_cu_create_acc = new System.Windows.Forms.Button();
            this.bt_cu_Clear = new System.Windows.Forms.Button();
            this.bt_cu_log = new System.Windows.Forms.Button();
            this.Admin_password = new System.Windows.Forms.Label();
            this.tb_admin = new System.Windows.Forms.TextBox();
            this.Admin_username = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cu_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "AGNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(-1, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "FOOD";
            // 
            // lable_Customer_login
            // 
            this.lable_Customer_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_Customer_login.AutoSize = true;
            this.lable_Customer_login.BackColor = System.Drawing.Color.Transparent;
            this.lable_Customer_login.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_Customer_login.ForeColor = System.Drawing.Color.Salmon;
            this.lable_Customer_login.Location = new System.Drawing.Point(266, 40);
            this.lable_Customer_login.Name = "lable_Customer_login";
            this.lable_Customer_login.Size = new System.Drawing.Size(255, 36);
            this.lable_Customer_login.TabIndex = 14;
            this.lable_Customer_login.Text = "Customer Log In ";
            this.lable_Customer_login.Click += new System.EventHandler(this.lable_Customer_login_Click);
            // 
            // CB_ShowPassword
            // 
            this.CB_ShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_ShowPassword.AutoSize = true;
            this.CB_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.CB_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ShowPassword.Location = new System.Drawing.Point(436, 197);
            this.CB_ShowPassword.Name = "CB_ShowPassword";
            this.CB_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.CB_ShowPassword.TabIndex = 23;
            this.CB_ShowPassword.Text = "Show Password";
            this.CB_ShowPassword.UseVisualStyleBackColor = false;
            // 
            // bt_cu_forget_pw
            // 
            this.bt_cu_forget_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cu_forget_pw.BackColor = System.Drawing.Color.Transparent;
            this.bt_cu_forget_pw.FlatAppearance.BorderSize = 0;
            this.bt_cu_forget_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cu_forget_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_cu_forget_pw.Location = new System.Drawing.Point(363, 220);
            this.bt_cu_forget_pw.Name = "bt_cu_forget_pw";
            this.bt_cu_forget_pw.Size = new System.Drawing.Size(101, 26);
            this.bt_cu_forget_pw.TabIndex = 22;
            this.bt_cu_forget_pw.Text = "Forget password";
            this.bt_cu_forget_pw.UseVisualStyleBackColor = false;
            // 
            // tb_pw
            // 
            this.tb_pw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pw.Location = new System.Drawing.Point(245, 194);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(185, 20);
            this.tb_pw.TabIndex = 21;
            // 
            // bt_cu_create_acc
            // 
            this.bt_cu_create_acc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cu_create_acc.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cu_create_acc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cu_create_acc.Location = new System.Drawing.Point(230, 271);
            this.bt_cu_create_acc.Name = "bt_cu_create_acc";
            this.bt_cu_create_acc.Size = new System.Drawing.Size(185, 42);
            this.bt_cu_create_acc.TabIndex = 16;
            this.bt_cu_create_acc.Text = "Create a Account";
            this.bt_cu_create_acc.UseVisualStyleBackColor = false;
            this.bt_cu_create_acc.Click += new System.EventHandler(this.Admin_reg_in_log_Click);
            // 
            // bt_cu_Clear
            // 
            this.bt_cu_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cu_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cu_Clear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cu_Clear.Location = new System.Drawing.Point(648, 180);
            this.bt_cu_Clear.Name = "bt_cu_Clear";
            this.bt_cu_Clear.Size = new System.Drawing.Size(93, 40);
            this.bt_cu_Clear.TabIndex = 17;
            this.bt_cu_Clear.Text = "Clear";
            this.bt_cu_Clear.UseVisualStyleBackColor = false;
            this.bt_cu_Clear.Click += new System.EventHandler(this.admin_log_bt_back_Click);
            // 
            // bt_cu_log
            // 
            this.bt_cu_log.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_cu_log.AutoSize = true;
            this.bt_cu_log.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cu_log.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cu_log.Location = new System.Drawing.Point(597, 239);
            this.bt_cu_log.Name = "bt_cu_log";
            this.bt_cu_log.Size = new System.Drawing.Size(144, 42);
            this.bt_cu_log.TabIndex = 18;
            this.bt_cu_log.Text = "LOGIN";
            this.bt_cu_log.UseVisualStyleBackColor = false;
            this.bt_cu_log.Click += new System.EventHandler(this.Admin_login_Click);
            // 
            // Admin_password
            // 
            this.Admin_password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Admin_password.AutoSize = true;
            this.Admin_password.BackColor = System.Drawing.Color.Transparent;
            this.Admin_password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Admin_password.Location = new System.Drawing.Point(145, 195);
            this.Admin_password.Name = "Admin_password";
            this.Admin_password.Size = new System.Drawing.Size(100, 22);
            this.Admin_password.TabIndex = 20;
            this.Admin_password.Text = "Password :";
            // 
            // tb_admin
            // 
            this.tb_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_admin.Location = new System.Drawing.Point(245, 135);
            this.tb_admin.Name = "tb_admin";
            this.tb_admin.Size = new System.Drawing.Size(185, 20);
            this.tb_admin.TabIndex = 19;
            // 
            // Admin_username
            // 
            this.Admin_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Admin_username.AutoSize = true;
            this.Admin_username.BackColor = System.Drawing.Color.Transparent;
            this.Admin_username.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Admin_username.Location = new System.Drawing.Point(121, 134);
            this.Admin_username.Name = "Admin_username";
            this.Admin_username.Size = new System.Drawing.Size(123, 22);
            this.Admin_username.TabIndex = 15;
            this.Admin_username.Text = "University ID:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.subtract_30;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(720, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 22);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.maximize_window_30;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(746, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cut
            // 
            this.cut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cut.BackColor = System.Drawing.Color.Transparent;
            this.cut.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.close_30;
            this.cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Location = new System.Drawing.Point(773, 4);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(22, 22);
            this.cut.TabIndex = 24;
            this.cut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Don\'t Have Account";
            // 
            // bt_cu_home
            // 
            this.bt_cu_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_cu_home.FlatAppearance.BorderSize = 0;
            this.bt_cu_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_cu_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cu_home.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cu_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_cu_home.Location = new System.Drawing.Point(648, 1);
            this.bt_cu_home.Name = "bt_cu_home";
            this.bt_cu_home.Size = new System.Drawing.Size(70, 25);
            this.bt_cu_home.TabIndex = 28;
            this.bt_cu_home.Text = "Home";
            this.bt_cu_home.UseVisualStyleBackColor = false;
            // 
            // Customer_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.bt_cu_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.CB_ShowPassword);
            this.Controls.Add(this.bt_cu_forget_pw);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.bt_cu_create_acc);
            this.Controls.Add(this.bt_cu_Clear);
            this.Controls.Add(this.bt_cu_log);
            this.Controls.Add(this.Admin_password);
            this.Controls.Add(this.tb_admin);
            this.Controls.Add(this.Admin_username);
            this.Controls.Add(this.lable_Customer_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer_log";
            this.Load += new System.EventHandler(this.Customer_log_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Customer_log_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable_Customer_login;
        private System.Windows.Forms.CheckBox CB_ShowPassword;
        private System.Windows.Forms.Button bt_cu_forget_pw;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button bt_cu_create_acc;
        private System.Windows.Forms.Button bt_cu_Clear;
        private System.Windows.Forms.Button bt_cu_log;
        private System.Windows.Forms.Label Admin_password;
        private System.Windows.Forms.TextBox tb_admin;
        private System.Windows.Forms.Label Admin_username;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cu_home;
    }
}