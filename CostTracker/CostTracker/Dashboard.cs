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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {

        }

        private void pbIncome_Click(object sender, EventArgs e)
        {
            ViewIncome viewincome = new ViewIncome();
            viewincome.Show();
            this.Hide();
        }

        private void pbExpenses_Click(object sender, EventArgs e)
        {
            ViewExpenses viewexpenses = new ViewExpenses();
            viewexpenses.Show();
            this.Hide();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            logout.Show();
            this.Hide();
        }

        private void btIncome_Click(object sender, EventArgs e)
        {
            AddIncome addincome = new AddIncome();
            addincome.Show();
            this.Hide();
        }

        private void btExpenses_Click(object sender, EventArgs e)
        {
            AddExpenses addexpenses = new AddExpenses();
            addexpenses.Show();
            this.Hide();
        }

        private void boxBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
