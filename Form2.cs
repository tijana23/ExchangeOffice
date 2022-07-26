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
    public partial class Form2 : System.Windows.Forms.Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A2PCMDA;Initial Catalog=ExchangeOffice;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form2()
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
            cmd = new SqlCommand("EXEC InsertIntoUsers('@" + NameTB.Text + "','@" + SurnameTB.Text + "' , '@" + temp + "' )",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been saved in the Database");
            con.Close(); 


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
