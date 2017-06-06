namespace MiniProject.Logica
{
    partial class BoekenForm
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
            this.lstReserveringen = new System.Windows.Forms.ListBox();
            this.cmbBoeken = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstReserveringen
            // 
            this.lstReserveringen.FormattingEnabled = true;
            this.lstReserveringen.Location = new System.Drawing.Point(15, 59);
            this.lstReserveringen.Name = "lstReserveringen";
            this.lstReserveringen.Size = new System.Drawing.Size(257, 95);
            this.lstReserveringen.TabIndex = 7;
            // 
            // cmbBoeken
            // 
            this.cmbBoeken.FormattingEnabled = true;
            this.cmbBoeken.Location = new System.Drawing.Point(97, 12);
            this.cmbBoeken.Name = "cmbBoeken";
            this.cmbBoeken.Size = new System.Drawing.Size(175, 21);
            this.cmbBoeken.TabIndex = 6;
            this.cmbBoeken.SelectedIndexChanged += new System.EventHandler(this.cmbBoeken_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reserveringen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecteer boek";
            // 
            // BoekenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.lstReserveringen);
            this.Controls.Add(this.cmbBoeken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "BoekenForm";
            this.Text = "BoekenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReserveringen;
        private System.Windows.Forms.ComboBox cmbBoeken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}