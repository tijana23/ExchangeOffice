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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A2PCMDA;Initial Catalog=ExchangeOffice;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Users()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            con.Open();
            int temp;
            if(ActiveBoxCB.Checked = true)
            {
                temp = 1;
            }
            else
            {
                temp = 0;
            }
            cmd = new SqlCommand("EXEC InsertIntoUsers @Name = '" + NameTB.Text + "',@Surname = '" + SurnameTB.Text + "' , @IsActive = " + temp ,con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Select * From Users", con);
            var reader = cmd.ExecuteReader(); 
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Your data has been saved in the Database");
            con.Close(); 


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
