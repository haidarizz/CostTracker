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
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=CostTracker";
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
                if (rbThisMonth.Checked)
                {
                    conn.Open();
                    dgvIncome.DataSource = null;
                    sql = "select * from tb_income where id_user = '" + Pengguna.ID_user + "' and EXTRACT(MONTH FROM out_date) = EXTRACT(MONTH FROM CURRENT_TIMESTAMP)";
                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    NpgsqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    dgvIncome.DataSource = dt;
                    conn.Close();
                }
                else if (rbAll.Checked)
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
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select the data row to be updated", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Is it true that you want to delete data with ID: " + r.Cells["id_income"].Value.ToString() + " ?", "Delete confirmed data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                conn.Open();
                sql = @"select * from st_delete_income(:id_income)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_income", r.Cells["id_income"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Selected data has been deleted successfully", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoadIncome.PerformClick();
                    r = null;
                }
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddIncome addincome = new AddIncome(Pengguna);
            addincome.Show();
            this.Hide();
        }
    }
}
