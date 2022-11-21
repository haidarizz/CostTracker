using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CostTracker
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=CostTracker";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void btSignup_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != string.Empty && tbEmail.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from ct_insert_users(:_name,:_email,:_password)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_name", tbNama.Text);
                    cmd.Parameters.AddWithValue("_email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("_password", tbPassword.Text);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Successfully signed up", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        tbNama.Text = tbEmail.Text = tbPassword.Text = null;
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Sign in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill the blank");
            }
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}