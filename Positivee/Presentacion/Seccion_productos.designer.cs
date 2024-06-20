namespace Positive.Presentacion
{
    partial class Seccion_productos
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
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.LABELPRINCIPAL = new System.Windows.Forms.Label();
            this.DATAGRIDCELL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new FontAwesome.Sharp.IconButton();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.panelUsers1 = new System.Windows.Forms.Panel();
            this.btRestP = new FontAwesome.Sharp.IconButton();
            this.btDelProd = new FontAwesome.Sharp.IconButton();
            this.listProd = new FontAwesome.Sharp.IconButton();
            this.btEditCat = new FontAwesome.Sharp.IconButton();
            this.btProdEd = new FontAwesome.Sharp.IconButton();
            this.bNewProd = new FontAwesome.Sharp.IconButton();
            this.panelProducts.SuspendLayout();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelUsers1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProducts.Controls.Add(this.panelUsers);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(334, 0);
            this.panelProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1460, 754);
            this.panelProducts.TabIndex = 7;
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
            this.panelUsers.Size = new System.Drawing.Size(1460, 754);
            this.panelUsers.TabIndex = 6;
            // 
            // LABELPRINCIPAL
            // 
            this.LABELPRINCIPAL.AutoSize = true;
            this.LABELPRINCIPAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELPRINCIPAL.Location = new System.Drawing.Point(62, 28);
            this.LABELPRINCIPAL.Name = "LABELPRINCIPAL";
            this.LABELPRINCIPAL.Size = new System.Drawing.Size(347, 46);
            this.LABELPRINCIPAL.TabIndex = 16;
            this.LABELPRINCIPAL.Text = "Lista de productos";
            // 
            // DATAGRIDCELL
            // 
            this.DATAGRIDCELL.AllowUserToAddRows = false;
            this.DATAGRIDCELL.AllowUserToDeleteRows = false;
            this.DATAGRIDCELL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATAGRIDCELL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DATAGRIDCELL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDCELL.Location = new System.Drawing.Point(35, 150);
            this.DATAGRIDCELL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DATAGRIDCELL.MultiSelect = false;
            this.DATAGRIDCELL.Name = "DATAGRIDCELL";
            this.DATAGRIDCELL.ReadOnly = true;
            this.DATAGRIDCELL.RowHeadersWidth = 62;
            this.DATAGRIDCELL.RowTemplate.Height = 28;
            this.DATAGRIDCELL.Size = new System.Drawing.Size(1368, 593);
            this.DATAGRIDCELL.TabIndex = 14;
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
            this.groupBox1.Size = new System.Drawing.Size(655, 91);
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
            // panelUsers1
            // 
            this.panelUsers1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelUsers1.Controls.Add(this.btRestP);
            this.panelUsers1.Controls.Add(this.btDelProd);
            this.panelUsers1.Controls.Add(this.listProd);
            this.panelUsers1.Controls.Add(this.btEditCat);
            this.panelUsers1.Controls.Add(this.btProdEd);
            this.panelUsers1.Controls.Add(this.bNewProd);
            this.panelUsers1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUsers1.Location = new System.Drawing.Point(0, 0);
            this.panelUsers1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers1.Name = "panelUsers1";
            this.panelUsers1.Size = new System.Drawing.Size(334, 754);
            this.panelUsers1.TabIndex = 6;
            // 
            // btRestP
            // 
            this.btRestP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRestP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRestP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRestP.IconChar = FontAwesome.Sharp.IconChar.TurnUp;
            this.btRestP.IconColor = System.Drawing.Color.Black;
            this.btRestP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRestP.IconSize = 40;
            this.btRestP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRestP.Location = new System.Drawing.Point(57, 443);
            this.btRestP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRestP.Name = "btRestP";
            this.btRestP.Size = new System.Drawing.Size(212, 61);
            this.btRestP.TabIndex = 13;
            this.btRestP.Text = "Restaurar producto";
            this.btRestP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRestP.UseVisualStyleBackColor = false;
            this.btRestP.Click += new System.EventHandler(this.btRestP_Click);
            // 
            // btDelProd
            // 
            this.btDelProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btDelProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btDelProd.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btDelProd.IconColor = System.Drawing.Color.Black;
            this.btDelProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelProd.IconSize = 40;
            this.btDelProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelProd.Location = new System.Drawing.Point(57, 347);
            this.btDelProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelProd.Name = "btDelProd";
            this.btDelProd.Size = new System.Drawing.Size(212, 61);
            this.btDelProd.TabIndex = 12;
            this.btDelProd.Text = "Eliminar producto";
            this.btDelProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelProd.UseVisualStyleBackColor = false;
            this.btDelProd.Click += new System.EventHandler(this.btDelProd_Click);
            // 
            // listProd
            // 
            this.listProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listProd.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.listProd.IconColor = System.Drawing.Color.Black;
            this.listProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.listProd.IconSize = 40;
            this.listProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listProd.Location = new System.Drawing.Point(57, 163);
            this.listProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(212, 61);
            this.listProd.TabIndex = 11;
            this.listProd.Text = "Lista producto  ";
            this.listProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listProd.UseVisualStyleBackColor = false;
            this.listProd.Click += new System.EventHandler(this.listProd_Click);
            // 
            // btEditCat
            // 
            this.btEditCat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEditCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btEditCat.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.btEditCat.IconColor = System.Drawing.Color.Black;
            this.btEditCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEditCat.IconSize = 40;
            this.btEditCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditCat.Location = new System.Drawing.Point(57, 532);
            this.btEditCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditCat.Name = "btEditCat";
            this.btEditCat.Size = new System.Drawing.Size(212, 61);
            this.btEditCat.TabIndex = 10;
            this.btEditCat.Text = "Editar categorias";
            this.btEditCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditCat.UseVisualStyleBackColor = false;
            this.btEditCat.Click += new System.EventHandler(this.btEditCat_Click);
            // 
            // btProdEd
            // 
            this.btProdEd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btProdEd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btProdEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btProdEd.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.btProdEd.IconColor = System.Drawing.Color.Black;
            this.btProdEd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btProdEd.IconSize = 40;
            this.btProdEd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProdEd.Location = new System.Drawing.Point(57, 255);
            this.btProdEd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProdEd.Name = "btProdEd";
            this.btProdEd.Size = new System.Drawing.Size(212, 61);
            this.btProdEd.TabIndex = 8;
            this.btProdEd.Text = "Editar producto  ";
            this.btProdEd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProdEd.UseVisualStyleBackColor = false;
            this.btProdEd.Click += new System.EventHandler(this.btProdEd_Click);
            // 
            // bNewProd
            // 
            this.bNewProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bNewProd.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.bNewProd.IconColor = System.Drawing.Color.Black;
            this.bNewProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bNewProd.IconSize = 40;
            this.bNewProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNewProd.Location = new System.Drawing.Point(57, 74);
            this.bNewProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bNewProd.Name = "bNewProd";
            this.bNewProd.Size = new System.Drawing.Size(212, 61);
            this.bNewProd.TabIndex = 4;
            this.bNewProd.Text = "Agregar nuevo   ";
            this.bNewProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNewProd.UseVisualStyleBackColor = false;
            this.bNewProd.Click += new System.EventHandler(this.bNewProd_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1794, 754);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelUsers1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panelProducts.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelUsers1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelUsers1;
        private FontAwesome.Sharp.IconButton btEditCat;
        private FontAwesome.Sharp.IconButton bNewProd;
        private FontAwesome.Sharp.IconButton listProd;
        private FontAwesome.Sharp.IconButton btDelProd;
        public FontAwesome.Sharp.IconButton btProdEd;
        private FontAwesome.Sharp.IconButton btRestP;
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