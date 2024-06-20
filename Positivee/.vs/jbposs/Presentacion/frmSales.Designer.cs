namespace JBPOS.Presentacion
{
    partial class frmSales
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
            this.panelUsersSales = new System.Windows.Forms.Panel();
            this.panelUsers1 = new System.Windows.Forms.Panel();
            this.listSales = new FontAwesome.Sharp.IconButton();
            this.bVoucher = new FontAwesome.Sharp.IconButton();
            this.bCancelSale = new FontAwesome.Sharp.IconButton();
            this.panelUsers1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsersSales
            // 
            this.panelUsersSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUsersSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsersSales.Location = new System.Drawing.Point(334, 0);
            this.panelUsersSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsersSales.Name = "panelUsersSales";
            this.panelUsersSales.Size = new System.Drawing.Size(870, 754);
            this.panelUsersSales.TabIndex = 3;
            // 
            // panelUsers1
            // 
            this.panelUsers1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelUsers1.Controls.Add(this.listSales);
            this.panelUsers1.Controls.Add(this.bVoucher);
            this.panelUsers1.Controls.Add(this.bCancelSale);
            this.panelUsers1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUsers1.Location = new System.Drawing.Point(0, 0);
            this.panelUsers1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers1.Name = "panelUsers1";
            this.panelUsers1.Size = new System.Drawing.Size(334, 754);
            this.panelUsers1.TabIndex = 2;
            // 
            // listSales
            // 
            this.listSales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listSales.IconChar = FontAwesome.Sharp.IconChar.Indent;
            this.listSales.IconColor = System.Drawing.Color.Black;
            this.listSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.listSales.IconSize = 40;
            this.listSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listSales.Location = new System.Drawing.Point(58, 80);
            this.listSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSales.Name = "listSales";
            this.listSales.Size = new System.Drawing.Size(212, 61);
            this.listSales.TabIndex = 9;
            this.listSales.Text = "Lista de ventas  ";
            this.listSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listSales.UseVisualStyleBackColor = false;
            this.listSales.Click += new System.EventHandler(this.listSales_Click);
            // 
            // bVoucher
            // 
            this.bVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bVoucher.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bVoucher.IconColor = System.Drawing.Color.Black;
            this.bVoucher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVoucher.IconSize = 40;
            this.bVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bVoucher.Location = new System.Drawing.Point(57, 169);
            this.bVoucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVoucher.Name = "bVoucher";
            this.bVoucher.Size = new System.Drawing.Size(212, 61);
            this.bVoucher.TabIndex = 8;
            this.bVoucher.Text = "Mostrar comprobante ";
            this.bVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bVoucher.UseVisualStyleBackColor = true;
            this.bVoucher.Click += new System.EventHandler(this.bVoucher_Click);
            // 
            // bCancelSale
            // 
            this.bCancelSale.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bCancelSale.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.bCancelSale.IconColor = System.Drawing.Color.Black;
            this.bCancelSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCancelSale.IconSize = 40;
            this.bCancelSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancelSale.Location = new System.Drawing.Point(58, 265);
            this.bCancelSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancelSale.Name = "bCancelSale";
            this.bCancelSale.Size = new System.Drawing.Size(212, 61);
            this.bCancelSale.TabIndex = 7;
            this.bCancelSale.Text = "Anular venta    ";
            this.bCancelSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelSale.UseVisualStyleBackColor = false;
            this.bCancelSale.Click += new System.EventHandler(this.bCancelSale_Click);
            // 
            // frmSales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1204, 754);
            this.Controls.Add(this.panelUsersSales);
            this.Controls.Add(this.panelUsers1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSales";
            this.Text = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panelUsers1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsersSales;
        private System.Windows.Forms.Panel panelUsers1;
        private FontAwesome.Sharp.IconButton bCancelSale;
        private FontAwesome.Sharp.IconButton bVoucher;
        private FontAwesome.Sharp.IconButton listSales;
    }
}