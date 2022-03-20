using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            uc_stock1.Visible = false;
            uc_addmobile1.Visible = false;
            cust_puchase1.Visible = false;
            uc_customer_record1.Visible = false;
            uc_removedetail1.Visible = false;
            enabledisable(false,false,false);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_addmobile1.Visible=true;
            uc_addmobile1.BringToFront();
            cust_puchase1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cust_puchase1.Visible=true;
            cust_puchase1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uc_stock1.Visible=true;
            uc_stock1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uc_customer_record1.Visible = true;
            uc_customer_record1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enabledisable(true, true, true);
            //uc_removedetail1.Show();
            //uc_removedetail1.BringToFront();

            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enabledisable(false,false, false);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "abc")
            {
                panel2.Enabled = true;
                uc_removedetail1.Visible=true;
                uc_removedetail1.BringToFront();
                enabledisable(false,false,false);
                txt_pass.Clear();
            }
            else
            {
                txt_pass.Clear();
            }
        }
        public void enabledisable(Boolean txtbox,Boolean btn1,Boolean btn2)
        {
            txt_pass.Visible = txtbox;
            btn_cancel.Visible = btn1;
            btn_verify.Visible = btn2;

        }

        private void uc_login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btn_addmobile.PerformClick();
        }
    }
}
