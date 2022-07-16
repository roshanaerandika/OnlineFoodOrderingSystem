using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleasCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wParam, int Iparam, int v);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string Admin_username = tb_admin.Text;
            string Admin_password = tb_pw.Text;

            if (Admin_username == "admin" && Admin_password == "1234")
            {
                Admin_pg ag = new Admin_pg();
                ag.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Pleace Check Your Username or Password! ");
            }


        }



        private void cut_Click(object sender, EventArgs e)
        {
            Application.Exit();




        }

        private void textbox_admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lable_Admin_login_Click(object sender, EventArgs e)
        {

        }

        private void forget_pw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset_Pw Reset = new Reset_Pw();
            Reset.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void Admin_username_Click(object sender, EventArgs e)
        {

        }

        private void CB_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_ShowPassword.Checked)
            {
                tb_pw.UseSystemPasswordChar = true;

            }
            else
            {
                tb_pw.UseSystemPasswordChar= false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            home F1 = new home();
            F1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Reg ad_reg = new Admin_Reg();
            ad_reg.Show();
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
