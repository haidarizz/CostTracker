using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostTracker
{
    partial class AddIncome : Form
    {
        public User Pengguna;
        public AddIncome(User pengguna)
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

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from ct_insert_income(:_id_user,:_in_amount,:_in_account,:_in_category,:_in_date,:_in_note)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_user", Pengguna.ID_user);
                cmd.Parameters.AddWithValue("_in_amount", Convert.ToInt32(tbAmount.Text));
                cmd.Parameters.AddWithValue("_in_account", lbAccount.Text);
                cmd.Parameters.AddWithValue("_in_category", lbCategory.Text);
                cmd.Parameters.AddWithValue("_in_date", dtpDate.Value);
                cmd.Parameters.AddWithValue("_in_note", tbNote.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Add Income Berhasil!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Dashboard dashboard = new Dashboard(Pengguna);
                    dashboard.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Add Income FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbIncome_Click(object sender, EventArgs e)
        {
            ViewIncome viewincome = new ViewIncome(Pengguna);
            viewincome.Show();
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

        private void AddIncome_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
