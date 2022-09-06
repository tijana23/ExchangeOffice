using ExchangeOffice.BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class CLSCurrency : System.Windows.Forms.Form
    {
        private static readonly string baseURL = "https://localhost:44355/api/";
        Entity myExchangeDb = new Entity();
        int temp;
        CLS_CurrencyBLL curr = new CLS_CurrencyBLL();
        public CLSCurrency()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(CodeTB.Text, @"^([0-9]+)?$").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CodeTB.Text = "";
            }
            else if (!Regex.Match(NameTB.Text, "[a-zA-Z ]").Success)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTB.Text = "";

            }
            else if (IsActiveCB.Text == string.Empty)
            {
                MessageBox.Show("Invalid format.Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(curr.insert(CodeTB.Text, NameTB.Text, IsActiveCB.Checked));
                dataGridView1.DataSource = curr.ShowData();
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(curr.update(temp, CodeTB.Text, NameTB.Text, IsActiveCB.Checked));
            dataGridView1.DataSource = curr.ShowData();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(curr.delete(temp));
            IsActiveCB.Checked = false;
            dataGridView1.DataSource = curr.ShowData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            temp = int.Parse(selectedRow.Cells[0].Value.ToString());
            CodeTB.Text = selectedRow.Cells[1].Value.ToString();
            NameTB.Text = selectedRow.Cells[2].Value.ToString();
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
            //CLS_CurrencyBLL curr = new CLS_CurrencyBLL();
            //dataGridView1.DataSource = curr.ShowData();
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.GetAsync(baseURL + "ClsCurrencies");

                var data = await res.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<CLS_Currency>>(data);
                dataGridView1.DataSource = list;

            }

        }

        private void CLSCurrency_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exchangeOfficeDataSet1.CLS_Currency' table. You can move, or remove it, as needed.
            this.cLS_CurrencyTableAdapter.Fill(this.exchangeOfficeDataSet1.CLS_Currency);

        }
    }
}
