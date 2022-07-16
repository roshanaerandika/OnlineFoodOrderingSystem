namespace WindowsFormsApp2
{
    partial class home
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
            this.customer = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minimize_bu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Home_cut = new System.Windows.Forms.Button();
            this.HomeProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // customer
            // 
            this.customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customer.BackColor = System.Drawing.Color.IndianRed;
            this.customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customer.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Black;
            this.customer.Location = new System.Drawing.Point(326, 259);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(170, 42);
            this.customer.TabIndex = 1;
            this.customer.Text = "CUSTOMER";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.Admin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Admin.BackColor = System.Drawing.Color.IndianRed;
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Admin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.Black;
            this.Admin.Location = new System.Drawing.Point(326, 92);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(170, 42);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "ADMIN";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = " AGNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "FOOD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(253, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "WelCome to Agni Food";
            // 
            // minimize_bu
            // 
            this.minimize_bu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_bu.BackColor = System.Drawing.Color.Transparent;
            this.minimize_bu.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.subtract_30;
            this.minimize_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_bu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.minimize_bu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.minimize_bu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_bu.ForeColor = System.Drawing.Color.White;
            this.minimize_bu.Location = new System.Drawing.Point(720, 4);
            this.minimize_bu.Name = "minimize_bu";
            this.minimize_bu.Size = new System.Drawing.Size(20, 22);
            this.minimize_bu.TabIndex = 4;
            this.minimize_bu.UseVisualStyleBackColor = false;
            this.minimize_bu.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.maximize_window_30;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(745, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Home_cut
            // 
            this.Home_cut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_cut.BackColor = System.Drawing.Color.Transparent;
            this.Home_cut.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.close_30;
            this.Home_cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home_cut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Home_cut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Home_cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_cut.ForeColor = System.Drawing.Color.White;
            this.Home_cut.Location = new System.Drawing.Point(773, 4);
            this.Home_cut.Name = "Home_cut";
            this.Home_cut.Size = new System.Drawing.Size(22, 22);
            this.Home_cut.TabIndex = 4;
            this.Home_cut.UseVisualStyleBackColor = false;
            this.Home_cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // HomeProgress
            // 
            this.HomeProgress.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimize_bu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Home_cut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.customer);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Home_cut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button minimize_bu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer HomeProgress;
    }
}

