namespace Positive.Presentacion
{
    partial class Lista_usuarios
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
            this.panelUsers = new System.Windows.Forms.Panel();
            this.LABELPRINCIPAL = new System.Windows.Forms.Label();
            this.DATAGRIDCELL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new FontAwesome.Sharp.IconButton();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUsers.Controls.Add(this.LABELPRINCIPAL);
            this.panelUsers.Controls.Add(this.DATAGRIDCELL);
            this.panelUsers.Controls.Add(this.groupBox1);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1506, 698);
            this.panelUsers.TabIndex = 6;
            // 
            // LABELPRINCIPAL
            // 
            this.LABELPRINCIPAL.AutoSize = true;
            this.LABELPRINCIPAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELPRINCIPAL.Location = new System.Drawing.Point(34, 29);
            this.LABELPRINCIPAL.Name = "LABELPRINCIPAL";
            this.LABELPRINCIPAL.Size = new System.Drawing.Size(321, 46);
            this.LABELPRINCIPAL.TabIndex = 16;
            this.LABELPRINCIPAL.Text = "Lista de usuarios";
            // 
            // DATAGRIDCELL
            // 
            this.DATAGRIDCELL.AllowUserToAddRows = false;
            this.DATAGRIDCELL.AllowUserToDeleteRows = false;
            this.DATAGRIDCELL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATAGRIDCELL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DATAGRIDCELL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDCELL.Location = new System.Drawing.Point(24, 150);
            this.DATAGRIDCELL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DATAGRIDCELL.MultiSelect = false;
            this.DATAGRIDCELL.Name = "DATAGRIDCELL";
            this.DATAGRIDCELL.ReadOnly = true;
            this.DATAGRIDCELL.RowHeadersWidth = 62;
            this.DATAGRIDCELL.RowTemplate.Height = 28;
            this.DATAGRIDCELL.Size = new System.Drawing.Size(1470, 593);
            this.DATAGRIDCELL.TabIndex = 14;
            this.DATAGRIDCELL.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGRIDCELL_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(775, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(719, 91);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRefresh.IconColor = System.Drawing.Color.Black;
            this.btRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRefresh.IconSize = 30;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefresh.Location = new System.Drawing.Point(499, 23);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(158, 57);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Actualizar";
            this.btRefresh.UseVisualStyleBackColor = false;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.IntegralHeight = false;
            this.cbRol.ItemHeight = 26;
            this.cbRol.Location = new System.Drawing.Point(66, 35);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(248, 34);
            this.cbRol.TabIndex = 10;
            this.cbRol.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ver :";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFilter.IconColor = System.Drawing.Color.Black;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 30;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(333, 23);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(158, 57);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 698);
            this.Controls.Add(this.panelUsers);
            this.Name = "lista";
            this.Text = "lista";
            this.Load += new System.EventHandler(this.lista_Load);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsers;
        public System.Windows.Forms.Label LABELPRINCIPAL;
        public System.Windows.Forms.DataGridView DATAGRIDCELL;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btRefresh;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnFilter;
    }
}