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
    partial class Dashboard : Form
    {
        public User Pengguna;
        public Dashboard(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.Name;
            lblUser.Text = "Hi, " + name + "!";
        }
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=CostTracker";

        private void pbHome_Click(object sender, EventArgs e)
        {

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

        private void btIncome_Click(object sender, EventArgs e)
        {
            AddIncome addincome = new AddIncome(Pengguna);
            addincome.Show();
            this.Hide();
        }

        private void btExpenses_Click(object sender, EventArgs e)
        {
            AddExpenses addexpenses = new AddExpenses(Pengguna);
            addexpenses.Show();
            this.Hide();
        }

        private void boxBalance_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            int income = 0;
            NpgsqlCommand cmd_income = new NpgsqlCommand("Select sum (in_amount) as total from tb_income where id_user = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader in_reader = cmd_income.ExecuteReader();
            while (in_reader.Read())
            {
                try
                {
                    income = in_reader.GetInt32(0);
                }
                catch
                {
                    income = 0;
                }
            }
            lblIncome.Text = income.ToString();
            conn.Close();
            conn.Open();
            int outcome = 0;
            NpgsqlCommand cmd_outcome = new NpgsqlCommand("Select sum (out_amount) as total from tb_outcome where id_user = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader out_reader = cmd_outcome.ExecuteReader();
            while (out_reader.Read())
            {
                try
                {
                    outcome = out_reader.GetInt32(0);
                }
                catch
                {
                    outcome = 0;
                }
            }
            lblOutcome.Text = outcome.ToString();
            conn.Close();

            int balance = income - outcome;
            lblBalance.Text = balance.ToString();
        }
    }
}
