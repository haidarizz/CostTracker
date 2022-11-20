using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostTracker
{
    partial class ViewIncome : Form
    {
        public User Pengguna;
        public ViewIncome(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.Name;
        }
        private NpgsqlConnection conn;
        string connstring = "Host=Localhost;Port=5432;Username=postgres;Password=junpro7;Database=CostTracker";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Pengguna);
            dashboard.Show();
            this.Hide();
        }

        private void pbExpenses_Click(object sender, EventArgs e)
        {
            ViewExpenses viewexpenses = new ViewExpenses(Pengguna);
            viewexpenses.Show();
            this.Hide();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout(Pengguna);
            logout.Show();
            this.Hide();
        }

        private void ViewIncome_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoadIncome_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvIncome.DataSource = null;
                sql = "select * from tb_income where id_user = '" + Pengguna.ID_user + "'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvIncome.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvIncome.Rows[e.RowIndex];
            }
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin nenghapus data dengan ID: " + r.Cells["id_income"].Value.ToString() + " ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                conn.Open();
                sql = @"select * from st_delete_income(:id_income)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_income", r.Cells["id_income"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadIncome.PerformClick();
                    r = null;
                }
            }
        }
    }
}
