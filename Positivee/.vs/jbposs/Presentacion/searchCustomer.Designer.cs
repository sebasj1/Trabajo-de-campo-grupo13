namespace jbposs.Presentacion
{
    partial class searchCustomer
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
            this.lbAction = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.tbCust = new System.Windows.Forms.TextBox();
            this.dataGridCust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCust)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAction.Location = new System.Drawing.Point(10, 16);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(0, 29);
            this.lbAction.TabIndex = 88;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(30, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(93, 29);
            this.name.TabIndex = 85;
            this.name.Text = "Buscar:";
            // 
            // tbCust
            // 
            this.tbCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCust.Location = new System.Drawing.Point(129, 28);
            this.tbCust.Name = "tbCust";
            this.tbCust.Size = new System.Drawing.Size(359, 35);
            this.tbCust.TabIndex = 83;
            this.tbCust.TextChanged += new System.EventHandler(this.tbCust_TextChanged);
            // 
            // dataGridCust
            // 
            this.dataGridCust.AllowUserToAddRows = false;
            this.dataGridCust.AllowUserToDeleteRows = false;
            this.dataGridCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCust.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCust.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridCust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridCust.Location = new System.Drawing.Point(0, 86);
            this.dataGridCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridCust.MultiSelect = false;
            this.dataGridCust.Name = "dataGridCust";
            this.dataGridCust.ReadOnly = true;
            this.dataGridCust.RowHeadersWidth = 62;
            this.dataGridCust.RowTemplate.Height = 28;
            this.dataGridCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCust.Size = new System.Drawing.Size(654, 364);
            this.dataGridCust.TabIndex = 82;
            this.dataGridCust.Click += new System.EventHandler(this.dataGridCust_Click);
            // 
            // searchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tbCust);
            this.Controls.Add(this.dataGridCust);
            this.Name = "searchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "searchCustomer";
            this.Load += new System.EventHandler(this.searchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox tbCust;
        public System.Windows.Forms.DataGridView dataGridCust;
    }
}