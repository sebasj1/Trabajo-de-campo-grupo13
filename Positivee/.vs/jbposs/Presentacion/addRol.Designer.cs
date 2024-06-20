namespace jbposs.Presentacion
{
    partial class addRol
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
            this.components = new System.ComponentModel.Container();
            this.dataGridRol = new System.Windows.Forms.DataGridView();
            this.btAddRol = new System.Windows.Forms.Button();
            this.tbAddRol = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btDelRol = new System.Windows.Forms.Button();
            this.btEdRol = new System.Windows.Forms.Button();
            this.lbAction = new System.Windows.Forms.Label();
            this.btRestoreRol = new System.Windows.Forms.Button();
            this.btNewRol = new System.Windows.Forms.Button();
            this.pCBPermisos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRol
            // 
            this.dataGridRol.AllowUserToAddRows = false;
            this.dataGridRol.AllowUserToDeleteRows = false;
            this.dataGridRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRol.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridRol.Location = new System.Drawing.Point(296, 61);
            this.dataGridRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRol.MultiSelect = false;
            this.dataGridRol.Name = "dataGridRol";
            this.dataGridRol.ReadOnly = true;
            this.dataGridRol.RowHeadersWidth = 62;
            this.dataGridRol.RowTemplate.Height = 28;
            this.dataGridRol.Size = new System.Drawing.Size(373, 299);
            this.dataGridRol.TabIndex = 64;
            this.dataGridRol.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridRol_CellMouseDoubleClick);
            this.dataGridRol.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRol_CellMouseLeave);
            this.dataGridRol.SelectionChanged += new System.EventHandler(this.dataGridRol_SelectionChanged);
            // 
            // btAddRol
            // 
            this.btAddRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAddRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btAddRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddRol.Location = new System.Drawing.Point(26, 307);
            this.btAddRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddRol.Name = "btAddRol";
            this.btAddRol.Size = new System.Drawing.Size(222, 53);
            this.btAddRol.TabIndex = 66;
            this.btAddRol.Text = "Agregar";
            this.btAddRol.UseVisualStyleBackColor = false;
            this.btAddRol.Click += new System.EventHandler(this.btAddRol_Click);
            // 
            // tbAddRol
            // 
            this.tbAddRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAddRol.Location = new System.Drawing.Point(26, 61);
            this.tbAddRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddRol.Name = "tbAddRol";
            this.tbAddRol.Size = new System.Drawing.Size(229, 30);
            this.tbAddRol.TabIndex = 65;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btDelRol
            // 
            this.btDelRol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btDelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btDelRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelRol.Location = new System.Drawing.Point(140, 195);
            this.btDelRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelRol.Name = "btDelRol";
            this.btDelRol.Size = new System.Drawing.Size(108, 53);
            this.btDelRol.TabIndex = 68;
            this.btDelRol.Text = "Eliminar";
            this.btDelRol.UseVisualStyleBackColor = false;
            this.btDelRol.Click += new System.EventHandler(this.delRol_Click);
            // 
            // btEdRol
            // 
            this.btEdRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btEdRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btEdRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdRol.Location = new System.Drawing.Point(140, 120);
            this.btEdRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdRol.Name = "btEdRol";
            this.btEdRol.Size = new System.Drawing.Size(108, 53);
            this.btEdRol.TabIndex = 69;
            this.btEdRol.Text = "Editar";
            this.btEdRol.UseVisualStyleBackColor = false;
            this.btEdRol.Click += new System.EventHandler(this.edRol_Click);
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAction.Location = new System.Drawing.Point(34, 25);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(0, 25);
            this.lbAction.TabIndex = 70;
            // 
            // btRestoreRol
            // 
            this.btRestoreRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btRestoreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRestoreRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRestoreRol.Location = new System.Drawing.Point(26, 195);
            this.btRestoreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRestoreRol.Name = "btRestoreRol";
            this.btRestoreRol.Size = new System.Drawing.Size(108, 53);
            this.btRestoreRol.TabIndex = 71;
            this.btRestoreRol.Text = "Restaurar";
            this.btRestoreRol.UseVisualStyleBackColor = false;
            this.btRestoreRol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btNewRol
            // 
            this.btNewRol.BackColor = System.Drawing.SystemColors.Highlight;
            this.btNewRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btNewRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNewRol.Location = new System.Drawing.Point(26, 120);
            this.btNewRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNewRol.Name = "btNewRol";
            this.btNewRol.Size = new System.Drawing.Size(108, 53);
            this.btNewRol.TabIndex = 72;
            this.btNewRol.Text = "Nuevo";
            this.btNewRol.UseVisualStyleBackColor = false;
            this.btNewRol.Click += new System.EventHandler(this.btNewRol_Click);
            // 
            // pCBPermisos
            // 
            this.pCBPermisos.Enabled = false;
            this.pCBPermisos.Location = new System.Drawing.Point(676, 94);
            this.pCBPermisos.Name = "pCBPermisos";
            this.pCBPermisos.Size = new System.Drawing.Size(159, 266);
            this.pCBPermisos.TabIndex = 73;
            // 
            // addRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(847, 403);
            this.Controls.Add(this.pCBPermisos);
            this.Controls.Add(this.btNewRol);
            this.Controls.Add(this.btRestoreRol);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.btEdRol);
            this.Controls.Add(this.btDelRol);
            this.Controls.Add(this.btAddRol);
            this.Controls.Add(this.tbAddRol);
            this.Controls.Add(this.dataGridRol);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addRol";
            this.Text = "addRol";
            this.Load += new System.EventHandler(this.addRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.TextBox tbAddRol;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btDelRol;
        private System.Windows.Forms.Button btEdRol;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Button btRestoreRol;
        private System.Windows.Forms.Button btNewRol;
        private System.Windows.Forms.Panel pCBPermisos;
    }
}