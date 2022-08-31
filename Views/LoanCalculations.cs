using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice.Views
{
    public partial class LoanCalculations : Form
    {
        public LoanCalculations()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            using (var context = new ExchangeOfficeEntities())
            {
                int day = dateTimePicker.Value.Day;
                string month = dateTimePicker.Value.ToString("MMM");
                int year = dateTimePicker.Value.Year;

                var loan_results = context.LoanP(Convert.ToDouble(AmountTB.Text), Convert.ToDouble(InterestRateTB.Text), Convert.ToInt16(PeriodTB.Text), day, month, year);

                //foreach (TDA_Result tda in tda_results)
                //    Console.WriteLine(tda.MonthDate);
                dataGridView1.DataSource = loan_results;

            }
        }
    }
}
