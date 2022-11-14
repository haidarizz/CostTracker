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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            bool blnfound = false;
            NpgsqlConnection conn = new NpgsqlConnection("Host=Localhost;Port=5432;Username=postgres;Password=junpro7;Database=CostTracker");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from tb_users where email = '" + tbEmail.Text + "' and password = '" + tbPassword.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                blnfound = true;
                MessageBox.Show("Login Berhasil !!");
                conn.Close();
                conn.Open();
                string id_user = "CTDEFAULT";
                NpgsqlCommand cmd_id = new NpgsqlCommand("Select id_user from tb_users where email = '" + tbEmail.Text + "' and password = '" + tbPassword.Text + "'", conn);
                NpgsqlDataReader id_reader = cmd_id.ExecuteReader();
                //string id_user = id_reader.GetString(0);
                while(id_reader.Read())
                {
                    id_user = id_reader.GetString(0);
                }
                conn.Close();
                conn.Open();
                string name = "NMDEFAULT";
                NpgsqlCommand cmd_name = new NpgsqlCommand("Select name from tb_users where email = '" + tbEmail.Text + "' and password = '" + tbPassword.Text + "'", conn);
                NpgsqlDataReader name_reader = cmd_name.ExecuteReader();
                //string id_user = id_reader.GetString(0);
                while (name_reader.Read())
                {
                    name = name_reader.GetString(0);
                }
                conn.Close();
                User pengguna = new User(id_user, name, tbEmail.Text);
                Dashboard dashboard = new Dashboard(pengguna);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal !!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}
