namespace WindowsFormsApp2
{
    partial class Canteen
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cu_account = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Addfood = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.Home_cut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_edit_food = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_edit_food_price = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_bill = new System.Windows.Forms.Panel();
            this.bt_Ad_dashbord_home = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_cu_account.SuspendLayout();
            this.bt_Addfood.SuspendLayout();
            this.bt_edit_food.SuspendLayout();
            this.bt_edit_food_price.SuspendLayout();
            this.panel5.SuspendLayout();
            this.bt_bill.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "FOOD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = " AGNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_cu_account
            // 
            this.bt_cu_account.BackColor = System.Drawing.Color.DarkRed;
            this.bt_cu_account.Controls.Add(this.label2);
            this.bt_cu_account.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_cu_account.Location = new System.Drawing.Point(81, 210);
            this.bt_cu_account.Name = "bt_cu_account";
            this.bt_cu_account.Size = new System.Drawing.Size(165, 42);
            this.bt_cu_account.TabIndex = 0;
            this.bt_cu_account.Paint += new System.Windows.Forms.PaintEventHandler(this.pnp_admin_can_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(2, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Account";
            // 
            // bt_Addfood
            // 
            this.bt_Addfood.BackColor = System.Drawing.Color.DarkRed;
            this.bt_Addfood.Controls.Add(this.label16);
            this.bt_Addfood.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Addfood.Location = new System.Drawing.Point(81, 126);
            this.bt_Addfood.Name = "bt_Addfood";
            this.bt_Addfood.Size = new System.Drawing.Size(165, 42);
            this.bt_Addfood.TabIndex = 5;
            this.bt_Addfood.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label16.Location = new System.Drawing.Point(31, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "Add Food";
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
            this.Home_cut.Location = new System.Drawing.Point(758, 5);
            this.Home_cut.Name = "Home_cut";
            this.Home_cut.Size = new System.Drawing.Size(22, 22);
            this.Home_cut.TabIndex = 7;
            this.Home_cut.UseVisualStyleBackColor = false;
            this.Home_cut.Click += new System.EventHandler(this.Home_cut_Click);
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
            this.button3.Location = new System.Drawing.Point(731, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.subtract_30;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(706, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 22);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_edit_food
            // 
            this.bt_edit_food.BackColor = System.Drawing.Color.DarkRed;
            this.bt_edit_food.Controls.Add(this.label6);
            this.bt_edit_food.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_edit_food.Location = new System.Drawing.Point(314, 126);
            this.bt_edit_food.Name = "bt_edit_food";
            this.bt_edit_food.Size = new System.Drawing.Size(164, 42);
            this.bt_edit_food.TabIndex = 1;
            this.bt_edit_food.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(37, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Edit Food";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bt_edit_food_price
            // 
            this.bt_edit_food_price.BackColor = System.Drawing.Color.DarkRed;
            this.bt_edit_food_price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_edit_food_price.Controls.Add(this.label8);
            this.bt_edit_food_price.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_edit_food_price.Location = new System.Drawing.Point(535, 126);
            this.bt_edit_food_price.Name = "bt_edit_food_price";
            this.bt_edit_food_price.Size = new System.Drawing.Size(172, 42);
            this.bt_edit_food_price.TabIndex = 2;
            this.bt_edit_food_price.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(23, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Edit Food Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Controls.Add(this.label12);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Location = new System.Drawing.Point(535, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 42);
            this.panel5.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(15, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Check Feedback";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Salmon;
            this.label17.Location = new System.Drawing.Point(276, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 31);
            this.label17.TabIndex = 37;
            this.label17.Text = "Admin Dashbord";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(27, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bill/Payment";
            // 
            // bt_bill
            // 
            this.bt_bill.BackColor = System.Drawing.Color.DarkRed;
            this.bt_bill.Controls.Add(this.label10);
            this.bt_bill.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bt_bill.Location = new System.Drawing.Point(314, 210);
            this.bt_bill.Name = "bt_bill";
            this.bt_bill.Size = new System.Drawing.Size(164, 42);
            this.bt_bill.TabIndex = 3;
            // 
            // bt_Ad_dashbord_home
            // 
            this.bt_Ad_dashbord_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_Ad_dashbord_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Ad_dashbord_home.FlatAppearance.BorderSize = 0;
            this.bt_Ad_dashbord_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_Ad_dashbord_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Ad_dashbord_home.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ad_dashbord_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Ad_dashbord_home.Location = new System.Drawing.Point(535, 4);
            this.bt_Ad_dashbord_home.Name = "bt_Ad_dashbord_home";
            this.bt_Ad_dashbord_home.Size = new System.Drawing.Size(70, 29);
            this.bt_Ad_dashbord_home.TabIndex = 38;
            this.bt_Ad_dashbord_home.Text = "Home";
            this.bt_Ad_dashbord_home.UseVisualStyleBackColor = false;
            this.bt_Ad_dashbord_home.Click += new System.EventHandler(this.bt_Ad_dashbord_home_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(602, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Canteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Ad_dashbord_home);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bt_bill);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.bt_edit_food);
            this.Controls.Add(this.bt_edit_food_price);
            this.Controls.Add(this.bt_Addfood);
            this.Controls.Add(this.bt_cu_account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Home_cut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Canteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Canteen";
            this.Load += new System.EventHandler(this.Canteen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canteen_MouseDown);
            this.bt_cu_account.ResumeLayout(false);
            this.bt_cu_account.PerformLayout();
            this.bt_Addfood.ResumeLayout(false);
            this.bt_Addfood.PerformLayout();
            this.bt_edit_food.ResumeLayout(false);
            this.bt_edit_food.PerformLayout();
            this.bt_edit_food_price.ResumeLayout(false);
            this.bt_edit_food_price.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.bt_bill.ResumeLayout(false);
            this.bt_bill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Home_cut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bt_cu_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bt_Addfood;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel bt_edit_food;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel bt_edit_food_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel bt_bill;
        private System.Windows.Forms.Button bt_Ad_dashbord_home;
        private System.Windows.Forms.Button button1;
    }
}