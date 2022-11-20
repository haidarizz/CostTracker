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
using System.Xml.Linq;

namespace CostTracker
{
    partial class ViewExpenses : Form
    {
        public User Pengguna;
        public ViewExpenses(User pengguna)
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

        private void pbIncome_Click(object sender, EventArgs e)
        {
            ViewIncome viewincome = new ViewIncome(Pengguna);
            viewincome.Show();
            this.Hide();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout(Pengguna);
            logout.Show();
            this.Hide();
        }

        private void ViewExpenses_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoadExpense_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvExpense.DataSource = null;
                sql = "select * from tb_outcome where id_user = '" + Pengguna.ID_user + "'";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvExpense.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvExpense.Rows[e.RowIndex];
            }
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin nenghapus data dengan ID: " + r.Cells["id_outcome"].Value.ToString() + " ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                conn.Open();
                sql = @"select * from st_delete_outcome(:id_outcome)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_outcome", r.Cells["id_outcome"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadExpense.PerformClick();
                    r = null;
                }
            }
        }
    }
}
