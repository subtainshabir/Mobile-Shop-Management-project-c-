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
    public partial class uc_stock : UserControl
    {
        function fn = new function();
        string query;
        public uc_stock()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_stock_Load(object sender, EventArgs e)
        {

        }

        private void uc_stock_Enter(object sender, EventArgs e)
        {
            query = "select * from add_mobile";
            DataSet ds=fn.getdata(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int m_id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                m_id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from add_mobile where m_id=" + m_id + "";
            DataSet ds = fn.getdata(query);

            company.Text=ds.Tables[0].Rows[0][1].ToString();
            model.Text = ds.Tables[0].Rows[0][2].ToString();
            ram.Text = ds.Tables[0].Rows[0][3].ToString();
            inter.Text = ds.Tables[0].Rows[0][4].ToString();
            expand.Text = ds.Tables[0].Rows[0][5].ToString();
            display.Text = ds.Tables[0].Rows[0][6].ToString();
            rearC.Text = ds.Tables[0].Rows[0][7].ToString();
            frontC.Text = ds.Tables[0].Rows[0][8].ToString();
            finger.Text = ds.Tables[0].Rows[0][9].ToString();
            sim.Text = ds.Tables[0].Rows[0][10].ToString();
            network.Text = ds.Tables[0].Rows[0][11].ToString();
            imei.Text = ds.Tables[0].Rows[0][12].ToString();
        }
    }
}
