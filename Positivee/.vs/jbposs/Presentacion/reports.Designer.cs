namespace jbposs.Presentacion
{
    partial class reports
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
            this.panelReports = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRP = new FontAwesome.Sharp.IconButton();
            this.btRU = new FontAwesome.Sharp.IconButton();
            this.btRC = new FontAwesome.Sharp.IconButton();
            this.btRS = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReports
            // 
            this.panelReports.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReports.Location = new System.Drawing.Point(297, 0);
            this.panelReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(773, 603);
            this.panelReports.TabIndex = 9;
            this.panelReports.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReports_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btRP);
            this.panel2.Controls.Add(this.btRU);
            this.panel2.Controls.Add(this.btRC);
            this.panel2.Controls.Add(this.btRS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 603);
            this.panel2.TabIndex = 8;
            // 
            // btRP
            // 
            this.btRP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRP.IconColor = System.Drawing.Color.Black;
            this.btRP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRP.IconSize = 40;
            this.btRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRP.Location = new System.Drawing.Point(12, 259);
            this.btRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRP.Name = "btRP";
            this.btRP.Size = new System.Drawing.Size(227, 49);
            this.btRP.TabIndex = 10;
            this.btRP.Text = "Productos populares";
            this.btRP.UseVisualStyleBackColor = false;
            this.btRP.Click += new System.EventHandler(this.btRP_Click);
            // 
            // btRU
            // 
            this.btRU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRU.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRU.IconColor = System.Drawing.Color.Black;
            this.btRU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRU.IconSize = 40;
            this.btRU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRU.Location = new System.Drawing.Point(12, 120);
            this.btRU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRU.Name = "btRU";
            this.btRU.Size = new System.Drawing.Size(227, 49);
            this.btRU.TabIndex = 9;
            this.btRU.Text = "Recaudacion diaria";
            this.btRU.UseVisualStyleBackColor = false;
            this.btRU.Click += new System.EventHandler(this.btRU_Click);
            // 
            // btRC
            // 
            this.btRC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRC.IconColor = System.Drawing.Color.Black;
            this.btRC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRC.IconSize = 40;
            this.btRC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRC.Location = new System.Drawing.Point(12, 189);
            this.btRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRC.Name = "btRC";
            this.btRC.Size = new System.Drawing.Size(227, 49);
            this.btRC.TabIndex = 5;
            this.btRC.Text = "Ventas por cliente";
            this.btRC.UseVisualStyleBackColor = false;
            this.btRC.Click += new System.EventHandler(this.btRC_Click);
            // 
            // btRS
            // 
            this.btRS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btRS.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRS.IconColor = System.Drawing.Color.Black;
            this.btRS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRS.IconSize = 40;
            this.btRS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRS.Location = new System.Drawing.Point(12, 55);
            this.btRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRS.Name = "btRS";
            this.btRS.Size = new System.Drawing.Size(227, 49);
            this.btRS.TabIndex = 4;
            this.btRS.Text = "Productos vendidos";
            this.btRS.UseVisualStyleBackColor = false;
            this.btRS.Click += new System.EventHandler(this.btRS_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 603);
            this.Controls.Add(this.panelReports);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reports";
            this.Text = "Reportes";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btRU;
        public FontAwesome.Sharp.IconButton btRC;
        private FontAwesome.Sharp.IconButton btRS;
        public FontAwesome.Sharp.IconButton btRP;
    }
}