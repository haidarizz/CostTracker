﻿using System;
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
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void btnSaveExpenses_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
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
    }
}