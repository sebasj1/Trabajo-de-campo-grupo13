namespace Positivee.Presentacion
{
    partial class Seccion_ventas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.delCustomer = new FontAwesome.Sharp.IconButton();
            this.btList = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsers.Location = new System.Drawing.Point(334, 0);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1460, 754);
            this.panelUsers.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.delCustomer);
            this.panel2.Controls.Add(this.btList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 754);
            this.panel2.TabIndex = 10;
            // 
            // delCustomer
            // 
            this.delCustomer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delCustomer.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.delCustomer.IconColor = System.Drawing.Color.Black;
            this.delCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delCustomer.IconSize = 40;
            this.delCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delCustomer.Location = new System.Drawing.Point(57, 150);
            this.delCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(226, 61);
            this.delCustomer.TabIndex = 7;
            this.delCustomer.Text = "Anular venta";
            this.delCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delCustomer.UseVisualStyleBackColor = false;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // btList
            // 
            this.btList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btList.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btList.IconColor = System.Drawing.Color.Black;
            this.btList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btList.IconSize = 40;
            this.btList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btList.Location = new System.Drawing.Point(57, 69);
            this.btList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(226, 61);
            this.btList.TabIndex = 4;
            this.btList.Text = "Lista ventas  ";
            this.btList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btList.UseVisualStyleBackColor = false;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // Seccion_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 754);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panel2);
            this.Name = "Seccion_ventas";
            this.Text = "Seccion_ventas";
            this.Load += new System.EventHandler(this.Seccion_ventas_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton delCustomer;
        private FontAwesome.Sharp.IconButton btList;
    }
}