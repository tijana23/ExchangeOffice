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
    public partial class Operations : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        public Operations()
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
            var allUsers = myExchangeDb.Users.ToList<User>();
            foreach (var user in allUsers)
            {
                UserIdCB.Items.Add(user);
            }
            UserIdCB.DisplayMember = "Fullname";
            UserIdCB.ValueMember = "UsersId";

            var allOperationTypes = myExchangeDb.CLS_OperationType.ToList<CLS_OperationType>();
            foreach (var op in allOperationTypes)
            {
                OperationTypeIdCB.Items.Add(op);
            }
            OperationTypeIdCB.DisplayMember = "Name";
            OperationTypeIdCB.ValueMember = "OperationTypeId";
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(OperationDatePicker.Value);
            DateTime todayDate = Convert.ToDateTime(DateTime.Now);

            if (selectedDate <= todayDate)
            {
                MessageBox.Show("Please enter valid date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.Match(AmountTB.Text, @"/^\d*\.?\d*$/").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmountTB.Text = "";
            }

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
