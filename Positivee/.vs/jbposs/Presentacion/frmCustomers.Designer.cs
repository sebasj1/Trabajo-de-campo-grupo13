namespace jbposs.Presentacion
{
    partial class frmCustomers
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
            this.btlistCustomer = new FontAwesome.Sharp.IconButton();
            this.restCustomer = new FontAwesome.Sharp.IconButton();
            this.delCustomer = new FontAwesome.Sharp.IconButton();
            this.btEditCustomer = new FontAwesome.Sharp.IconButton();
            this.btaddCustomer = new FontAwesome.Sharp.IconButton();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btlistCustomer
            // 
            this.btlistCustomer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btlistCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlistCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btlistCustomer.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btlistCustomer.IconColor = System.Drawing.Color.Black;
            this.btlistCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btlistCustomer.IconSize = 40;
            this.btlistCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlistCustomer.Location = new System.Drawing.Point(51, 120);
            this.btlistCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btlistCustomer.Name = "btlistCustomer";
            this.btlistCustomer.Size = new System.Drawing.Size(201, 49);
            this.btlistCustomer.TabIndex = 9;
            this.btlistCustomer.Text = "Lista cliente        ";
            this.btlistCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlistCustomer.UseVisualStyleBackColor = false;
            this.btlistCustomer.Click += new System.EventHandler(this.listUser_Click);
            // 
            // restCustomer
            // 
            this.restCustomer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.restCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.restCustomer.IconChar = FontAwesome.Sharp.IconChar.LevelUpAlt;
            this.restCustomer.IconColor = System.Drawing.Color.Black;
            this.restCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.restCustomer.IconSize = 40;
            this.restCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restCustomer.Location = new System.Drawing.Point(51, 322);
            this.restCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restCustomer.Name = "restCustomer";
            this.restCustomer.Size = new System.Drawing.Size(201, 49);
            this.restCustomer.TabIndex = 8;
            this.restCustomer.Text = "Restaurar cliente";
            this.restCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restCustomer.UseVisualStyleBackColor = false;
            this.restCustomer.Click += new System.EventHandler(this.restCustomer_Click);
            // 
            // delCustomer
            // 
            this.delCustomer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.delCustomer.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.delCustomer.IconColor = System.Drawing.Color.Black;
            this.delCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delCustomer.IconSize = 40;
            this.delCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delCustomer.Location = new System.Drawing.Point(51, 257);
            this.delCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(201, 49);
            this.delCustomer.TabIndex = 7;
            this.delCustomer.Text = "Eliminar cliente  ";
            this.delCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delCustomer.UseVisualStyleBackColor = false;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btEditCustomer.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btEditCustomer.IconColor = System.Drawing.Color.Black;
            this.btEditCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEditCustomer.IconSize = 40;
            this.btEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditCustomer.Location = new System.Drawing.Point(51, 190);
            this.btEditCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(201, 49);
            this.btEditCustomer.TabIndex = 5;
            this.btEditCustomer.Text = "Editar cliente      ";
            this.btEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditCustomer.UseVisualStyleBackColor = false;
            this.btEditCustomer.Click += new System.EventHandler(this.btEditUser_Click);
            // 
            // btaddCustomer
            // 
            this.btaddCustomer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btaddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btaddCustomer.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btaddCustomer.IconColor = System.Drawing.Color.Black;
            this.btaddCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btaddCustomer.IconSize = 40;
            this.btaddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaddCustomer.Location = new System.Drawing.Point(51, 55);
            this.btaddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btaddCustomer.Name = "btaddCustomer";
            this.btaddCustomer.Size = new System.Drawing.Size(201, 49);
            this.btaddCustomer.TabIndex = 4;
            this.btaddCustomer.Text = "Agregar cliente   ";
            this.btaddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btaddCustomer.UseVisualStyleBackColor = false;
            this.btaddCustomer.Click += new System.EventHandler(this.addUser_Click_1);
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsers.Location = new System.Drawing.Point(297, 0);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(773, 603);
            this.panelUsers.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btlistCustomer);
            this.panel2.Controls.Add(this.restCustomer);
            this.panel2.Controls.Add(this.delCustomer);
            this.panel2.Controls.Add(this.btEditCustomer);
            this.panel2.Controls.Add(this.btaddCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 603);
            this.panel2.TabIndex = 6;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 603);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btlistCustomer;
        private FontAwesome.Sharp.IconButton restCustomer;
        private FontAwesome.Sharp.IconButton delCustomer;
        public FontAwesome.Sharp.IconButton btEditCustomer;
        private FontAwesome.Sharp.IconButton btaddCustomer;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panel2;
    }
}