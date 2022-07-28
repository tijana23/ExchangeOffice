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
    public partial class OfficialRates : System.Windows.Forms.Form
    {
        public OfficialRates()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var newOR = new OfficialRate();
            newOR.ValidityDate = ValidDateControl.Value;
            //newOR.Currency = curencyControl.selectitem.ID
            newOR.Currency = 5;
            newOR.Rate = System.Convert.ToDouble(textBox2.Text);
            newOR.IsActive = checkBox1.Checked ? 1 : 0;

            var myDatabes = new Entity();
            myDatabes.OfficialRates.Add(newOR);
            myDatabes.SaveChanges();


        }

        private void Update_Click(object sender, EventArgs e)
        {


        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
