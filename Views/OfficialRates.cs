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
    public partial class OfficialRates : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        int temp;
        public OfficialRates()
        {
            InitializeComponent();
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            foreach(var curr in allCurrencies)
            {
                CurrencyCB.Items.Add(curr.CurrencyId);
            }

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            OfficialRate or = new OfficialRate();
            or.ValidityDate = ValidDateControl.Value;
            //or.Currency = CurrencyCB.SelectedItem;
            or.Currency = 5;
            //newOR.Currency = curencyControl.selectitem.ID
            or.Rate = System.Convert.ToDouble(RateTB.Text);
            or.IsActive = IsActiveCB.Checked ? 1 : 0;
            myExchangeDb.OfficialRates.Add(or);
            myExchangeDb.SaveChanges();
            MessageBox.Show("Your data has been saved in the Database");
            var allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
            dataGridView1.DataSource = allOR;



        }

        private void Update_Click(object sender, EventArgs e)
        {
            OfficialRate or = myExchangeDb.OfficialRates.Where(o => o.OfficialRatesId == temp).FirstOrDefault();
            or.ValidityDate = ValidDateControl.Value;
            //or.Currency = CurrencyCB.Text;
            or.Currency = 3;
            or.Rate = double.Parse(RateTB.Text);
            if (IsActiveCB.Checked == true)
            {
                or.IsActive = 1;

            }
            else
            {
                or.IsActive = 0;
            }
            myExchangeDb.SaveChanges();
            var allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
            dataGridView1.DataSource = allOR;

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            OfficialRate or = myExchangeDb.OfficialRates.Where(o => o.OfficialRatesId == temp).FirstOrDefault();
            IsActiveCB.Checked = false;
            or.IsActive = 0;
            var allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
            dataGridView1.DataSource = allOR;

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            Entity myExchangeDb = new Entity();
            var allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
            dataGridView1.DataSource = allOR;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            temp = int.Parse(selectedRow.Cells[0].Value.ToString());
            ValidDateControl.Value = (DateTime)selectedRow.Cells[1].Value;
            CurrencyCB.Text = selectedRow.Cells[2].Value.ToString();
            RateTB.Text = selectedRow.Cells[3].Value.ToString();
            if (selectedRow.Cells[4].Value.ToString() == "1")
            {
                IsActiveCB.Checked = true;
            }
            else
            {
                IsActiveCB.Checked = false;
            }

        }

    }
}
