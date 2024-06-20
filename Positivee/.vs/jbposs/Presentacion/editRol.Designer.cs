namespace jbposs.Presentacion
{
    partial class editRol
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
            this.addRol = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // addRol
            // 
            this.addRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRol.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.addRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRol.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.addRol.IconColor = System.Drawing.Color.White;
            this.addRol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRol.Location = new System.Drawing.Point(59, 34);
            this.addRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRol.Name = "addRol";
            this.addRol.Size = new System.Drawing.Size(256, 43);
            this.addRol.TabIndex = 62;
            this.addRol.Text = "Agregar nuevo rol    ";
            this.addRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addRol.UseVisualStyleBackColor = false;
            this.addRol.Visible = false;
            this.addRol.Click += new System.EventHandler(this.addRol_Click);
            // 
            // editRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(661, 508);
            this.Controls.Add(this.addRol);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editRol";
            this.Text = "editRol";
            this.Load += new System.EventHandler(this.editRol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton addRol;
    }
}