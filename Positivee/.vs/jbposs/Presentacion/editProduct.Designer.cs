namespace jbposs.Presentacion
{
    partial class editProduct
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
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btBack = new FontAwesome.Sharp.IconButton();
            this.gbEdProd = new System.Windows.Forms.GroupBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
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
            this.btOk = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbEdProd.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClean.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btClean.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClean.Location = new System.Drawing.Point(299, 450);
            this.btClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(200, 54);
            this.btClean.TabIndex = 61;
            this.btClean.Text = "Limpiar        ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.MouseLeave += new System.EventHandler(this.btClean_MouseLeave);
            this.btClean.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btClean_MouseMove);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btBack.IconColor = System.Drawing.Color.White;
            this.btBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(12, 13);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(200, 54);
            this.btBack.TabIndex = 59;
            this.btBack.Text = "Volver Atras  ";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            this.btBack.MouseLeave += new System.EventHandler(this.btBack_MouseLeave);
            this.btBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btBack_MouseMove);
            // 
            // gbEdProd
            // 
            this.gbEdProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbEdProd.Controls.Add(this.gbEstado);
            this.gbEdProd.Controls.Add(this.tbCodeProd);
            this.gbEdProd.Controls.Add(this.label2);
            this.gbEdProd.Controls.Add(this.tbPriceProd);
            this.gbEdProd.Controls.Add(this.label7);
            this.gbEdProd.Controls.Add(this.cbCategorie);
            this.gbEdProd.Controls.Add(this.label3);
            this.gbEdProd.Controls.Add(this.tbStockProd);
            this.gbEdProd.Controls.Add(this.label1);
            this.gbEdProd.Controls.Add(this.tbTitleProd);
            this.gbEdProd.Controls.Add(this.tbDescProd);
            this.gbEdProd.Controls.Add(this.LApellido);
            this.gbEdProd.Controls.Add(this.LNombre);
            this.gbEdProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbEdProd.ForeColor = System.Drawing.Color.Black;
            this.gbEdProd.Location = new System.Drawing.Point(66, 106);
            this.gbEdProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEdProd.Name = "gbEdProd";
            this.gbEdProd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEdProd.Size = new System.Drawing.Size(1158, 318);
            this.gbEdProd.TabIndex = 57;
            this.gbEdProd.TabStop = false;
            this.gbEdProd.Text = "Datos del producto";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Location = new System.Drawing.Point(753, 174);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(240, 121);
            this.gbEstado.TabIndex = 53;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.ForeColor = System.Drawing.Color.Black;
            this.rbInactivo.Location = new System.Drawing.Point(56, 73);
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
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(126, 33);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVO";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // tbCodeProd
            // 
            this.tbCodeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeProd.Location = new System.Drawing.Point(730, 53);
            this.tbCodeProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodeProd.Name = "tbCodeProd";
            this.tbCodeProd.ReadOnly = true;
            this.tbCodeProd.Size = new System.Drawing.Size(399, 35);
            this.tbCodeProd.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(640, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Código:";
            // 
            // tbPriceProd
            // 
            this.tbPriceProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceProd.Location = new System.Drawing.Point(722, 103);
            this.tbPriceProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPriceProd.Name = "tbPriceProd";
            this.tbPriceProd.Size = new System.Drawing.Size(407, 35);
            this.tbPriceProd.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(640, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio:";
            // 
            // cbCategorie
            // 
            this.cbCategorie.DisplayMember = "nombre";
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(150, 258);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(467, 37);
            this.cbCategorie.TabIndex = 29;
            this.cbCategorie.ValueMember = "id_categoria";
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Categoria:";
            // 
            // tbStockProd
            // 
            this.tbStockProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockProd.Location = new System.Drawing.Point(116, 208);
            this.tbStockProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStockProd.Name = "tbStockProd";
            this.tbStockProd.Size = new System.Drawing.Size(359, 35);
            this.tbStockProd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stock:";
            // 
            // tbTitleProd
            // 
            this.tbTitleProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitleProd.Location = new System.Drawing.Point(116, 48);
            this.tbTitleProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitleProd.Name = "tbTitleProd";
            this.tbTitleProd.Size = new System.Drawing.Size(424, 35);
            this.tbTitleProd.TabIndex = 7;
            // 
            // tbDescProd
            // 
            this.tbDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescProd.Location = new System.Drawing.Point(167, 98);
            this.tbDescProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescProd.Multiline = true;
            this.tbDescProd.Name = "tbDescProd";
            this.tbDescProd.Size = new System.Drawing.Size(419, 90);
            this.tbDescProd.TabIndex = 6;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(20, 51);
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
            this.LNombre.Location = new System.Drawing.Point(14, 101);
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
            this.label8.Location = new System.Drawing.Point(648, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 37);
            this.label8.TabIndex = 56;
            this.label8.Text = "Editar producto";
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOk.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btOk.IconColor = System.Drawing.Color.White;
            this.btOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.Location = new System.Drawing.Point(66, 450);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(200, 54);
            this.btOk.TabIndex = 62;
            this.btOk.Text = "Guardar     ";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            this.btOk.MouseLeave += new System.EventHandler(this.btAdd_MouseLeave);
            this.btOk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAdd_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.gbEdProd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 635);
            this.panel1.TabIndex = 63;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // editProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1309, 635);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editProduct";
            this.Text = "editProduct";
            this.Load += new System.EventHandler(this.editProduct_Load);
            this.gbEdProd.ResumeLayout(false);
            this.gbEdProd.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btClean;
        private System.Windows.Forms.GroupBox gbEdProd;
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
        private FontAwesome.Sharp.IconButton btOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private FontAwesome.Sharp.IconButton btBack;
    }
}