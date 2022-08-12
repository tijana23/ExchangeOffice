using ExchangeOffice.BLL;
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
        ExchangeRatesBLL er = new ExchangeRatesBLL();
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
            }
            else if (IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show(er.insert(ValidDatePicker.Value, ((CLS_Currency)CurrencyFromCB.SelectedItem).CurrencyId, ((CLS_Currency)CurrencyToCB.SelectedItem).CurrencyId, System.Convert.ToDouble(rateCB.Text), IsActiveCB.Checked));
                dataGridView1.DataSource = er.ShowData();
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(er.update(temp, ValidDatePicker.Value, ((CLS_Currency)CurrencyFromCB.SelectedItem).CurrencyId, ((CLS_Currency)CurrencyToCB.SelectedItem).CurrencyId, System.Convert.ToDouble(rateCB.Text), IsActiveCB.Checked));
            dataGridView1.DataSource = er.ShowData();


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            IsActiveCB.Checked = false;
            MessageBox.Show(er.delete(temp));
            dataGridView1.DataSource = er.ShowData();

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            ExchangeRatesBLL er = new ExchangeRatesBLL();
            dataGridView1.DataSource = er.ShowData();
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
