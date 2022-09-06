namespace ExchangeOffice
{
    partial class OfficialRates
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
            this.ValidDateControl = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IsActiveCB = new System.Windows.Forms.CheckBox();
            this.RateTB = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrencyCB = new System.Windows.Forms.ComboBox();
            this.ShowData = new System.Windows.Forms.Button();
            this.exchangeOfficeDataSet4 = new ExchangeOffice.ExchangeOfficeDataSet4();
            this.officialRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officialRatesTableAdapter = new ExchangeOffice.ExchangeOfficeDataSet4TableAdapters.OfficialRatesTableAdapter();
            this.officialRatesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validityDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeOfficeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ValidDateControl
            // 
            this.ValidDateControl.Location = new System.Drawing.Point(166, 2);
            this.ValidDateControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValidDateControl.Name = "ValidDateControl";
            this.ValidDateControl.Size = new System.Drawing.Size(262, 22);
            this.ValidDateControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Validity date :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rate :";
            // 
            // IsActiveCB
            // 
            this.IsActiveCB.AutoSize = true;
            this.IsActiveCB.Location = new System.Drawing.Point(166, 98);
            this.IsActiveCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IsActiveCB.Name = "IsActiveCB";
            this.IsActiveCB.Size = new System.Drawing.Size(66, 20);
            this.IsActiveCB.TabIndex = 5;
            this.IsActiveCB.Text = "Active";
            this.IsActiveCB.UseVisualStyleBackColor = true;
            // 
            // RateTB
            // 
            this.RateTB.Location = new System.Drawing.Point(166, 66);
            this.RateTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RateTB.Name = "RateTB";
            this.RateTB.Size = new System.Drawing.Size(89, 22);
            this.RateTB.TabIndex = 7;
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.Location = new System.Drawing.Point(93, 130);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(67, 28);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Location = new System.Drawing.Point(93, 162);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(67, 28);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.Location = new System.Drawing.Point(166, 130);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 28);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officialRatesIdDataGridViewTextBoxColumn,
            this.validityDateDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.officialRatesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 335);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.CurrencyCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ValidDateControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Update, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Insert, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IsActiveCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RateTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ShowData, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 531);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // CurrencyCB
            // 
            this.CurrencyCB.FormattingEnabled = true;
            this.CurrencyCB.Location = new System.Drawing.Point(166, 34);
            this.CurrencyCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyCB.Name = "CurrencyCB";
            this.CurrencyCB.Size = new System.Drawing.Size(108, 24);
            this.CurrencyCB.TabIndex = 13;
            // 
            // ShowData
            // 
            this.ShowData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowData.Location = new System.Drawing.Point(166, 162);
            this.ShowData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(124, 28);
            this.ShowData.TabIndex = 14;
            this.ShowData.Text = "Show data";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // exchangeOfficeDataSet4
            // 
            this.exchangeOfficeDataSet4.DataSetName = "ExchangeOfficeDataSet4";
            this.exchangeOfficeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officialRatesBindingSource
            // 
            this.officialRatesBindingSource.DataMember = "OfficialRates";
            this.officialRatesBindingSource.DataSource = this.exchangeOfficeDataSet4;
            // 
            // officialRatesTableAdapter
            // 
            this.officialRatesTableAdapter.ClearBeforeFill = true;
            // 
            // officialRatesIdDataGridViewTextBoxColumn
            // 
            this.officialRatesIdDataGridViewTextBoxColumn.DataPropertyName = "OfficialRatesId";
            this.officialRatesIdDataGridViewTextBoxColumn.HeaderText = "OfficialRatesId";
            this.officialRatesIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.officialRatesIdDataGridViewTextBoxColumn.Name = "officialRatesIdDataGridViewTextBoxColumn";
            this.officialRatesIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.officialRatesIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // validityDateDataGridViewTextBoxColumn
            // 
            this.validityDateDataGridViewTextBoxColumn.DataPropertyName = "ValidityDate";
            this.validityDateDataGridViewTextBoxColumn.HeaderText = "ValidityDate";
            this.validityDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.validityDateDataGridViewTextBoxColumn.Name = "validityDateDataGridViewTextBoxColumn";
            this.validityDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.Width = 125;
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
            // OfficialRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfficialRates";
            this.Text = "Official Rates";
            this.Load += new System.EventHandler(this.OfficialRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeOfficeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officialRatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ValidDateControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox IsActiveCB;
        private System.Windows.Forms.TextBox RateTB;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CurrencyCB;
        private System.Windows.Forms.Button ShowData;
        private ExchangeOfficeDataSet4 exchangeOfficeDataSet4;
        private System.Windows.Forms.BindingSource officialRatesBindingSource;
        private ExchangeOfficeDataSet4TableAdapters.OfficialRatesTableAdapter officialRatesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn officialRatesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
    }
}