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
    partial class Logout : Form
    {
        public User Pengguna;
        public Logout(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.Name;
        }

        private void btnLogoutNo_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Pengguna);
            dashboard.Show();
            this.Hide();
        }

        private void btnLogoutYes_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
