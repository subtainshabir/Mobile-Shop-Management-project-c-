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
    public partial class uc_customer_record : UserControl
    {
        function fn = new function();
        string query;
        public uc_customer_record()
        {
            InitializeComponent();
        }

        private void uc_customer_record_Enter(object sender, EventArgs e)
        {
            query = "select * from purchase";
            DataSet ds = fn.getdata(query);
            guna2DataGridView1.DataSource=ds.Tables[0];
            


        }

        Boolean Flag;
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchby.SelectedIndex == 0)
            {
                Flag=false;
                lbl_toset.Text = "Enter Customer name";
            }
            else if (searchby.SelectedIndex == 1)
            {
                Flag = true;
                lbl_toset.Text = "Enter IMEI";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                query = "select * from purchase where cust_name like'"+txt_toset.Text+"%'";
                DataSet ds = fn.getdata(query);
                guna2DataGridView1.DataSource=ds.Tables[0];


            }
            else
            {
                query = "select * from purchase where imei like '" + txt_toset.Text + "%'";
                DataSet ds = fn.getdata(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
