using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ExchangeOffice
{
    public partial class OfficialRates : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        int temp;
        int temp2,temp3;
        string temp4;
        public OfficialRates()
        {
            InitializeComponent();
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            foreach (var curr in allCurrencies)
            {
                CurrencyCB.Items.Add(curr);
            }
            CurrencyCB.DisplayMember = "Name";
            CurrencyCB.ValueMember = "CurrencyId";

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(ValidDateControl.Value);
            DateTime todayDate = Convert.ToDateTime(DateTime.Now);

            if (selectedDate < todayDate)
            {
                MessageBox.Show("Selected date Must be greater then Today's date" ,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //DateTime dt = DateTime.ParseExact(ValidDateControl.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //if (ValidDateControl.Value != "" && dt > DateTime.Today)
            //{
            //    MessageBox.Show("From Date should be earlier or equal To Today Date", MessageHelper.MessageType.Warning);
            //}
            else if (!Regex.Match(RateTB.Text, @"/^\d*\.?\d*$/").Success || IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RateTB.Text = "";
            }
            else
            {
                OfficialRate or = new OfficialRate();
                or.ValidityDate = ValidDateControl.Value;
                string cbtext = CurrencyCB.SelectedValue.ToString();

                var c = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
                foreach (var curr in c)
                {
                    if (curr.Name == cbtext)
                    {
                        temp2 = curr.CurrencyId;
                    }
                }
                or.Currency = temp2;
                or.Rate = System.Convert.ToDouble(RateTB.Text);
                or.IsActive = IsActiveCB.Checked ? 1 : 0;
                myExchangeDb.OfficialRates.Add(or);
                myExchangeDb.SaveChanges();
                MessageBox.Show("Your data has been saved in the Database");
                var allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
                dataGridView1.DataSource = allOR;
            }



        }

        private void Update_Click(object sender, EventArgs e)
        {
            OfficialRate or = myExchangeDb.OfficialRates.Where(o => o.OfficialRatesId == temp).FirstOrDefault();
            or.ValidityDate = ValidDateControl.Value;
            or.Currency = int.Parse(CurrencyCB.Text);
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
            temp3 = int.Parse(selectedRow.Cells[2].Value.ToString());
            var c = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            foreach (var curr in c)
            {
                if (curr.CurrencyId == temp3)
                {
                    temp4 = curr.Name;
                }
            }
            CurrencyCB.Text = temp4;
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
