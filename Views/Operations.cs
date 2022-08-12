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
    public partial class Operations : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        int temp;
        OperationsBLL op = new OperationsBLL();
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
            else if (!Regex.Match(AmountTB.Text, @"^[1-9]+[0-9]*$").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmountTB.Text = "";
            }
            else if (OperationTypeIdCB.Text == string.Empty || UserIdCB.Text == string.Empty || CurrencyFromCB.Text == string.Empty || CurrencyToCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(op.insert(((CLS_OperationType)OperationTypeIdCB.SelectedItem).OperationTypeId, ((User)UserIdCB.SelectedItem).UsersId, OperationDatePicker.Value, int.Parse(AmountTB.Text), ((CLS_Currency)CurrencyFromCB.SelectedItem).CurrencyId, ((CLS_Currency)CurrencyToCB.SelectedItem).CurrencyId));
                dataGridView1.DataSource = op.ShowData();
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(op.update(temp, ((CLS_OperationType)OperationTypeIdCB.SelectedItem).OperationTypeId, ((User)UserIdCB.SelectedItem).UsersId, OperationDatePicker.Value, int.Parse(AmountTB.Text), ((CLS_Currency)CurrencyFromCB.SelectedItem).CurrencyId, ((CLS_Currency)CurrencyToCB.SelectedItem).CurrencyId));
            dataGridView1.DataSource = op.ShowData();

        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            OperationsBLL op = new OperationsBLL();
            dataGridView1.DataSource = op.ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int to, from, op, user;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            temp = int.Parse(selectedRow.Cells[0].Value.ToString());
            op = int.Parse(selectedRow.Cells[1].Value.ToString());
            CLS_OperationType oper = myExchangeDb.CLS_OperationType.Where(o => o.OperationTypeId == op).FirstOrDefault();
            //UserIdCB.Text = selectedRow.Cells[2].Value.ToString();
            OperationDatePicker.Value = (DateTime)selectedRow.Cells[3].Value;
            AmountTB.Text = selectedRow.Cells[4].Value.ToString();
            to = int.Parse(selectedRow.Cells[6].Value.ToString());
            from = int.Parse(selectedRow.Cells[5].Value.ToString());
            OperationTypeIdCB.Text = oper.Name;
            //var optype = myExchangeDb.CLS_OperationType.ToList<CLS_OperationType>();
            //foreach (var opp in optype)
            //{
            //    if (opp.OperationTypeId == op)
            //    {
            //        OperationTypeIdCB.Text = opp.Name;
            //    }

            //}
            var users = myExchangeDb.Users.ToList<User>();
            foreach (var u in users)
            {
                if (u.UsersId == int.Parse(selectedRow.Cells[2].Value.ToString()))
                {
                    UserIdCB.Text = u.FullName;
                }

            }
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
        }
    }
}
