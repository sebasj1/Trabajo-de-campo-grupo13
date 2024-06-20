namespace jbposs.Presentacion
{
    partial class frmMain
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
            FontAwesome.Sharp.IconMenuItem iconMenuReports;
            FontAwesome.Sharp.IconMenuItem iconMenuBackup;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.iconCuadroVenta = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuUsers = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuProducts = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuSales = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuCustomers = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuLogout = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            iconMenuReports = new FontAwesome.Sharp.IconMenuItem();
            iconMenuBackup = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconMenuReports
            // 
            iconMenuReports.AutoSize = false;
            iconMenuReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconMenuReports.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            iconMenuReports.IconColor = System.Drawing.Color.Black;
            iconMenuReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuReports.IconSize = 60;
            iconMenuReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            iconMenuReports.MergeAction = System.Windows.Forms.MergeAction.Insert;
            iconMenuReports.Name = "iconMenuReports";
            iconMenuReports.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            iconMenuReports.Size = new System.Drawing.Size(125, 101);
            iconMenuReports.Text = "Reportes";
            iconMenuReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconMenuReports.Click += new System.EventHandler(this.iconMenuItem3_Click_1);
            // 
            // iconMenuBackup
            // 
            iconMenuBackup.AutoSize = false;
            iconMenuBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconMenuBackup.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconMenuBackup.IconColor = System.Drawing.Color.Black;
            iconMenuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuBackup.IconSize = 60;
            iconMenuBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            iconMenuBackup.Name = "iconMenuBackup";
            iconMenuBackup.Size = new System.Drawing.Size(180, 101);
            iconMenuBackup.Text = "Copia de seguridad";
            iconMenuBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconMenuBackup.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1898, 109);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconCuadroVenta,
            this.iconMenuUsers,
            this.iconMenuProducts,
            this.iconMenuSales,
            this.iconMenuCustomers,
            iconMenuReports,
            iconMenuBackup,
            this.iconMenuLogout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 109);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1898, 105);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // iconCuadroVenta
            // 
            this.iconCuadroVenta.AutoSize = false;
            this.iconCuadroVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCuadroVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconCuadroVenta.IconColor = System.Drawing.Color.Black;
            this.iconCuadroVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCuadroVenta.IconSize = 60;
            this.iconCuadroVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCuadroVenta.Name = "iconCuadroVenta";
            this.iconCuadroVenta.RightToLeftAutoMirrorImage = true;
            this.iconCuadroVenta.Size = new System.Drawing.Size(125, 101);
            this.iconCuadroVenta.Text = "Cuadro venta";
            this.iconCuadroVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconCuadroVenta.Click += new System.EventHandler(this.iconVenta_Click);
            // 
            // iconMenuUsers
            // 
            this.iconMenuUsers.AutoSize = false;
            this.iconMenuUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuUsers.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconMenuUsers.IconColor = System.Drawing.Color.Black;
            this.iconMenuUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuUsers.IconSize = 60;
            this.iconMenuUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuUsers.Name = "iconMenuUsers";
            this.iconMenuUsers.Size = new System.Drawing.Size(152, 101);
            this.iconMenuUsers.Text = "Usuarios";
            this.iconMenuUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuUsers.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // iconMenuProducts
            // 
            this.iconMenuProducts.AutoSize = false;
            this.iconMenuProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuProducts.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconMenuProducts.IconColor = System.Drawing.Color.Black;
            this.iconMenuProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProducts.IconSize = 60;
            this.iconMenuProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuProducts.Name = "iconMenuProducts";
            this.iconMenuProducts.Size = new System.Drawing.Size(125, 101);
            this.iconMenuProducts.Text = "Productos";
            this.iconMenuProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuProducts.Click += new System.EventHandler(this.iconMenuProducts_Click);
            // 
            // iconMenuSales
            // 
            this.iconMenuSales.AutoSize = false;
            this.iconMenuSales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuSales.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconMenuSales.IconColor = System.Drawing.Color.Black;
            this.iconMenuSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuSales.IconSize = 60;
            this.iconMenuSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuSales.Name = "iconMenuSales";
            this.iconMenuSales.Size = new System.Drawing.Size(125, 101);
            this.iconMenuSales.Text = "Ventas";
            this.iconMenuSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuSales.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // iconMenuCustomers
            // 
            this.iconMenuCustomers.AutoSize = false;
            this.iconMenuCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuCustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconMenuCustomers.IconColor = System.Drawing.Color.Black;
            this.iconMenuCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuCustomers.IconSize = 60;
            this.iconMenuCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuCustomers.Name = "iconMenuCustomers";
            this.iconMenuCustomers.Size = new System.Drawing.Size(125, 101);
            this.iconMenuCustomers.Text = "Clientes";
            this.iconMenuCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuCustomers.Click += new System.EventHandler(this.iconCustomers_Click);
            // 
            // iconMenuLogout
            // 
            this.iconMenuLogout.AutoSize = false;
            this.iconMenuLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuLogout.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconMenuLogout.IconColor = System.Drawing.Color.Black;
            this.iconMenuLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuLogout.IconSize = 60;
            this.iconMenuLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuLogout.Name = "iconMenuLogout";
            this.iconMenuLogout.Size = new System.Drawing.Size(125, 101);
            this.iconMenuLogout.Text = "Cerrar sesión";
            this.iconMenuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuLogout.Click += new System.EventHandler(this.iconMenuItem7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "JBPos";
            // 
            // lblClock
            // 
            this.lblClock.AutoEllipsis = true;
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClock.Location = new System.Drawing.Point(1631, 18);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(147, 54);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(1572, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 810);
            this.panel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuario.Location = new System.Drawing.Point(1572, 148);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(95, 25);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario : ";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1572, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sistema de ventas";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "JBPos";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuUsers;
        private FontAwesome.Sharp.IconMenuItem iconMenuSales;
        private FontAwesome.Sharp.IconMenuItem iconMenuProducts;
        private FontAwesome.Sharp.IconMenuItem iconMenuLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconMenuItem iconMenuCustomers;
        public FontAwesome.Sharp.IconMenuItem iconCuadroVenta;
        public System.Windows.Forms.MenuStrip menuStrip2;
    }
}