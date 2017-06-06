namespace MiniProject
{
    partial class UI
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
            this.boekenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveringenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boekenToolStripMenuItem,
            this.klantenToolStripMenuItem,
            this.reserveringenToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // boekenToolStripMenuItem
            // 
            this.boekenToolStripMenuItem.Name = "boekenToolStripMenuItem";
            this.boekenToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.boekenToolStripMenuItem.Text = "Boeken";
            this.boekenToolStripMenuItem.Click += new System.EventHandler(this.boekenToolStripMenuItem_Click);
            // 
            // klantenToolStripMenuItem
            // 
            this.klantenToolStripMenuItem.Name = "klantenToolStripMenuItem";
            this.klantenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.klantenToolStripMenuItem.Text = "Klanten";
            this.klantenToolStripMenuItem.Click += new System.EventHandler(this.klantenToolStripMenuItem_Click);
            // 
            // reserveringenToolStripMenuItem
            // 
            this.reserveringenToolStripMenuItem.Name = "reserveringenToolStripMenuItem";
            this.reserveringenToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reserveringenToolStripMenuItem.Text = "Reserveringen";
            this.reserveringenToolStripMenuItem.Click += new System.EventHandler(this.reserveringenToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 272);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UI";
            this.Text = "UI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem boekenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveringenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}