﻿using System;
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
    public partial class ExchangeRates : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        public ExchangeRates()
        {
            InitializeComponent();
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            foreach (var curr in allCurrencies)
            {
                CurrencyFromCB.Items.Add(curr.CurrencyId);
                CurrencyToCB.Items.Add(curr.CurrencyId);


            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ExchangeRate er = new ExchangeRate();
            er.ValidityDate = ValidDatePicker.Value;
            //er.CurrencyFrom = System.Convert.ToString(CurrencyFromCB.SelectedItem);
            //er.CurrencyTo = CurrencyToCB.SelectedItem;
            er.CurrencyFrom = 3;
            er.CurrencyTo = 2;
            er.Rate = System.Convert.ToDouble(rateCB.Text);
            er.IsActive = IsActiveCB.Checked ? 1 : 0;
            myExchangeDb.ExchangeRates.Add(er);
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
            var allER = myExchangeDb.ExchangeRates.ToList<ExchangeRate>();
            dataGridView1.DataSource = allER;
        }
    }
}
