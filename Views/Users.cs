using ExchangeOffice.BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class Users : System.Windows.Forms.Form
    {
        private static readonly string baseURL = "https://localhost:44355/";
        Entity myExchangeDb = new Entity();
        UsersBLL users = new UsersBLL();
        UsersBLL u = new UsersBLL();
        public Users()
        {
            InitializeComponent();
        }

        private int temp;
        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == string.Empty)
            {
                MessageBox.Show("Please select user");
            }
            else if (SurnameTB.Text == string.Empty)
            {
                MessageBox.Show("Please select user");
            }
            //Debug.Write(NameTB.Text);
            //Debug.Write(SurnameTB.Text);
            //Debug.Write(temp);
            //string result = users.update(temp, NameTB.Text, SurnameTB.Text, IsActiveCB.Checked);
            //MessageBox.Show(result);
            //dataGridView1.DataSource = users.ShowData();
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
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.PutAsJsonAsync(baseURL + "Users/" + temp ,user);
                HttpResponseMessage result = await client.GetAsync(baseURL + "Users");

                var data = await result.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<User>>(data);
                dataGridView1.DataSource = list;

            }

        }

        private async void InsertButton_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(NameTB.Text, "[a-zA-Z ]").Success || !Regex.Match(SurnameTB.Text, "[a-zA-Z ]").Success || IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTB.Text = "";
                SurnameTB.Text = "";
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
                //MessageBox.Show(users.insert(NameTB.Text, SurnameTB.Text, IsActiveCB.Checked));
                //dataGridView1.DataSource = users.ShowData();
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage res = await client.PostAsJsonAsync(baseURL + "Users",user);
                    HttpResponseMessage result = await client.GetAsync(baseURL + "Users");

                    var data = await result.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<User>>(data);
                    dataGridView1.DataSource = list;

                }
            }

        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(users.delete(temp));
            //IsActiveCB.Checked = false;
            //dataGridView1.DataSource = users.ShowData();
            User user = myExchangeDb.Users.Where(u => u.UsersId == temp).FirstOrDefault();
            user.IsActive = 0;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.PutAsJsonAsync(baseURL + "Users/" + temp, user);
                HttpResponseMessage result = await client.GetAsync(baseURL + "Users");

                var data = await result.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<User>>(data);
                dataGridView1.DataSource = list;

            }

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

        private async void ShowData_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.GetAsync(baseURL + "Users");

                var data = await res.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<User>>(data);
                dataGridView1.DataSource = list;

            }
            //dataGridView1.DataSource = u.GetAllUsers();
        }
    }

}

