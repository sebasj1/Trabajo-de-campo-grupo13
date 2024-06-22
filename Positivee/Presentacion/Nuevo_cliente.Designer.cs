namespace Positive.Presentacion
{
    partial class Nuevo_cliente
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btAddCust = new FontAwesome.Sharp.IconButton();
            this.gbCust = new System.Windows.Forms.GroupBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(1310, 635);
            this.panelAddUser.TabIndex = 4;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.cbStatus);
            this.gbEstado.Location = new System.Drawing.Point(76, 375);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEstado.Size = new System.Drawing.Size(257, 122);
            this.gbEstado.TabIndex = 53;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "nombre";
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(29, 47);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(196, 40);
            this.cbStatus.TabIndex = 32;
            this.cbStatus.ValueMember = "nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(514, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 37);
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
            this.btClean.Location = new System.Drawing.Point(298, 548);
            this.btClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(200, 54);
            this.btClean.TabIndex = 51;
            this.btClean.Text = "Limpiar        ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
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
            this.btAddCust.Location = new System.Drawing.Point(74, 548);
            this.btAddCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddCust.Name = "btAddCust";
            this.btAddCust.Size = new System.Drawing.Size(200, 54);
            this.btAddCust.TabIndex = 49;
            this.btAddCust.Text = "Agregar        ";
            this.btAddCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddCust.UseVisualStyleBackColor = false;
            this.btAddCust.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // gbCust
            // 
            this.gbCust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCust.Controls.Add(this.tbDNI);
            this.gbCust.Controls.Add(this.label7);
            this.gbCust.Controls.Add(this.cbTDoc);
            this.gbCust.Controls.Add(this.label3);
            this.gbCust.Controls.Add(this.tbTel);
            this.gbCust.Controls.Add(this.textboxApellido);
            this.gbCust.Controls.Add(this.label4);
            this.gbCust.Controls.Add(this.TBApellido);
            this.gbCust.Controls.Add(this.TBNombre);
            this.gbCust.Controls.Add(this.tbEmail);
            this.gbCust.Controls.Add(this.label1);
            this.gbCust.Controls.Add(this.LApellido);
            this.gbCust.Controls.Add(this.LNombre);
            this.gbCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbCust.ForeColor = System.Drawing.Color.Black;
            this.gbCust.Location = new System.Drawing.Point(76, 129);
            this.gbCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCust.Name = "gbCust";
            this.gbCust.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCust.Size = new System.Drawing.Size(1154, 231);
            this.gbCust.TabIndex = 47;
            this.gbCust.TabStop = false;
            this.gbCust.Text = "Datos personales";
            // 
            // tbDNI
            // 
            this.tbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDNI.Location = new System.Drawing.Point(129, 110);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(366, 35);
            this.tbDNI.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "DNI:";
            // 
            // cbTDoc
            // 
            this.cbTDoc.DisplayMember = "nombre";
            this.cbTDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbTDoc.FormattingEnabled = true;
            this.cbTDoc.Location = new System.Drawing.Point(226, 181);
            this.cbTDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTDoc.Name = "cbTDoc";
            this.cbTDoc.Size = new System.Drawing.Size(196, 40);
            this.cbTDoc.TabIndex = 29;
            this.cbTDoc.ValueMember = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tipo documento:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTel.Location = new System.Drawing.Point(702, 175);
            this.tbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(313, 35);
            this.tbTel.TabIndex = 22;
            // 
            // textboxApellido
            // 
            this.textboxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxApellido.Location = new System.Drawing.Point(692, 49);
            this.textboxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(420, 35);
            this.textboxApellido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(580, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono:";
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
            this.TBNombre.Size = new System.Drawing.Size(418, 35);
            this.TBNombre.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(669, 113);
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
            this.label1.Location = new System.Drawing.Point(584, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(578, 49);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Nuevo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 635);
            this.Controls.Add(this.panelAddUser);
            this.Name = "Nuevo_cliente";
            this.Text = "Nuevo_cliente";
            this.Load += new System.EventHandler(this.Nuevo_cliente_Load);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbCust.ResumeLayout(false);
            this.gbCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btClean;
        private FontAwesome.Sharp.IconButton btAddCust;
        private System.Windows.Forms.GroupBox gbCust;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}