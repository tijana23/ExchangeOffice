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
    public partial class CLSCurrency : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        public CLSCurrency()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            var allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            dataGridView1.DataSource = allCurrencies;

        }
    }
}
