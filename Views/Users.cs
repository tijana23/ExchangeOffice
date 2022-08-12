using ExchangeOffice.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class Users : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        UsersBLL users = new UsersBLL();
        public Users()
        {
            InitializeComponent();
        }

        private int temp;
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == string.Empty)
            {
                MessageBox.Show("Please select user");
            }
            else if (SurnameTB.Text == string.Empty)
            {
                MessageBox.Show("Please select user");
            }
            else if (IsActiveCB.Checked)
            {
                MessageBox.Show("Please select user");
            }
            MessageBox.Show(users.update(temp, NameTB.Text, SurnameTB.Text, IsActiveCB.Checked));
            dataGridView1.DataSource = users.ShowData();

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(NameTB.Text, "[a-zA-Z ]").Success || !Regex.Match(SurnameTB.Text, "[a-zA-Z ]").Success || IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTB.Text = "";
                SurnameTB.Text = "";
            }
            else
            {

                users.insert(NameTB.Text, SurnameTB.Text, IsActiveCB.Checked);
                MessageBox.Show(users.insert(NameTB.Text, SurnameTB.Text, IsActiveCB.Checked));
                dataGridView1.DataSource = users.ShowData();
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(users.delete(temp));
            IsActiveCB.Checked = false;
            dataGridView1.DataSource = users.ShowData();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            temp = int.Parse(selectedRow.Cells[0].Value.ToString());
            NameTB.Text = selectedRow.Cells[1].Value.ToString();
            SurnameTB.Text = selectedRow.Cells[2].Value.ToString();
            if (selectedRow.Cells[3].Value.ToString() == "1")
            {
                IsActiveCB.Checked = true;
            }
            else
            {
                IsActiveCB.Checked = false;
            }
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users.ShowData();

        }



    }

}

