namespace jbposs.Presentacion
{
    partial class editUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.back = new FontAwesome.Sharp.IconButton();
            this.gBEditUs2 = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBEditUs = new System.Windows.Forms.GroupBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btGuardar = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gBEditUs2.SuspendLayout();
            this.gBEditUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gbEstado);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.gBEditUs2);
            this.panel1.Controls.Add(this.gBEditUs);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.btGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 635);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Location = new System.Drawing.Point(798, 384);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstado.Size = new System.Drawing.Size(240, 121);
            this.gbEstado.TabIndex = 52;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.Location = new System.Drawing.Point(56, 72);
            this.rbInactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(150, 33);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVO";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.ForeColor = System.Drawing.Color.Black;
            this.rbActivo.Location = new System.Drawing.Point(56, 31);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(126, 33);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVO";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.back.IconColor = System.Drawing.Color.White;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(17, 14);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(200, 54);
            this.back.TabIndex = 51;
            this.back.Text = "Volver atras";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = false;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // gBEditUs2
            // 
            this.gBEditUs2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBEditUs2.Controls.Add(this.tbPass);
            this.gBEditUs2.Controls.Add(this.label5);
            this.gBEditUs2.Controls.Add(this.tbUser);
            this.gBEditUs2.Controls.Add(this.label6);
            this.gBEditUs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBEditUs2.Location = new System.Drawing.Point(76, 372);
            this.gBEditUs2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBEditUs2.Name = "gBEditUs2";
            this.gBEditUs2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBEditUs2.Size = new System.Drawing.Size(575, 132);
            this.gBEditUs2.TabIndex = 50;
            this.gBEditUs2.TabStop = false;
            this.gBEditUs2.Text = "Datos Usuario";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPass.Location = new System.Drawing.Point(166, 86);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(360, 35);
            this.tbPass.TabIndex = 28;
            this.tbPass.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Contraseña:";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbUser.Location = new System.Drawing.Point(129, 44);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(396, 35);
            this.tbUser.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Usuario:";
            // 
            // gBEditUs
            // 
            this.gBEditUs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBEditUs.Controls.Add(this.cbRol);
            this.gBEditUs.Controls.Add(this.label9);
            this.gBEditUs.Controls.Add(this.tbDNI);
            this.gBEditUs.Controls.Add(this.label7);
            this.gBEditUs.Controls.Add(this.cbProv);
            this.gBEditUs.Controls.Add(this.label3);
            this.gBEditUs.Controls.Add(this.tbTel);
            this.gBEditUs.Controls.Add(this.label4);
            this.gBEditUs.Controls.Add(this.tbAdress);
            this.gBEditUs.Controls.Add(this.label2);
            this.gBEditUs.Controls.Add(this.tbEmail);
            this.gBEditUs.Controls.Add(this.label1);
            this.gBEditUs.Controls.Add(this.textboxApellido);
            this.gBEditUs.Controls.Add(this.TBApellido);
            this.gBEditUs.Controls.Add(this.TBNombre);
            this.gBEditUs.Controls.Add(this.LApellido);
            this.gBEditUs.Controls.Add(this.LNombre);
            this.gBEditUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gBEditUs.ForeColor = System.Drawing.Color.Black;
            this.gBEditUs.Location = new System.Drawing.Point(76, 129);
            this.gBEditUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBEditUs.Name = "gBEditUs";
            this.gBEditUs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBEditUs.Size = new System.Drawing.Size(1154, 230);
            this.gBEditUs.TabIndex = 49;
            this.gBEditUs.TabStop = false;
            this.gBEditUs.Text = "Datos personales";
            // 
            // cbRol
            // 
            this.cbRol.DisplayMember = "descripcion";
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(544, 178);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(249, 40);
            this.cbRol.TabIndex = 34;
            this.cbRol.ValueMember = "descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(479, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Rol:";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDNI.Location = new System.Drawing.Point(94, 92);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.ReadOnly = true;
            this.tbDNI.Size = new System.Drawing.Size(365, 35);
            this.tbDNI.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "DNI:";
            // 
            // cbProv
            // 
            this.cbProv.DisplayMember = "nombre";
            this.cbProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(597, 132);
            this.cbProv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(196, 40);
            this.cbProv.TabIndex = 29;
            this.cbProv.ValueMember = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(477, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Provincia:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTel.Location = new System.Drawing.Point(146, 178);
            this.tbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(313, 35);
            this.tbTel.TabIndex = 22;
            this.tbTel.Validating += new System.ComponentModel.CancelEventHandler(this.tbTel_Validating);
            this.tbTel.Validated += new System.EventHandler(this.tbTel_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono:";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAdress.Location = new System.Drawing.Point(597, 92);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(514, 35);
            this.tbAdress.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(477, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Domicilio:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(112, 135);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(346, 35);
            this.tbEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // textboxApellido
            // 
            this.textboxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxApellido.Location = new System.Drawing.Point(714, 50);
            this.textboxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(397, 35);
            this.textboxApellido.TabIndex = 7;
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.Location = new System.Drawing.Point(721, 50);
            this.TBApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(379, 32);
            this.TBApellido.TabIndex = 7;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBNombre.Location = new System.Drawing.Point(129, 50);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(446, 35);
            this.TBNombre.TabIndex = 6;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(604, 50);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(108, 29);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.Black;
            this.LNombre.Location = new System.Drawing.Point(24, 52);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(107, 29);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(623, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 37);
            this.label8.TabIndex = 39;
            this.label8.Text = "Editar usuario";
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
            this.btClean.Location = new System.Drawing.Point(298, 548);
            this.btClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(200, 54);
            this.btClean.TabIndex = 38;
            this.btClean.Text = "Limpiar";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click_1);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btGuardar.IconColor = System.Drawing.Color.White;
            this.btGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(74, 548);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(200, 54);
            this.btGuardar.TabIndex = 35;
            this.btGuardar.Text = "Guardar    ";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 635);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editUser";
            this.Text = "editUser";
            this.Load += new System.EventHandler(this.editUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gBEditUs2.ResumeLayout(false);
            this.gBEditUs2.PerformLayout();
            this.gBEditUs.ResumeLayout(false);
            this.gBEditUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private FontAwesome.Sharp.IconButton back;
        private System.Windows.Forms.GroupBox gBEditUs2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gBEditUs;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btClean;
        private FontAwesome.Sharp.IconButton btGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}