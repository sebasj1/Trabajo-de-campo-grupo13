﻿namespace jbposs.Presentacion
{
    partial class cobrar
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
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.cbMedioP = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVuelto = new System.Windows.Forms.Label();
            this.btClean = new FontAwesome.Sharp.IconButton();
            this.btOk = new FontAwesome.Sharp.IconButton();
            this.dgvMP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbMonto.Location = new System.Drawing.Point(330, 59);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(244, 41);
            this.tbMonto.TabIndex = 0;
            this.tbMonto.TextChanged += new System.EventHandler(this.tbMonto_TextChanged);
            // 
            // cbMedioP
            // 
            this.cbMedioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cbMedioP.FormattingEnabled = true;
            this.cbMedioP.Location = new System.Drawing.Point(52, 59);
            this.cbMedioP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMedioP.Name = "cbMedioP";
            this.cbMedioP.Size = new System.Drawing.Size(228, 44);
            this.cbMedioP.TabIndex = 1;
            this.cbMedioP.SelectedIndexChanged += new System.EventHandler(this.cbMedioP_SelectedIndexChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(593, 39);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(97, 77);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Agregar monto";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medio de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(324, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto:";
            // 
            // lbVuelto
            // 
            this.lbVuelto.AutoSize = true;
            this.lbVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbVuelto.Location = new System.Drawing.Point(47, 310);
            this.lbVuelto.Name = "lbVuelto";
            this.lbVuelto.Size = new System.Drawing.Size(134, 36);
            this.lbVuelto.TabIndex = 8;
            this.lbVuelto.Text = "Vuelto: $";
            this.lbVuelto.Click += new System.EventHandler(this.lbVuelto_Click);
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClean.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btClean.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClean.Location = new System.Drawing.Point(505, 310);
            this.btClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(185, 70);
            this.btClean.TabIndex = 86;
            this.btClean.Text = "Limpiar ";
            this.btClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOk.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btOk.IconColor = System.Drawing.Color.White;
            this.btOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.Location = new System.Drawing.Point(292, 310);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(185, 70);
            this.btOk.TabIndex = 87;
            this.btOk.Text = "Cobrar  ";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // dgvMP
            // 
            this.dgvMP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMP.ColumnHeadersHeight = 34;
            this.dgvMP.Location = new System.Drawing.Point(52, 130);
            this.dgvMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMP.Name = "dgvMP";
            this.dgvMP.RowHeadersWidth = 62;
            this.dgvMP.RowTemplate.Height = 28;
            this.dgvMP.Size = new System.Drawing.Size(637, 161);
            this.dgvMP.TabIndex = 88;
            this.dgvMP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMP_CellContentClick);
            // 
            // cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(763, 435);
            this.Controls.Add(this.dgvMP);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbVuelto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.cbMedioP);
            this.Controls.Add(this.tbMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cobrar";
            this.Text = "cobrar";
            this.Load += new System.EventHandler(this.cobrar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cobrar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.ComboBox cbMedioP;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVuelto;
        private FontAwesome.Sharp.IconButton btClean;
        private FontAwesome.Sharp.IconButton btOk;
        private System.Windows.Forms.DataGridView dgvMP;
    }
}