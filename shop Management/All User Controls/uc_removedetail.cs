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
    public partial class uc_removedetail : UserControl
    {
        function fn = new function();
        string query;
        public uc_removedetail()
        {
            InitializeComponent();
        }

        private void uc_removedetail_Enter(object sender, EventArgs e)
        {
            query = "select * from add_mobile";
            DataSet ds=fn.getdata(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txt_toset_TextChanged(object sender, EventArgs e)
        {
            query = "select * from add_mobile where cname like'" + txt_search.Text + "%' or model_name like '"+txt_search.Text+"%'";
            DataSet ds = fn.getdata(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        int bid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            query = "delete from add_mobile where m_id=" + bid + "";
            if (MessageBox.Show("Deleting Record of " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.getdata(query);
            }
            else
            {
                MessageBox.Show("You Canceled Deletion.","Back <-",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        
    }
}
