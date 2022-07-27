namespace ExchangeOffice
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(441, 45);
            this.SurnameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(257, 26);
            this.SurnameTB.TabIndex = 4;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(142, 110);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(84, 29);
            this.InsertButton.TabIndex = 6;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(250, 110);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 29);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(362, 110);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 29);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ActiveBoxCB
            // 
            this.ActiveBoxCB.AutoSize = true;
            this.ActiveBoxCB.Location = new System.Drawing.Point(757, 48);
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
            this.dataGridView1.Location = new System.Drawing.Point(76, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 358);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(76, 45);
            this.NameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(257, 26);
            this.NameTB.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ActiveBoxCB);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
    }
}