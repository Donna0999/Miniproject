namespace MiniProject.Logica
{
    partial class ReserveringenForm
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
            this.lstReserveringen = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KlantColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoekColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserveringen";
            // 
            // lstReserveringen
            // 
            this.lstReserveringen.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstReserveringen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.KlantColumn,
            this.BoekColumn});
            this.lstReserveringen.HideSelection = false;
            this.lstReserveringen.Location = new System.Drawing.Point(15, 25);
            this.lstReserveringen.MultiSelect = false;
            this.lstReserveringen.Name = "lstReserveringen";
            this.lstReserveringen.Size = new System.Drawing.Size(326, 97);
            this.lstReserveringen.TabIndex = 1;
            this.lstReserveringen.UseCompatibleStateImageBehavior = false;
            this.lstReserveringen.View = System.Windows.Forms.View.Details;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "ID";
            this.IdColumn.Width = 23;
            // 
            // KlantColumn
            // 
            this.KlantColumn.Text = "Klant";
            this.KlantColumn.Width = 74;
            // 
            // BoekColumn
            // 
            this.BoekColumn.Text = "Boek";
            this.BoekColumn.Width = 223;
            // 
            // ReserveringenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 134);
            this.Controls.Add(this.lstReserveringen);
            this.Controls.Add(this.label1);
            this.Name = "ReserveringenForm";
            this.Text = "ReserveringenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstReserveringen;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader KlantColumn;
        private System.Windows.Forms.ColumnHeader BoekColumn;
    }
}