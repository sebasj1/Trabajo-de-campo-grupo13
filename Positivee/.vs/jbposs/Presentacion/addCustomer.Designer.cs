namespace jbposs.Presentacion
{
    partial class addCustomer
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
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btAddCust = new FontAwesome.Sharp.IconButton();
            this.gbCust = new System.Windows.Forms.GroupBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAddUser.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddUser
            // 
            this.panelAddUser.BackColor = System.Drawing.Color.White;
            this.panelAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddUser.Controls.Add(this.gbEstado);
            this.panelAddUser.Controls.Add(this.label8);
            this.panelAddUser.Controls.Add(this.btClean);
            this.panelAddUser.Controls.Add(this.btAddCust);
            this.panelAddUser.Controls.Add(this.gbCust);
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelAddUser.ForeColor = System.Drawing.Color.White;
            this.panelAddUser.Location = new System.Drawing.Point(0, 0);
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(873, 413);
            this.panelAddUser.TabIndex = 3;
            this.panelAddUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddUser_Paint);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Location = new System.Drawing.Point(51, 244);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbEstado.Size = new System.Drawing.Size(160, 79);
            this.gbEstado.TabIndex = 53;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.Location = new System.Drawing.Point(37, 47);
            this.rbInactivo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(102, 24);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVO";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.ForeColor = System.Drawing.Color.Black;
            this.rbActivo.Location = new System.Drawing.Point(37, 20);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(86, 24);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVO";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(343, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 26);
            this.label8.TabIndex = 52;
            this.label8.Text = "Agregar cliente";
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClean.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btClean.IconColor = System.Drawing.Color.White;
            this.btClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClean.Location = new System.Drawing.Point(199, 356);
            this.btClean.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(133, 35);
            this.btClean.TabIndex = 51;
            this.btClean.Text = "Limpiar        ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            this.btClean.MouseLeave += new System.EventHandler(this.btClean_MouseLeave);
            this.btClean.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btClean_MouseMove);
            // 
            // btAddCust
            // 
            this.btAddCust.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCust.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btAddCust.IconColor = System.Drawing.Color.White;
            this.btAddCust.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAddCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddCust.Location = new System.Drawing.Point(49, 356);
            this.btAddCust.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btAddCust.Name = "btAddCust";
            this.btAddCust.Size = new System.Drawing.Size(133, 35);
            this.btAddCust.TabIndex = 49;
            this.btAddCust.Text = "Agregar        ";
            this.btAddCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddCust.UseVisualStyleBackColor = false;
            this.btAddCust.Click += new System.EventHandler(this.btAddUser_Click);
            this.btAddCust.MouseLeave += new System.EventHandler(this.btAdd_MouseLeave);
            this.btAddCust.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAdd_MouseMove);
            // 
            // gbCust
            // 
            this.gbCust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCust.Controls.Add(this.tbDNI);
            this.gbCust.Controls.Add(this.label7);
            this.gbCust.Controls.Add(this.cbProv);
            this.gbCust.Controls.Add(this.label3);
            this.gbCust.Controls.Add(this.tbTel);
            this.gbCust.Controls.Add(this.label4);
            this.gbCust.Controls.Add(this.tbAdress);
            this.gbCust.Controls.Add(this.label2);
            this.gbCust.Controls.Add(this.tbEmail);
            this.gbCust.Controls.Add(this.label1);
            this.gbCust.Controls.Add(this.textboxApellido);
            this.gbCust.Controls.Add(this.TBApellido);
            this.gbCust.Controls.Add(this.TBNombre);
            this.gbCust.Controls.Add(this.LApellido);
            this.gbCust.Controls.Add(this.LNombre);
            this.gbCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbCust.ForeColor = System.Drawing.Color.Black;
            this.gbCust.Location = new System.Drawing.Point(51, 84);
            this.gbCust.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbCust.Name = "gbCust";
            this.gbCust.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbCust.Size = new System.Drawing.Size(769, 150);
            this.gbCust.TabIndex = 47;
            this.gbCust.TabStop = false;
            this.gbCust.Text = "Datos personales";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDNI.Location = new System.Drawing.Point(63, 60);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(245, 26);
            this.tbDNI.TabIndex = 31;
            this.tbDNI.Validating += new System.ComponentModel.CancelEventHandler(this.tbDNI_Validating);
            this.tbDNI.Validated += new System.EventHandler(this.tbDNI_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "DNI:";
            // 
            // cbProv
            // 
            this.cbProv.DisplayMember = "nombre";
            this.cbProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(398, 86);
            this.cbProv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(132, 32);
            this.cbProv.TabIndex = 29;
            this.cbProv.ValueMember = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(318, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Provincia:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTel.Location = new System.Drawing.Point(97, 116);
            this.tbTel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(210, 26);
            this.tbTel.TabIndex = 22;
            this.tbTel.Validating += new System.ComponentModel.CancelEventHandler(this.tbTel_Validating);
            this.tbTel.Validated += new System.EventHandler(this.tbTel_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono:";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAdress.Location = new System.Drawing.Point(398, 60);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(344, 26);
            this.tbAdress.TabIndex = 20;
            this.tbAdress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdress_Validating);
            this.tbAdress.Validated += new System.EventHandler(this.tbAdress_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(318, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Domicilio:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(75, 88);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 26);
            this.tbEmail.TabIndex = 18;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // textboxApellido
            // 
            this.textboxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxApellido.Location = new System.Drawing.Point(461, 32);
            this.textboxApellido.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(281, 26);
            this.textboxApellido.TabIndex = 7;
            this.textboxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textboxApellido_Validating);
            this.textboxApellido.Validated += new System.EventHandler(this.textboxApellido_Validated);
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.Location = new System.Drawing.Point(481, 32);
            this.TBApellido.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(254, 24);
            this.TBApellido.TabIndex = 7;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBNombre.Location = new System.Drawing.Point(86, 32);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(280, 26);
            this.TBNombre.TabIndex = 6;
            this.TBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombre_Validating);
            this.TBNombre.Validated += new System.EventHandler(this.TBNombre_Validated);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(385, 32);
            this.LApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(69, 20);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.Black;
            this.LNombre.Location = new System.Drawing.Point(16, 34);
            this.LNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(69, 20);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 413);
            this.Controls.Add(this.panelAddUser);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "addCustomer";
            this.Text = "addCustomer";
            this.Load += new System.EventHandler(this.addCustomer_Load);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gbCust.ResumeLayout(false);
            this.gbCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btClean;
        private FontAwesome.Sharp.IconButton btAddCust;
        private System.Windows.Forms.GroupBox gbCust;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}