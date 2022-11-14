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
        string connstring = "Host=Localhost;Port=5432;Username=postgres;Password=junpro7;Database=CostTracker";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void btSignup_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Sign Up Berhasil!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    //btnLoaddata.PerformClick();
                    tbNama.Text = tbEmail.Text = tbPassword.Text = null;
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Sign Up FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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