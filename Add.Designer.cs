namespace Blood_Bank
{
    partial class MainForm
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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloodBankToolStripMenuItem,
            this.inputDataToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // bloodBankToolStripMenuItem
            // 
            this.bloodBankToolStripMenuItem.Name = "bloodBankToolStripMenuItem";
            this.bloodBankToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bloodBankToolStripMenuItem.Text = "Blood Bank";
            // 
            // inputDataToolStripMenuItem
            // 
            this.inputDataToolStripMenuItem.Name = "inputDataToolStripMenuItem";
            this.inputDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputDataToolStripMenuItem.Text = "Input Data";
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Location = new System.Drawing.Point(23, 56);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(370, 604);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search";
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Location = new System.Drawing.Point(418, 56);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(911, 604);
            this.groupBox_Info.TabIndex = 1;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Blood Bank";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.GroupBox groupBox_Info;
    }
}