namespace Positive.Presentacion
{
    partial class Nueva_categoria
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
            this.btEdRol = new System.Windows.Forms.Button();
            this.lbAction = new System.Windows.Forms.Label();
            this.btRestoreRol = new System.Windows.Forms.Button();
            this.DATAGRIDCELL = new System.Windows.Forms.DataGridView();
            this.btDelRol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).BeginInit();
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
            // DATAGRIDCELL
            // 
            this.DATAGRIDCELL.AllowUserToAddRows = false;
            this.DATAGRIDCELL.AllowUserToDeleteRows = false;
            this.DATAGRIDCELL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATAGRIDCELL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDCELL.Cursor = System.Windows.Forms.Cursors.Default;
            this.DATAGRIDCELL.Location = new System.Drawing.Point(332, 76);
            this.DATAGRIDCELL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DATAGRIDCELL.MultiSelect = false;
            this.DATAGRIDCELL.Name = "DATAGRIDCELL";
            this.DATAGRIDCELL.ReadOnly = true;
            this.DATAGRIDCELL.RowHeadersWidth = 62;
            this.DATAGRIDCELL.RowTemplate.Height = 28;
            this.DATAGRIDCELL.RowTemplate.ReadOnly = true;
            this.DATAGRIDCELL.Size = new System.Drawing.Size(468, 374);
            this.DATAGRIDCELL.TabIndex = 73;
            this.DATAGRIDCELL.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridRol_CellMouseDoubleClick);
            // 
            // btDelRol
            // 
            this.btDelRol.BackColor = System.Drawing.Color.Red;
            this.btDelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btDelRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelRol.Location = new System.Drawing.Point(189, 329);
            this.btDelRol.Name = "btDelRol";
            this.btDelRol.Size = new System.Drawing.Size(122, 66);
            this.btDelRol.TabIndex = 77;
            this.btDelRol.Text = "Eliminar";
            this.btDelRol.UseVisualStyleBackColor = false;
            this.btDelRol.Click += new System.EventHandler(this.delRol_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(666, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 66);
            this.button1.TabIndex = 82;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Agregar_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNewRol);
            this.Controls.Add(this.btRestoreRol);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.btEdRol);
            this.Controls.Add(this.btDelRol);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btAddRol);
            this.Controls.Add(this.tbAddRol);
            this.Controls.Add(this.DATAGRIDCELL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_categoria";
            this.Text = "addCategorie";
            this.Load += new System.EventHandler(this.addCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewRol;
        private System.Windows.Forms.TextBox tbAddRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btEdRol;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Button btRestoreRol;
        public System.Windows.Forms.DataGridView DATAGRIDCELL;
        private System.Windows.Forms.Button btDelRol;
        private System.Windows.Forms.Button button1;
    }
}