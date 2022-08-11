using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class CLSCurrency : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        int temp;
        public CLSCurrency()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(CodeTB.Text, @"^([0-9]+)?$").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CodeTB.Text = "";
            }
            else if (!Regex.Match(NameTB.Text, @"/^[a-zA-Z\s]{0,255}$/").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTB.Text = "";

            }else if(IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CLS_Currency c = new CLS_Currency();
                c.Code = CodeTB.Text;
                c.Name = NameTB.Text;
                c.IsActive = IsActiveCB.Checked ? 1 : 0;
                myExchangeDb.CLS_Currency.Add(c);
                myExchangeDb.SaveChanges();
                MessageBox.Show("Your data has been saved in the Database");
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            CLS_Currency c = myExchangeDb.CLS_Currency.Where(o => o.CurrencyId == temp).FirstOrDefault();
            c.Code = CodeTB.Text;
            c.Name = NameTB.Text;
            c.IsActive = IsActiveCB.Checked ? 1 : 0;
            myExchangeDb.SaveChanges();
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            dataGridView1.DataSource = allCurrencies;

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            temp = int.Parse(selectedRow.Cells[0].Value.ToString());
            CodeTB.Text = selectedRow.Cells[1].Value.ToString();
            NameTB.Text = selectedRow.Cells[2].Value.ToString();
            if (selectedRow.Cells[3].Value.ToString() == "1")
            {
                IsActiveCB.Checked = true;
            }
            else
            {
                IsActiveCB.Checked = false;
            }

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            dataGridView1.DataSource = allCurrencies;

        }
    }
}
