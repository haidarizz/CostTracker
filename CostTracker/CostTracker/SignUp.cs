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

namespace CostTracker
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.signUp(tbNama.Text, tbEmail.Text, tbPassword.Text);
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal membuat akun!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}