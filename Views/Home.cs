using ExchangeOffice.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class Home : System.Windows.Forms.Form
    {
        private static readonly string baseURL = "https://localhost:44355/";
        public Home()
        {
            InitializeComponent();
            IsMdiContainer = true;
            exchangeOfficeToolStripMenuItem.Visible = false;
            tableLayoutPanel1.Visible = true;
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

        private void tDACalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;


            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "TDACalculation")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                TDACalculation to = new TDACalculation();
                to.Show();
                to.MdiParent = this;

            }

        }

        private void loanCalculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;


            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LoanCalculations")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                LoanCalculations to = new LoanCalculations();
                to.Show();
                to.MdiParent = this;

            }

        }

        

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(username.Text, "[a-zA-Z ]").Success || !Regex.Match(password.Text, "[a-zA-Z ]").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Text = "";
                password.Text = "";
            }
            else
            {
                Account user = new Account();
                user.UserName = username.Text;
                user.Password = password.Text;
                //MessageBox.Show(users.insert(NameTB.Text, SurnameTB.Text, IsActiveCB.Checked));
                //dataGridView1.DataSource = users.ShowData();
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage res = await client.PostAsJsonAsync(baseURL + "api/Token/Authenticate", user);
                    var response = await res.Content.ReadAsStringAsync();
                    Debug.Write(response);
                    var statusCode = res.StatusCode;
                    if (statusCode == HttpStatusCode.OK)
                    {
                        Token.setToken(response);
                        exchangeOfficeToolStripMenuItem.Visible = true;
                        tableLayoutPanel1.Visible = false;


                    }
                    else
                    {
                        MessageBox.Show("User Unauthorized.Please Try Again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
