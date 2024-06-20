namespace jbposs.Presentacion
{
    partial class frmBackup
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bRestoreBackup = new FontAwesome.Sharp.IconButton();
            this.bRestoreFileDialog = new FontAwesome.Sharp.IconButton();
            this.labelRestoreStatus = new System.Windows.Forms.Label();
            this.tbRestorePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCreateBackup = new FontAwesome.Sharp.IconButton();
            this.bBackupFileDialog = new FontAwesome.Sharp.IconButton();
            this.tbBackupPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(334, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 635);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copia de seguridad";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.bRestoreBackup);
            this.groupBox2.Controls.Add(this.bRestoreFileDialog);
            this.groupBox2.Controls.Add(this.labelRestoreStatus);
            this.groupBox2.Controls.Add(this.tbRestorePath);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(107, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(828, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restaurar copia anterior";
            // 
            // bRestoreBackup
            // 
            this.bRestoreBackup.AutoSize = true;
            this.bRestoreBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRestoreBackup.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.bRestoreBackup.IconColor = System.Drawing.Color.Black;
            this.bRestoreBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bRestoreBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRestoreBackup.Location = new System.Drawing.Point(599, 107);
            this.bRestoreBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRestoreBackup.Name = "bRestoreBackup";
            this.bRestoreBackup.Size = new System.Drawing.Size(197, 54);
            this.bRestoreBackup.TabIndex = 5;
            this.bRestoreBackup.Text = "Restaurar copia";
            this.bRestoreBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRestoreBackup.UseMnemonic = false;
            this.bRestoreBackup.UseVisualStyleBackColor = true;
            this.bRestoreBackup.Click += new System.EventHandler(this.bRestoreBackup_Click);
            // 
            // bRestoreFileDialog
            // 
            this.bRestoreFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRestoreFileDialog.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bRestoreFileDialog.IconColor = System.Drawing.Color.Black;
            this.bRestoreFileDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bRestoreFileDialog.IconSize = 40;
            this.bRestoreFileDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRestoreFileDialog.Location = new System.Drawing.Point(636, 52);
            this.bRestoreFileDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRestoreFileDialog.Name = "bRestoreFileDialog";
            this.bRestoreFileDialog.Size = new System.Drawing.Size(160, 41);
            this.bRestoreFileDialog.TabIndex = 5;
            this.bRestoreFileDialog.Text = "Examinar... ";
            this.bRestoreFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRestoreFileDialog.UseVisualStyleBackColor = true;
            this.bRestoreFileDialog.Click += new System.EventHandler(this.bRestoreFileDialog_Click);
            // 
            // labelRestoreStatus
            // 
            this.labelRestoreStatus.AutoSize = true;
            this.labelRestoreStatus.Location = new System.Drawing.Point(20, 110);
            this.labelRestoreStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestoreStatus.Name = "labelRestoreStatus";
            this.labelRestoreStatus.Size = new System.Drawing.Size(122, 25);
            this.labelRestoreStatus.TabIndex = 4;
            this.labelRestoreStatus.Text = "Esperando...";
            // 
            // tbRestorePath
            // 
            this.tbRestorePath.Location = new System.Drawing.Point(24, 58);
            this.tbRestorePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRestorePath.Name = "tbRestorePath";
            this.tbRestorePath.Size = new System.Drawing.Size(568, 30);
            this.tbRestorePath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.bCreateBackup);
            this.groupBox1.Controls.Add(this.bBackupFileDialog);
            this.groupBox1.Controls.Add(this.tbBackupPath);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(107, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(828, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear copia de seguridad";
            // 
            // bCreateBackup
            // 
            this.bCreateBackup.AutoSize = true;
            this.bCreateBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateBackup.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.bCreateBackup.IconColor = System.Drawing.Color.Black;
            this.bCreateBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCreateBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCreateBackup.Location = new System.Drawing.Point(599, 102);
            this.bCreateBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCreateBackup.Name = "bCreateBackup";
            this.bCreateBackup.Size = new System.Drawing.Size(197, 54);
            this.bCreateBackup.TabIndex = 4;
            this.bCreateBackup.Text = "Crear copia   ";
            this.bCreateBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCreateBackup.UseMnemonic = false;
            this.bCreateBackup.UseVisualStyleBackColor = true;
            this.bCreateBackup.Click += new System.EventHandler(this.bCreateBackup_Click);
            // 
            // bBackupFileDialog
            // 
            this.bBackupFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBackupFileDialog.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bBackupFileDialog.IconColor = System.Drawing.Color.Black;
            this.bBackupFileDialog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bBackupFileDialog.IconSize = 40;
            this.bBackupFileDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBackupFileDialog.Location = new System.Drawing.Point(636, 49);
            this.bBackupFileDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBackupFileDialog.Name = "bBackupFileDialog";
            this.bBackupFileDialog.Size = new System.Drawing.Size(160, 41);
            this.bBackupFileDialog.TabIndex = 3;
            this.bBackupFileDialog.Text = "Examinar... ";
            this.bBackupFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bBackupFileDialog.UseVisualStyleBackColor = true;
            this.bBackupFileDialog.Click += new System.EventHandler(this.bBackupFileDialog_Click);
            // 
            // tbBackupPath
            // 
            this.tbBackupPath.Location = new System.Drawing.Point(24, 54);
            this.tbBackupPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBackupPath.Name = "tbBackupPath";
            this.tbBackupPath.Size = new System.Drawing.Size(568, 30);
            this.tbBackupPath.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 635);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(24, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(229, 187);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Creación de una copia o restauración de una base de datos";
            this.textBox1.UseWaitCursor = true;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton bRestoreBackup;
        private FontAwesome.Sharp.IconButton bRestoreFileDialog;
        private System.Windows.Forms.Label labelRestoreStatus;
        private System.Windows.Forms.TextBox tbRestorePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton bCreateBackup;
        private FontAwesome.Sharp.IconButton bBackupFileDialog;
        private System.Windows.Forms.TextBox tbBackupPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}