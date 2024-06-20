namespace Positivee.Presentacion
{
    partial class Editar_producto
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
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btAddProd = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrecV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbCodeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPriceProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStockProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitleProd = new System.Windows.Forms.TextBox();
            this.tbDescProd = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.btAddProd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 635);
            this.panel1.TabIndex = 63;
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClean.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btClean.IconColor = System.Drawing.Color.White;
            this.btClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClean.Location = new System.Drawing.Point(289, 489);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(201, 54);
            this.btClean.TabIndex = 66;
            this.btClean.Text = "Limpiar        ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            // 
            // btAddProd
            // 
            this.btAddProd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddProd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btAddProd.IconColor = System.Drawing.Color.White;
            this.btAddProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddProd.Location = new System.Drawing.Point(60, 489);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(201, 54);
            this.btAddProd.TabIndex = 64;
            this.btAddProd.Text = "Guardar      ";
            this.btAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddProd.UseVisualStyleBackColor = false;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.tbPrecV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.tbCodeProd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPriceProd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbCategorie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbStockProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTitleProd);
            this.groupBox1.Controls.Add(this.tbDescProd);
            this.groupBox1.Controls.Add(this.LApellido);
            this.groupBox1.Controls.Add(this.LNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 317);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // tbPrecV
            // 
            this.tbPrecV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecV.Location = new System.Drawing.Point(834, 169);
            this.tbPrecV.Name = "tbPrecV";
            this.tbPrecV.Size = new System.Drawing.Size(406, 35);
            this.tbPrecV.TabIndex = 42;
            this.tbPrecV.Validating += new System.ComponentModel.CancelEventHandler(this.tbPriceProd_Validating);
            this.tbPrecV.Validated += new System.EventHandler(this.tbPriceProd_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(639, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Precio venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(725, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Estado:";
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "descripcion";
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(834, 251);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(228, 40);
            this.cbStatus.TabIndex = 39;
            this.cbStatus.ValueMember = "descripcion";
            // 
            // tbCodeProd
            // 
            this.tbCodeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeProd.Location = new System.Drawing.Point(730, 52);
            this.tbCodeProd.Name = "tbCodeProd";
            this.tbCodeProd.ReadOnly = true;
            this.tbCodeProd.Size = new System.Drawing.Size(398, 35);
            this.tbCodeProd.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(640, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Codigo:";
            // 
            // tbPriceProd
            // 
            this.tbPriceProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceProd.Location = new System.Drawing.Point(834, 109);
            this.tbPriceProd.Name = "tbPriceProd";
            this.tbPriceProd.Size = new System.Drawing.Size(406, 35);
            this.tbPriceProd.TabIndex = 36;
            this.tbPriceProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbPriceProd_Validating);
            this.tbPriceProd.Validated += new System.EventHandler(this.tbPriceProd_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(639, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio compra:";
            // 
            // cbCategorie
            // 
            this.cbCategorie.DisplayMember = "nombre";
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(150, 257);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(468, 37);
            this.cbCategorie.TabIndex = 29;
            this.cbCategorie.ValueMember = "id_categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Categoria:";
            // 
            // tbStockProd
            // 
            this.tbStockProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockProd.Location = new System.Drawing.Point(116, 208);
            this.tbStockProd.Name = "tbStockProd";
            this.tbStockProd.Size = new System.Drawing.Size(360, 35);
            this.tbStockProd.TabIndex = 18;
            this.tbStockProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbStockProd_Validating);
            this.tbStockProd.Validated += new System.EventHandler(this.tbStockProd_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stock:";
            // 
            // tbTitleProd
            // 
            this.tbTitleProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitleProd.Location = new System.Drawing.Point(116, 48);
            this.tbTitleProd.Name = "tbTitleProd";
            this.tbTitleProd.Size = new System.Drawing.Size(424, 35);
            this.tbTitleProd.TabIndex = 7;
            this.tbTitleProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitleProd_Validating);
            this.tbTitleProd.Validated += new System.EventHandler(this.tbTitleProd_Validated);
            // 
            // tbDescProd
            // 
            this.tbDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescProd.Location = new System.Drawing.Point(150, 97);
            this.tbDescProd.Multiline = true;
            this.tbDescProd.Name = "tbDescProd";
            this.tbDescProd.Size = new System.Drawing.Size(436, 90);
            this.tbDescProd.TabIndex = 6;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(21, 51);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(80, 29);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Titulo:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LNombre.ForeColor = System.Drawing.Color.Black;
            this.LNombre.Location = new System.Drawing.Point(14, 102);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(147, 29);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(476, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 37);
            this.label8.TabIndex = 62;
            this.label8.Text = "Registrar Nuevo producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // editar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 635);
            this.Controls.Add(this.panel1);
            this.Name = "editar_producto";
            this.Text = "editar_producto";
            this.Load += new System.EventHandler(this.editar_producto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btClean;
        private FontAwesome.Sharp.IconButton btAddProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPrecV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbCodeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPriceProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStockProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitleProd;
        private System.Windows.Forms.TextBox tbDescProd;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}