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
            bool IsOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Users")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if(IsOpen == false)
            {
                Users to = new Users();
                to.MdiParent = this;
                to.Show();

            }
            
            //MyContainer.Controls.Add(to);
            
            
        }

        private void officialRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Official Rates")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if(IsOpen == false)
            {
                OfficialRates to = new OfficialRates();
                to.Show();
                to.MdiParent = this;

            }

        }

        private void exchangeRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Exchange Rates")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                ExchangeRates to = new ExchangeRates();
                to.Show();
                to.MdiParent = this;

            }

        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Operations")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }  
            if(IsOpen == false)
            {
                Operations to = new Operations();
                to.Show();
                to.MdiParent = this;

            }
            
        }

        private void cLSCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "CLS_Currency")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                CLSCurrency to = new CLSCurrency();
                to.Show();
                to.MdiParent = this;

            }

        }


        private void cLSCurrencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;


            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "CLS_OperationType")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                CLSOperationType to = new CLSOperationType();
                to.Show();
                to.MdiParent = this;
               
            }

        }
    }
}
