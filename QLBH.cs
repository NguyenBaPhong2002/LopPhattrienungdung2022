using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LopPhattrienungdung2022
{
    public partial class QLBH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public QLBH()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grddata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void QLBH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=FONGFINGFONG;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaNhom, MaHH, TenHH, Dvt, SanXuat  from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();

        }
        private void NapCT()
        {
            int i = grddata.CurrentRow.Index;
            txtMaNhom.Text = grddata.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMaHH.Text = grddata.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = grddata.Rows[i].Cells["TenHH"].Value.ToString();
            txtDvt.Text = grddata.Rows[i].Cells["Dvt"].Value.ToString();
            txtSanXuat.Text = grddata.Rows[i].Cells["SanXuat"].Value.ToString();
        }
    }
}
 