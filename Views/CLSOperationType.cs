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
    public partial class CLSOperationType : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        public CLSOperationType()
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

        private void ShowData_Click(object sender, EventArgs e)
        {
            var allop = myExchangeDb.CLS_OperationType.ToList<CLS_OperationType>();
            dataGridView1.DataSource = allop;
        }
    }
}
