using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shop_Management.All_User_Controls
{
    public partial class cust_puchase : UserControl
    {
        function fn = new function();
        string query;
        public cust_puchase()
        {
            InitializeComponent();
        }

        private void cust_puchase_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (tx_name.Text!="" && txt_gender.Text!="" && txt_contact.Text!="" && txt_mail.Text!="" && txt_company.Text!="" ) {
                query = "insert into purchase(cust_name,gender,contact,email,address,company,model,imei) Values " +
                    "('" + tx_name.Text + "','" + txt_gender.Text + "','" + txt_contact.Text + "','" + txt_mail.Text + "'," +
                    "'" + txt_address.Text + "','" + txt_company.Text + "','" + txt_model.Text + "','" + txt_imei.Text + "')";
                fn.setdata(query);
            }

        }
        public void setcombo(string query,ComboBox combo)
        {
            SqlDataReader dr = fn.getforcombo(query);  //select model
            while (dr.Read())
            {
                for (int i=0; i<dr.FieldCount; i++)
                {
                    combo.Items.Add(dr.GetString(i));
                }
            }

        }

        private void cust_puchase_Enter(object sender, EventArgs e)
        {
            txt_company.Items.Clear();
            query = "select distinct cname from add_mobile";
            setcombo(query, txt_company);
        }

        private void txt_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_model.Items.Clear();
            string cname=txt_company.Text;
            query = "select model_name from add_mobile where cname='" + cname + "'";
            setcombo(query, txt_model);
        }

        private void txt_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ShadowPanel1.BorderStyle = BorderStyle.FixedSingle;
            query = "select * from add_mobile where model_name='" + txt_model.Text + "'";
            DataSet ds= fn.getdata(query);

            lbl_ram.Text = ds.Tables[0].Rows[0][3].ToString();
            lbl_internal.Text = ds.Tables[0].Rows[0][4].ToString();
            lbl_expandable.Text = ds.Tables[0].Rows[0][5].ToString();
            lbl_rear.Text = ds.Tables[0].Rows[0][7].ToString();
            lbl_front.Text = ds.Tables[0].Rows[0][8].ToString();
            lbl_finger.Text = ds.Tables[0].Rows[0][9].ToString();
            lbl_price.Text = ds.Tables[0].Rows[0][12].ToString();

        }
    }
}
