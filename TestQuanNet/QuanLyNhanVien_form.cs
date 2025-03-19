using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuanNet
{
    public partial class QuanLyNhanVien_form : Form
    {
        public QuanLyNhanVien_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "data source=MSI\\HUY;initial catalog=QLNV1;trusted_connection=true";
                var conn = new SqlConnection(path);
                var command = new SqlDataAdapter("select * from NhanVien", conn);
                var table = new DataTable();
                command.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
