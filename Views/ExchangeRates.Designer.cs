namespace ExchangeOffice
{
    partial class ExchangeRates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsActiveCB = new System.Windows.Forms.CheckBox();
            this.ValidDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rateCB = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowData = new System.Windows.Forms.Button();
            this.CurrencyToCB = new System.Windows.Forms.ComboBox();
            this.CurrencyFromCB = new System.Windows.Forms.ComboBox();
            this.exchangeOfficeDataSet3 = new ExchangeOffice.ExchangeOfficeDataSet3();
            this.exchangeRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exchangeRatesTableAdapter = new ExchangeOffice.ExchangeOfficeDataSet3TableAdapters.ExchangeRatesTableAdapter();
            this.exchangeRatesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validityDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeOfficeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validity date :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency to:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency from :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate :";
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Location = new System.Drawing.Point(269, 138);
            this.IsActiveCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(66, 20);
            this.IsActiveCB.TabIndex = 4;
            this.IsActiveCB.Text = "Active";
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // ValidDatePicker
            // 
            this.ValidDatePicker.Location = new System.Drawing.Point(269, 2);
            this.ValidDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidDatePicker.Name = "ValidDatePicker";
            this.ValidDatePicker.Size = new System.Drawing.Size(255, 22);
            this.ValidDatePicker.TabIndex = 5;
            // 
            // rateCB
            // 
            this.rateCB.Location = new System.Drawing.Point(269, 104);
            this.rateCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rateCB.Name = "rateCB";
            this.rateCB.Size = new System.Drawing.Size(89, 22);
            this.rateCB.TabIndex = 8;
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Location = new System.Drawing.Point(196, 172);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(67, 30);
            this.Insert.TabIndex = 9;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Update.Location = new System.Drawing.Point(269, 172);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(67, 30);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Location = new System.Drawing.Point(196, 206);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 30);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exchangeRatesIdDataGridViewTextBoxColumn,
            this.validityDateDataGridViewTextBoxColumn,
            this.currencyFromDataGridViewTextBoxColumn,
            this.currencyToDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.exchangeRatesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 341);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ValidDatePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Update, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Insert, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IsActiveCB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rateCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ShowData, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.CurrencyToCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CurrencyFromCB, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 522);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // ShowData
            // 
            this.ShowData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowData.Location = new System.Drawing.Point(269, 206);
            this.ShowData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(135, 30);
            this.ShowData.TabIndex = 12;
            this.ShowData.Text = "Show Data";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // CurrencyToCB
            // 
            this.CurrencyToCB.FormattingEnabled = true;
            this.CurrencyToCB.Location = new System.Drawing.Point(269, 36);
            this.CurrencyToCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyToCB.Name = "CurrencyToCB";
            this.CurrencyToCB.Size = new System.Drawing.Size(108, 24);
            this.CurrencyToCB.TabIndex = 13;
            // 
            // CurrencyFromCB
            // 
            this.CurrencyFromCB.FormattingEnabled = true;
            this.CurrencyFromCB.Location = new System.Drawing.Point(269, 70);
            this.CurrencyFromCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyFromCB.Name = "CurrencyFromCB";
            this.CurrencyFromCB.Size = new System.Drawing.Size(108, 24);
            this.CurrencyFromCB.TabIndex = 14;
            // 
            // exchangeOfficeDataSet3
            // 
            this.exchangeOfficeDataSet3.DataSetName = "ExchangeOfficeDataSet3";
            this.exchangeOfficeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exchangeRatesBindingSource
            // 
            this.exchangeRatesBindingSource.DataMember = "ExchangeRates";
            this.exchangeRatesBindingSource.DataSource = this.exchangeOfficeDataSet3;
            // 
            // exchangeRatesTableAdapter
            // 
            this.exchangeRatesTableAdapter.ClearBeforeFill = true;
            // 
            // exchangeRatesIdDataGridViewTextBoxColumn
            // 
            this.exchangeRatesIdDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRatesId";
            this.exchangeRatesIdDataGridViewTextBoxColumn.HeaderText = "ExchangeRatesId";
            this.exchangeRatesIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exchangeRatesIdDataGridViewTextBoxColumn.Name = "exchangeRatesIdDataGridViewTextBoxColumn";
            this.exchangeRatesIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangeRatesIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // validityDateDataGridViewTextBoxColumn
            // 
            this.validityDateDataGridViewTextBoxColumn.DataPropertyName = "ValidityDate";
            this.validityDateDataGridViewTextBoxColumn.HeaderText = "ValidityDate";
            this.validityDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.validityDateDataGridViewTextBoxColumn.Name = "validityDateDataGridViewTextBoxColumn";
            this.validityDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyFromDataGridViewTextBoxColumn
            // 
            this.currencyFromDataGridViewTextBoxColumn.DataPropertyName = "CurrencyFrom";
            this.currencyFromDataGridViewTextBoxColumn.HeaderText = "CurrencyFrom";
            this.currencyFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyFromDataGridViewTextBoxColumn.Name = "currencyFromDataGridViewTextBoxColumn";
            this.currencyFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyToDataGridViewTextBoxColumn
            // 
            this.currencyToDataGridViewTextBoxColumn.DataPropertyName = "CurrencyTo";
            this.currencyToDataGridViewTextBoxColumn.HeaderText = "CurrencyTo";
            this.currencyToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyToDataGridViewTextBoxColumn.Name = "currencyToDataGridViewTextBoxColumn";
            this.currencyToDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // ExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExchangeRates";
            this.Text = "Exchange Rates";
            this.Load += new System.EventHandler(this.ExchangeRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeOfficeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IsActiveCB;
        private System.Windows.Forms.DateTimePicker ValidDatePicker;
        private System.Windows.Forms.TextBox rateCB;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.ComboBox CurrencyToCB;
        private System.Windows.Forms.ComboBox CurrencyFromCB;
        private ExchangeOfficeDataSet3 exchangeOfficeDataSet3;
        private System.Windows.Forms.BindingSource exchangeRatesBindingSource;
        private ExchangeOfficeDataSet3TableAdapters.ExchangeRatesTableAdapter exchangeRatesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRatesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
    }
}