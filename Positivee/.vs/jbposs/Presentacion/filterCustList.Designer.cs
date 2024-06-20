namespace jbposs.Presentacion
{
    partial class filterCustList
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
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbSurname = new System.Windows.Forms.RadioButton();
            this.rbDni = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBrowser
            // 
            this.btBrowser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btBrowser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBrowser.Location = new System.Drawing.Point(518, 215);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(177, 65);
            this.btBrowser.TabIndex = 11;
            this.btBrowser.Text = "Buscar";
            this.btBrowser.UseVisualStyleBackColor = false;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // tbBrowser
            // 
            this.tbBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBrowser.Location = new System.Drawing.Point(414, 120);
            this.tbBrowser.Name = "tbBrowser";
            this.tbBrowser.Size = new System.Drawing.Size(391, 35);
            this.tbBrowser.TabIndex = 10;
            this.tbBrowser.TextChanged += new System.EventHandler(this.tbBrowser_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.rbSurname);
            this.groupBox1.Controls.Add(this.rbDni);
            this.groupBox1.Location = new System.Drawing.Point(62, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbName.Location = new System.Drawing.Point(22, 111);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(115, 30);
            this.rbName.TabIndex = 3;
            this.rbName.TabStop = true;
            this.rbName.Text = "Nombre";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbSurname
            // 
            this.rbSurname.AutoSize = true;
            this.rbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbSurname.Location = new System.Drawing.Point(22, 74);
            this.rbSurname.Name = "rbSurname";
            this.rbSurname.Size = new System.Drawing.Size(115, 30);
            this.rbSurname.TabIndex = 2;
            this.rbSurname.TabStop = true;
            this.rbSurname.Text = "Apellido";
            this.rbSurname.UseVisualStyleBackColor = true;
            // 
            // rbDni
            // 
            this.rbDni.AutoSize = true;
            this.rbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbDni.Location = new System.Drawing.Point(22, 38);
            this.rbDni.Name = "rbDni";
            this.rbDni.Size = new System.Drawing.Size(93, 30);
            this.rbDni.TabIndex = 0;
            this.rbDni.TabStop = true;
            this.rbDni.Text = "D.N.I.";
            this.rbDni.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(57, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 29);
            this.name.TabIndex = 8;
            this.name.Text = "Filtrar por:";
            // 
            // filterCustList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 371);
            this.Controls.Add(this.btBrowser);
            this.Controls.Add(this.tbBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Name = "filterCustList";
            this.Text = "filterCustList";
            this.Load += new System.EventHandler(this.filterCustList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBrowser;
        private System.Windows.Forms.TextBox tbBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbSurname;
        private System.Windows.Forms.RadioButton rbDni;
        private System.Windows.Forms.Label name;
    }
}