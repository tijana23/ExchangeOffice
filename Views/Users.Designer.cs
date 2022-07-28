namespace ExchangeOffice
{
    partial class Users
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ActiveBoxCB = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ShowData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(220, 44);
            this.SurnameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(257, 26);
            this.SurnameTB.TabIndex = 4;
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertButton.Location = new System.Drawing.Point(129, 124);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(85, 27);
            this.InsertButton.TabIndex = 6;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(220, 124);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 27);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(129, 164);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 27);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ActiveBoxCB
            // 
            this.ActiveBoxCB.AutoSize = true;
            this.ActiveBoxCB.Location = new System.Drawing.Point(220, 84);
            this.ActiveBoxCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActiveBoxCB.Name = "ActiveBoxCB";
            this.ActiveBoxCB.Size = new System.Drawing.Size(74, 24);
            this.ActiveBoxCB.TabIndex = 9;
            this.ActiveBoxCB.Text = "Active";
            this.ActiveBoxCB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 510);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(220, 4);
            this.NameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(257, 26);
            this.NameTB.TabIndex = 11;
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(220, 163);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(175, 29);
            this.ShowData.TabIndex = 12;
            this.ShowData.Text = "Show Data";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.NameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ActiveBoxCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SurnameTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.InsertButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ShowData, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.UpdateButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 693);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox ActiveBoxCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}