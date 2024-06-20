namespace jbposs.Presentacion
{
    partial class addCategorie
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
            this.btNewRol = new System.Windows.Forms.Button();
            this.tbAddRol = new System.Windows.Forms.TextBox();
            this.btAddRol = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.btDelRol = new System.Windows.Forms.Button();
            this.btEdRol = new System.Windows.Forms.Button();
            this.lbAction = new System.Windows.Forms.Label();
            this.btRestoreRol = new System.Windows.Forms.Button();
            this.dataGridRol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).BeginInit();
            this.SuspendLayout();
            // 
            // btNewRol
            // 
            this.btNewRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btNewRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btNewRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNewRol.Location = new System.Drawing.Point(24, 179);
            this.btNewRol.Name = "btNewRol";
            this.btNewRol.Size = new System.Drawing.Size(122, 66);
            this.btNewRol.TabIndex = 81;
            this.btNewRol.Text = "Nuevo";
            this.btNewRol.UseVisualStyleBackColor = false;
            this.btNewRol.Click += new System.EventHandler(this.btNewRol_Click);
            // 
            // tbAddRol
            // 
            this.tbAddRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAddRol.Location = new System.Drawing.Point(24, 126);
            this.tbAddRol.Name = "tbAddRol";
            this.tbAddRol.Size = new System.Drawing.Size(287, 35);
            this.tbAddRol.TabIndex = 74;
            // 
            // btAddRol
            // 
            this.btAddRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAddRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btAddRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddRol.Location = new System.Drawing.Point(177, 179);
            this.btAddRol.Name = "btAddRol";
            this.btAddRol.Size = new System.Drawing.Size(134, 83);
            this.btAddRol.TabIndex = 75;
            this.btAddRol.Text = "Agregar";
            this.btAddRol.UseVisualStyleBackColor = false;
            this.btAddRol.Click += new System.EventHandler(this.btAddRol_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(19, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(105, 29);
            this.name.TabIndex = 76;
            this.name.Text = "Agregar:";
            // 
            // btDelRol
            // 
            this.btDelRol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btDelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btDelRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelRol.Location = new System.Drawing.Point(177, 329);
            this.btDelRol.Name = "btDelRol";
            this.btDelRol.Size = new System.Drawing.Size(122, 66);
            this.btDelRol.TabIndex = 77;
            this.btDelRol.Text = "Eliminar";
            this.btDelRol.UseVisualStyleBackColor = false;
            this.btDelRol.Click += new System.EventHandler(this.delRol_Click);
            // 
            // btEdRol
            // 
            this.btEdRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btEdRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btEdRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdRol.Location = new System.Drawing.Point(24, 257);
            this.btEdRol.Name = "btEdRol";
            this.btEdRol.Size = new System.Drawing.Size(122, 66);
            this.btEdRol.TabIndex = 78;
            this.btEdRol.Text = "Editar";
            this.btEdRol.UseVisualStyleBackColor = false;
            this.btEdRol.Click += new System.EventHandler(this.edRol_Click);
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAction.Location = new System.Drawing.Point(19, 31);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(0, 29);
            this.lbAction.TabIndex = 79;
            // 
            // btRestoreRol
            // 
            this.btRestoreRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btRestoreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRestoreRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRestoreRol.Location = new System.Drawing.Point(24, 329);
            this.btRestoreRol.Name = "btRestoreRol";
            this.btRestoreRol.Size = new System.Drawing.Size(122, 66);
            this.btRestoreRol.TabIndex = 80;
            this.btRestoreRol.Text = "Restaurar";
            this.btRestoreRol.UseVisualStyleBackColor = false;
            this.btRestoreRol.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridRol
            // 
            this.dataGridRol.AllowUserToAddRows = false;
            this.dataGridRol.AllowUserToDeleteRows = false;
            this.dataGridRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRol.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridRol.Location = new System.Drawing.Point(332, 76);
            this.dataGridRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRol.MultiSelect = false;
            this.dataGridRol.Name = "dataGridRol";
            this.dataGridRol.ReadOnly = true;
            this.dataGridRol.RowHeadersWidth = 62;
            this.dataGridRol.RowTemplate.Height = 28;
            this.dataGridRol.Size = new System.Drawing.Size(468, 374);
            this.dataGridRol.TabIndex = 73;
            this.dataGridRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRol_CellContentClick);
            this.dataGridRol.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridRol_CellMouseDoubleClick);
            // 
            // addCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNewRol);
            this.Controls.Add(this.btRestoreRol);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.btEdRol);
            this.Controls.Add(this.btDelRol);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btAddRol);
            this.Controls.Add(this.tbAddRol);
            this.Controls.Add(this.dataGridRol);
            this.Name = "addCategorie";
            this.Text = "addCategorie";
            this.Load += new System.EventHandler(this.addCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewRol;
        private System.Windows.Forms.TextBox tbAddRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btDelRol;
        private System.Windows.Forms.Button btEdRol;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Button btRestoreRol;
        public System.Windows.Forms.DataGridView dataGridRol;
    }
}