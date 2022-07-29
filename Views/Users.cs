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

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = NameTB.Text;
            user.Surname = SurnameTB.Text;
            if (IsActiveCB.Checked = true)
            {
                user.IsActive = 1;
            }
            else
            {
                user.IsActive = 0;
            }
            myExchangeDb.Users.Add(user);
            myExchangeDb.SaveChanges();
            
            MessageBox.Show("Your data has been saved in the Database");
             


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
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
    }
}
