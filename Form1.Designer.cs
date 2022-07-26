namespace ExchangeOffice
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exchangeOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchageRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLSCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLSCurrencyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exchangeOfficeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exchangeOfficeToolStripMenuItem
            // 
            this.exchangeOfficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.officialRatesToolStripMenuItem,
            this.exchageRatesToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.cLSCurrencyToolStripMenuItem,
            this.cLSCurrencyToolStripMenuItem1});
            this.exchangeOfficeToolStripMenuItem.Name = "exchangeOfficeToolStripMenuItem";
            this.exchangeOfficeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.exchangeOfficeToolStripMenuItem.Text = "Menu";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // officialRatesToolStripMenuItem
            // 
            this.officialRatesToolStripMenuItem.Name = "officialRatesToolStripMenuItem";
            this.officialRatesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.officialRatesToolStripMenuItem.Text = "OfficialRates";
            this.officialRatesToolStripMenuItem.Click += new System.EventHandler(this.officialRatesToolStripMenuItem_Click);
            // 
            // exchageRatesToolStripMenuItem
            // 
            this.exchageRatesToolStripMenuItem.Name = "exchageRatesToolStripMenuItem";
            this.exchageRatesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exchageRatesToolStripMenuItem.Text = "ExchageRates";
            this.exchageRatesToolStripMenuItem.Click += new System.EventHandler(this.exchageRatesToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.operationsToolStripMenuItem.Text = "Operations";
            this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // cLSCurrencyToolStripMenuItem
            // 
            this.cLSCurrencyToolStripMenuItem.Name = "cLSCurrencyToolStripMenuItem";
            this.cLSCurrencyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cLSCurrencyToolStripMenuItem.Text = "CLS_Currency";
            this.cLSCurrencyToolStripMenuItem.Click += new System.EventHandler(this.cLSCurrencyToolStripMenuItem_Click);
            // 
            // cLSCurrencyToolStripMenuItem1
            // 
            this.cLSCurrencyToolStripMenuItem1.Name = "cLSCurrencyToolStripMenuItem1";
            this.cLSCurrencyToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cLSCurrencyToolStripMenuItem1.Text = "CLS_OperationType";
            this.cLSCurrencyToolStripMenuItem1.Click += new System.EventHandler(this.cLSCurrencyToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Exchange Office";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exchangeOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchageRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLSCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLSCurrencyToolStripMenuItem1;
    }
}

