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
    public partial class Home : System.Windows.Forms.Form
    {
        public Home()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users to = new Users();
            to.Show();
            to.MdiParent = this;
            //MyContainer.Controls.Add(to);
            
            
        }

        private void officialRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficialRates to = new OfficialRates();
            to.Show();

        }

        private void exchageRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExchangeRates to = new ExchangeRates();
            to.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operations to = new Operations();
            to.Show();
        }

        private void cLSCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLSCurrency to = new CLSCurrency();
            to.Show();

        }

        private void cLSCurrencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CLSOperationType to = new CLSOperationType();
            to.Show();
        }
    }
}
