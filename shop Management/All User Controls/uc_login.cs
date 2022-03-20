using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_Management.All_User_Controls
{
    public partial class uc_login : UserControl
    {
        public uc_login()
        {
            InitializeComponent();
            lbl_error.Visible = false;
        }

        int abc=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;
                if(txt_username.Text =="subtain" && txt_password.Text == "123")
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    lbl_error.Visible = true;
                    timer1.Stop();

                }
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible=false;
            this.guna2WinProgressIndicator1.Start();

        }
    }
}
