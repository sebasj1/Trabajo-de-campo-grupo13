namespace jbposs.Presentacion
{
    partial class filterProdList
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
            this.btBrowser = new System.Windows.Forms.Button();
            this.tbBrowser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDescripcion = new System.Windows.Forms.RadioButton();
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBrowser
            // 
            this.btBrowser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btBrowser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBrowser.Location = new System.Drawing.Point(453, 188);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(216, 65);
            this.btBrowser.TabIndex = 11;
            this.btBrowser.Text = "Buscar";
            this.btBrowser.UseVisualStyleBackColor = false;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click_1);
            // 
            // tbBrowser
            // 
            this.tbBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBrowser.Location = new System.Drawing.Point(402, 98);
            this.tbBrowser.Name = "tbBrowser";
            this.tbBrowser.Size = new System.Drawing.Size(328, 35);
            this.tbBrowser.TabIndex = 10;
            this.tbBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            this.tbBrowser.TextChanged += new System.EventHandler(this.tbBrowser_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDescripcion);
            this.groupBox1.Controls.Add(this.rbTitle);
            this.groupBox1.Controls.Add(this.rbCode);
            this.groupBox1.Location = new System.Drawing.Point(62, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDescripcion.Location = new System.Drawing.Point(22, 137);
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Size = new System.Drawing.Size(151, 30);
            this.rbDescripcion.TabIndex = 2;
            this.rbDescripcion.TabStop = true;
            this.rbDescripcion.Text = "Descripción";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbTitle.Location = new System.Drawing.Point(22, 85);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(89, 30);
            this.rbTitle.TabIndex = 1;
            this.rbTitle.TabStop = true;
            this.rbTitle.Text = "Titulo";
            this.rbTitle.UseVisualStyleBackColor = true;
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbCode.Location = new System.Drawing.Point(22, 38);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(106, 30);
            this.rbCode.TabIndex = 0;
            this.rbCode.TabStop = true;
            this.rbCode.Text = "Código";
            this.rbCode.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(57, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 29);
            this.name.TabIndex = 8;
            this.name.Text = "Filtrar por:";
            // 
            // filterProdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 371);
            this.Controls.Add(this.btBrowser);
            this.Controls.Add(this.tbBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "filterProdList";
            this.Text = "filterProdList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.filterUserList_FormClosing);
            this.Load += new System.EventHandler(this.filterProdList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBrowser;
        private System.Windows.Forms.TextBox tbBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDescripcion;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.RadioButton rbCode;
        private System.Windows.Forms.Label name;
    }
}