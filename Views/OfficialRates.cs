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


        }

        private void Update_Click(object sender, EventArgs e)
        {


        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            Entity myExchangeDb = new Entity();
            var allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
            dataGridView1.DataSource = allOR;
        }
    }
}
