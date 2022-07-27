using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 to = new Form2();
            to.Show();
        }

        private void officialRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 to = new Form3();
            to.Show();

        }

        private void exchageRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 to = new Form4();
            to.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 to = new Form5();
            to.Show();
        }

        private void cLSCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 to = new Form6();
            to.Show();

        }

        private void cLSCurrencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 to = new Form7();
            to.Show();
        }
    }
}
