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
    public partial class uc_addmobile : UserControl
    {
        function fn = new function();
        string query;
        public uc_addmobile()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_addmobile_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_company.Text != "" && txt_model.Text!="" || txt_ram.Text != "" && txt_internal.Text!="" && txt_ram.Text!="" && txt_price.Text!="" )
     {

                string company = txt_company.Text;
                string model = txt_model.Text;
                string ram = txt_ram.Text;
                string inter = txt_internal.Text;
                string expand = txt_external.Text;
                string display = txt_displau.Text;
                string rear = txt_rearC.Text;
                string front = txt_rearC.Text;
                string finger = txt_fingerprint.Text;
                string sim = txt_sim.Text;
                string network = txt_network.Text;
                string price = txt_price.Text;

                query = "insert into add_mobile(cname,model_name,ram,internal,expandable,display,rear,front,fingerprint,sim,network,price) values " +
                    "('" + company + "','" + model + "','" + ram + "','" + inter + "','" + expand + "','" + display + "','" + rear + "','" + front + "'," +
                    "'" + finger + "','" + sim + "','" + network + "','" + price + "')";
                fn.setdata(query); 
            }
            else
            {
                MessageBox.Show("Fill all entries.", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            txt_company.Clear();
            txt_model.Clear();
            txt_price.Clear();
            txt_ram.SelectedIndex = -1;
            txt_internal.SelectedIndex = -1;
            txt_external.SelectedIndex = -1;
            txt_displau.SelectedIndex = -1;
            txt_rearC.SelectedIndex = -1;
            txt_frontC.SelectedIndex = -1;
            txt_fingerprint.SelectedIndex = -1;
            txt_sim.SelectedIndex = -1;
            txt_network.SelectedIndex = -1;
        }

        private void label3_Enter(object sender, EventArgs e)
        {

        }
    }
}
