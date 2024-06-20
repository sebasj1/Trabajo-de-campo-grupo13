namespace jbposs.Presentacion
{
    partial class addProduct
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
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btCancel = new FontAwesome.Sharp.IconButton();
            this.btAddProd = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.btClean.IconColor = System.Drawing.Color.White;
            this.btClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClean.Location = new System.Drawing.Point(199, 278);
            this.btClean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(134, 35);
            this.btClean.TabIndex = 61;
            this.btClean.Text = "Limpiar        ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.MouseLeave += new System.EventHandler(this.btClean_MouseLeave);
            this.btClean.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btClean_MouseMove);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btCancel.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(350, 278);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(134, 35);
            this.btCancel.TabIndex = 60;
            this.btCancel.Text = "Cancelar       ";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Visible = false;
            this.btCancel.MouseLeave += new System.EventHandler(this.btCancel_MouseLeave);
            this.btCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btCancel_MouseMove);
            // 
            // btAddProd
            // 
            this.btAddProd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btAddProd.IconColor = System.Drawing.Color.White;
            this.btAddProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddProd.Location = new System.Drawing.Point(46, 278);
            this.btAddProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(134, 35);
            this.btAddProd.TabIndex = 58;
            this.btAddProd.Text = "Agregar      ";
            this.btAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddProd.UseVisualStyleBackColor = false;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            this.btAddProd.MouseLeave += new System.EventHandler(this.btAdd_MouseLeave);
            this.btAddProd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAdd_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.groupBox1.Location = new System.Drawing.Point(44, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(772, 206);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // tbCodeProd
            // 
            this.tbCodeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeProd.Location = new System.Drawing.Point(487, 34);
            this.tbCodeProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCodeProd.Name = "tbCodeProd";
            this.tbCodeProd.Size = new System.Drawing.Size(267, 26);
            this.tbCodeProd.TabIndex = 38;
            this.tbCodeProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbCodeProd_Validating);
            this.tbCodeProd.Validated += new System.EventHandler(this.tbCodeProd_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(427, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Codigo:";
            // 
            // tbPriceProd
            // 
            this.tbPriceProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceProd.Location = new System.Drawing.Point(482, 67);
            this.tbPriceProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPriceProd.Name = "tbPriceProd";
            this.tbPriceProd.Size = new System.Drawing.Size(272, 26);
            this.tbPriceProd.TabIndex = 36;
            this.tbPriceProd.TextChanged += new System.EventHandler(this.tbPriceProd_TextChanged);
            this.tbPriceProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbPriceProd_Validating);
            this.tbPriceProd.Validated += new System.EventHandler(this.tbPriceProd_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(427, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio:";
            // 
            // cbCategorie
            // 
            this.cbCategorie.DisplayMember = "nombre";
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(100, 167);
            this.cbCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(313, 28);
            this.cbCategorie.TabIndex = 29;
            this.cbCategorie.ValueMember = "id_categoria";
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Categoria:";
            // 
            // tbStockProd
            // 
            this.tbStockProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockProd.Location = new System.Drawing.Point(77, 135);
            this.tbStockProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStockProd.Name = "tbStockProd";
            this.tbStockProd.Size = new System.Drawing.Size(241, 26);
            this.tbStockProd.TabIndex = 18;
            this.tbStockProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbStockProd_Validating);
            this.tbStockProd.Validated += new System.EventHandler(this.tbStockProd_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stock:";
            // 
            // tbTitleProd
            // 
            this.tbTitleProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitleProd.Location = new System.Drawing.Point(77, 31);
            this.tbTitleProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTitleProd.Name = "tbTitleProd";
            this.tbTitleProd.Size = new System.Drawing.Size(284, 26);
            this.tbTitleProd.TabIndex = 7;
            this.tbTitleProd.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitleProd_Validating);
            this.tbTitleProd.Validated += new System.EventHandler(this.tbTitleProd_Validated);
            // 
            // tbDescProd
            // 
            this.tbDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescProd.Location = new System.Drawing.Point(100, 63);
            this.tbDescProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescProd.Multiline = true;
            this.tbDescProd.Name = "tbDescProd";
            this.tbDescProd.Size = new System.Drawing.Size(292, 60);
            this.tbDescProd.TabIndex = 6;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(14, 33);
            this.LApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(51, 20);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Titulo:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LNombre.ForeColor = System.Drawing.Color.Black;
            this.LNombre.Location = new System.Drawing.Point(9, 66);
            this.LNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(96, 20);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(433, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 26);
            this.label8.TabIndex = 56;
            this.label8.Text = "Registrar Nuevo producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(873, 413);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addProduct";
            this.Text = "addProduct";
            this.Load += new System.EventHandler(this.addProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btClean;
        private FontAwesome.Sharp.IconButton btCancel;
        private FontAwesome.Sharp.IconButton btAddProd;
        private System.Windows.Forms.GroupBox groupBox1;
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