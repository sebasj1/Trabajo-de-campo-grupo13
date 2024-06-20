namespace jbposs.Presentacion
{
    partial class frmProducts
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
            this.panelUsers1 = new System.Windows.Forms.Panel();
            this.btRestP = new FontAwesome.Sharp.IconButton();
            this.btDelProd = new FontAwesome.Sharp.IconButton();
            this.listProd = new FontAwesome.Sharp.IconButton();
            this.btEditCat = new FontAwesome.Sharp.IconButton();
            this.btProdEd = new FontAwesome.Sharp.IconButton();
            this.bNewProd = new FontAwesome.Sharp.IconButton();
            this.panelUsers1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(334, 0);
            this.panelProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(870, 754);
            this.panelProducts.TabIndex = 7;
            this.panelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProducts_Paint);
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
            this.btRestP.IconChar = FontAwesome.Sharp.IconChar.LevelUpAlt;
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
            this.btDelProd.IconChar = FontAwesome.Sharp.IconChar.Times;
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
            this.btEditCat.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
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
            this.ClientSize = new System.Drawing.Size(1204, 754);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelUsers1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
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
    }
}