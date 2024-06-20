namespace Positivee.Presentacion
{
    partial class Lista_venta
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
            this.DATAGRIDCELL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).BeginInit();
            this.SuspendLayout();
            // 
            // DATAGRIDCELL
            // 
            this.DATAGRIDCELL.AllowUserToAddRows = false;
            this.DATAGRIDCELL.AllowUserToDeleteRows = false;
            this.DATAGRIDCELL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATAGRIDCELL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DATAGRIDCELL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDCELL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DATAGRIDCELL.Location = new System.Drawing.Point(0, 0);
            this.DATAGRIDCELL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DATAGRIDCELL.MultiSelect = false;
            this.DATAGRIDCELL.Name = "DATAGRIDCELL";
            this.DATAGRIDCELL.ReadOnly = true;
            this.DATAGRIDCELL.RowHeadersWidth = 62;
            this.DATAGRIDCELL.RowTemplate.Height = 28;
            this.DATAGRIDCELL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGRIDCELL.Size = new System.Drawing.Size(1236, 571);
            this.DATAGRIDCELL.TabIndex = 15;
            // 
            // Lista_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 571);
            this.Controls.Add(this.DATAGRIDCELL);
            this.Name = "Lista_venta";
            this.Text = "Lista_venta";
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DATAGRIDCELL;
    }
}