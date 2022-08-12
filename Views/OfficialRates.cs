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
using ExchangeOffice.BLL;

namespace ExchangeOffice
{
    public partial class OfficialRates : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        int temp;
        int temp2, temp3;
        string temp4;
        OfficialRatesBLL of = new OfficialRatesBLL();
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
                MessageBox.Show("Selected date Must be greater then Today's date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //DateTime dt = DateTime.ParseExact(ValidDateControl.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //if (ValidDateControl.Value != "" && dt > DateTime.Today)
            //{
            //    MessageBox.Show("From Date should be earlier or equal To Today Date", MessageHelper.MessageType.Warning);
            //}
            else if (!Regex.Match(RateTB.Text, @"^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RateTB.Text = "";
            }
            else if (IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(of.insert(ValidDateControl.Value, ((CLS_Currency)CurrencyCB.SelectedItem).CurrencyId, System.Convert.ToDouble(RateTB.Text), IsActiveCB.Checked));
                dataGridView1.DataSource = of.ShowData();
            }



        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(of.update(temp, ValidDateControl.Value, ((CLS_Currency)CurrencyCB.SelectedItem).CurrencyId, System.Convert.ToDouble(RateTB.Text), IsActiveCB.Checked));
            dataGridView1.DataSource = of.ShowData();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            IsActiveCB.Checked = false;
            MessageBox.Show(of.delete(temp));
            dataGridView1.DataSource = of.ShowData();

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            OfficialRatesBLL or = new OfficialRatesBLL();
            dataGridView1.DataSource = or.ShowData();
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
