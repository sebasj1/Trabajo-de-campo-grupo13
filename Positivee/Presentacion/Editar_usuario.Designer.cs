﻿namespace Positive.Presentacion
{
    partial class Editar_usuario
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
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btEdUser = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.panelAddUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddUser
            // 
            this.panelAddUser.BackColor = System.Drawing.Color.White;
            this.panelAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddUser.Controls.Add(this.label8);
            this.panelAddUser.Controls.Add(this.btClean);
            this.panelAddUser.Controls.Add(this.btEdUser);
            this.panelAddUser.Controls.Add(this.groupBox2);
            this.panelAddUser.Controls.Add(this.groupBox1);
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelAddUser.ForeColor = System.Drawing.Color.White;
            this.panelAddUser.Location = new System.Drawing.Point(0, 0);
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(1310, 698);
            this.panelAddUser.TabIndex = 3;
            this.panelAddUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddUser_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(514, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 37);
            this.label8.TabIndex = 52;
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
            this.btClean.Location = new System.Drawing.Point(304, 613);
            this.btClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(200, 54);
            this.btClean.TabIndex = 51;
            this.btClean.Text = "Limpiar        ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btEdUser
            // 
            this.btEdUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btEdUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdUser.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btEdUser.IconColor = System.Drawing.Color.White;
            this.btEdUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEdUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdUser.Location = new System.Drawing.Point(80, 613);
            this.btEdUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdUser.Name = "btEdUser";
            this.btEdUser.Size = new System.Drawing.Size(200, 54);
            this.btEdUser.TabIndex = 49;
            this.btEdUser.Text = "   Guardar        ";
            this.btEdUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdUser.UseVisualStyleBackColor = false;
            this.btEdUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbRol);
            this.groupBox2.Controls.Add(this.tbUser);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(76, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1129, 188);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(641, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Estado:";
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "descripcion";
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(750, 119);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(228, 40);
            this.cbStatus.TabIndex = 37;
            this.cbStatus.ValueMember = "descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(641, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Rol:";
            // 
            // cbRol
            // 
            this.cbRol.DisplayMember = "descripcion";
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbRol.Location = new System.Drawing.Point(714, 39);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(352, 40);
            this.cbRol.TabIndex = 34;
            this.cbRol.ValueMember = "descripcion";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbUser.Location = new System.Drawing.Point(172, 45);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(352, 35);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.cbTDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.textboxApellido);
            this.groupBox1.Controls.Add(this.TBApellido);
            this.groupBox1.Controls.Add(this.TBNombre);
            this.groupBox1.Controls.Add(this.LApellido);
            this.groupBox1.Controls.Add(this.LNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(76, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1154, 231);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // cbTDoc
            // 
            this.cbTDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbTDoc.FormattingEnabled = true;
            this.cbTDoc.Location = new System.Drawing.Point(146, 173);
            this.cbTDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTDoc.Name = "cbTDoc";
            this.cbTDoc.Size = new System.Drawing.Size(212, 40);
            this.cbTDoc.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo doc:";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDNI.Location = new System.Drawing.Point(129, 106);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.ReadOnly = true;
            this.tbDNI.Size = new System.Drawing.Size(383, 35);
            this.tbDNI.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(589, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "DNI:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTel.Location = new System.Drawing.Point(714, 173);
            this.tbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(397, 35);
            this.tbTel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(589, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(714, 109);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(397, 35);
            this.tbEmail.TabIndex = 18;
            // 
            // textboxApellido
            // 
            this.textboxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxApellido.Location = new System.Drawing.Point(714, 49);
            this.textboxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(397, 35);
            this.textboxApellido.TabIndex = 7;
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.Location = new System.Drawing.Point(722, 49);
            this.TBApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(379, 32);
            this.TBApellido.TabIndex = 7;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBNombre.Location = new System.Drawing.Point(129, 49);
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
            this.LApellido.Location = new System.Drawing.Point(589, 55);
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
            // Editar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 698);
            this.Controls.Add(this.panelAddUser);
            this.Name = "Editar_usuario";
            this.Text = "editar_usuario";
            this.Load += new System.EventHandler(this.editar_usuario_Load);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btClean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private FontAwesome.Sharp.IconButton btEdUser;
    }
}