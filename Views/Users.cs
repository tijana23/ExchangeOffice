using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class Users : System.Windows.Forms.Form
    {
        Entity myExchangeDb = new Entity();
        public Users()
        {
            InitializeComponent();
        }

        private int temp;
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == temp).FirstOrDefault();
            user.Name = NameTB.Text;
            user.Surname = SurnameTB.Text;
            if (IsActiveCB.Checked == true)
            {
                user.IsActive = 1;

            }
            else
            {
                user.IsActive = 0;
            }
            myExchangeDb.SaveChanges();
            var allUsers = myExchangeDb.Users.ToList<User>();
            dataGridView1.DataSource = allUsers;

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information");
            }
            else if (SurnameTB.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information");
            }
            else if (IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information");
            }
            else
            {
                User user = new User();
                user.Name = NameTB.Text;
                user.Surname = SurnameTB.Text;
                if (IsActiveCB.Checked == true)
                {
                    user.IsActive = 1;
                }
                else
                {
                    user.IsActive = 0;
                }

                myExchangeDb.Users.Add(user);
                myExchangeDb.SaveChanges();

                MessageBox.Show("Your information has been saved");
                var allUsers = myExchangeDb.Users.ToList<User>();
                dataGridView1.DataSource = allUsers;
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == temp).FirstOrDefault();
            IsActiveCB.Checked = false;
            user.IsActive = 0;

            var allUsers = myExchangeDb.Users.ToList<User>();
            dataGridView1.DataSource = allUsers;

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
            Entity myExchangeDb = new Entity();
            var allUsers = myExchangeDb.Users.ToList<User>();
            dataGridView1.DataSource= allUsers;


            //con.Open();
            //cmd = new SqlCommand("Select * From Users", con);
            //var reader = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(reader);
            //dataGridView1.DataSource = dt;
            //con.Close();


        }

        private void NameTB_Validating(object sender, CancelEventArgs e)
        {
            if(NameTB.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information");
            }
        }

        private void SurnameTB_Validating(object sender, CancelEventArgs e)
        {
            if (SurnameTB.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information");
            }
        }

        private void IsActiveCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IsActiveCB_Validating(object sender, CancelEventArgs e)
        {
            if (IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information");
            }

        }
    }
}
