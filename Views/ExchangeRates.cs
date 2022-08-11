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
    public partial class ExchangeRates : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        int temp;
        public ExchangeRates()
        {
            InitializeComponent();
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            foreach (var curr in allCurrencies)
            {
                CurrencyFromCB.Items.Add(curr);
                CurrencyToCB.Items.Add(curr);


            }
            CurrencyToCB.DisplayMember = "Name";
            CurrencyToCB.ValueMember = "CurrencyId";
            CurrencyFromCB.DisplayMember = "Name";
            CurrencyFromCB.ValueMember = "CurrencyId";
            //var allMyCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            //CurrencyToCB.DataSource = allMyCurrencies;
            //CurrencyToCB.DisplayMember = "Name";
            //CurrencyToCB.ValueMember = "CurrencyId";
            //CurrencyFromCB.DataSource = allMyCurrencies;
            //CurrencyFromCB.DisplayMember = "Name";
            //CurrencyFromCB.ValueMember = "CurrencyId";
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(ValidDatePicker.Value);
            DateTime todayDate = Convert.ToDateTime(DateTime.Now);

            if (selectedDate < todayDate)
            {
                MessageBox.Show("Selected date Must be greater then Today's date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.Match(rateCB.Text, @"^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rateCB.Text = "";
            }else if(IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ExchangeRate er = new ExchangeRate();
                er.ValidityDate = ValidDatePicker.Value;
                //er.CurrencyFrom = System.Convert.ToString(CurrencyFromCB.SelectedItem);
                //er.CurrencyTo = CurrencyToCB.SelectedItem;
                CLS_Currency cfrom = (CLS_Currency)CurrencyFromCB.SelectedItem;
                CLS_Currency cto = (CLS_Currency)CurrencyToCB.SelectedItem;
                er.CurrencyFrom = cfrom.CurrencyId;
                er.CurrencyTo = cto.CurrencyId;
                er.Rate = System.Convert.ToDouble(rateCB.Text);
                er.IsActive = IsActiveCB.Checked ? 1 : 0;
                myExchangeDb.ExchangeRates.Add(er);
                myExchangeDb.SaveChanges();
                MessageBox.Show("Your data has been saved in the Database");
                var allER = myExchangeDb.ExchangeRates.ToList<ExchangeRate>();
                dataGridView1.DataSource = allER;
            }




        }

        private void Update_Click(object sender, EventArgs e)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == temp).FirstOrDefault();
            er.ValidityDate = ValidDatePicker.Value;
            CLS_Currency cfrom = (CLS_Currency)CurrencyFromCB.SelectedItem;
            CLS_Currency cto = (CLS_Currency)CurrencyToCB.SelectedItem;
            er.CurrencyFrom = cfrom.CurrencyId;
            er.CurrencyTo = cto.CurrencyId;
            er.IsActive = IsActiveCB.Checked ? 1 : 0;
            myExchangeDb.SaveChanges();
            var allER = myExchangeDb.ExchangeRates.ToList<ExchangeRate>();
            dataGridView1.DataSource = allER;


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == temp).FirstOrDefault();
            IsActiveCB.Checked = false;
            er.IsActive = 0;
            var allER = myExchangeDb.ExchangeRates.ToList<ExchangeRate>();
            dataGridView1.DataSource = allER;

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            Entity myExchangeDb = new Entity();
            var allER = myExchangeDb.ExchangeRates.ToList<ExchangeRate>();
            dataGridView1.DataSource = allER;

            //dataGridView1.ColumnCount = 4;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns[0].DataPropertyName = "ExchangeRatesId";
            //dataGridView1.Columns[1].DataPropertyName = "ValidityDate";
            //dataGridView1.Columns[2].DataPropertyName = "CLS_Currency.Name";
            //dataGridView1.Columns[3].DataPropertyName = "Rate";
            //dataGridView1.DataSource = allER;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int to, from;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            temp = int.Parse(selectedRow.Cells[0].Value.ToString());
            ValidDatePicker.Value = (DateTime)selectedRow.Cells[1].Value;
            to = int.Parse(selectedRow.Cells[2].Value.ToString());
            from = int.Parse(selectedRow.Cells[3].Value.ToString());

            var c = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            foreach (var curr in c)
            {
                if (curr.CurrencyId == to)
                {
                    CurrencyToCB.Text = curr.Name;
                }
                if (curr.CurrencyId == from)
                {
                    CurrencyFromCB.Text = curr.Name;
                }

            }
            rateCB.Text = selectedRow.Cells[4].Value.ToString();
            if (selectedRow.Cells[5].Value.ToString() == "1")
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
