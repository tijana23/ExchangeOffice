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
    public partial class Operations : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        public Operations()
        {
            InitializeComponent();
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            var allUsers = myExchangeDb.Users.ToList<User>();
            var allOperationTypes = myExchangeDb.CLS_OperationType.ToList<CLS_OperationType>();
            foreach (var curr in allCurrencies)
            {
                CurrencyFromCB.Items.Add(curr.CurrencyId);
                CurrencyToCB.Items.Add(curr.CurrencyId);
            }
            foreach (var user in allUsers)
            {
                CurrencyFromCB.Items.Add(user.UsersId);
                CurrencyToCB.Items.Add(user.UsersId);
            }
            foreach (var op in allOperationTypes)
            {
                OperationTypeIdCB.Items.Add(op.OperationTypeId);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {

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
