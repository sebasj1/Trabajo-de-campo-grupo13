namespace jbposs.Presentacion
{
    partial class filterUserList
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
            this.rbUser = new System.Windows.Forms.RadioButton();
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
            this.btBrowser.Location = new System.Drawing.Point(548, 198);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(177, 65);
            this.btBrowser.TabIndex = 7;
            this.btBrowser.Text = "Buscar";
            this.btBrowser.UseVisualStyleBackColor = false;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // tbBrowser
            // 
            this.tbBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBrowser.Location = new System.Drawing.Point(444, 103);
            this.tbBrowser.Name = "tbBrowser";
            this.tbBrowser.Size = new System.Drawing.Size(391, 35);
            this.tbBrowser.TabIndex = 6;
            this.tbBrowser.TextChanged += new System.EventHandler(this.tbBrowser_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.rbSurname);
            this.groupBox1.Controls.Add(this.rbUser);
            this.groupBox1.Controls.Add(this.rbDni);
            this.groupBox1.Location = new System.Drawing.Point(92, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbName.Location = new System.Drawing.Point(22, 160);
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
            this.rbSurname.Location = new System.Drawing.Point(22, 123);
            this.rbSurname.Name = "rbSurname";
            this.rbSurname.Size = new System.Drawing.Size(115, 30);
            this.rbSurname.TabIndex = 2;
            this.rbSurname.TabStop = true;
            this.rbSurname.Text = "Apellido";
            this.rbSurname.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbUser.Location = new System.Drawing.Point(22, 82);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(112, 30);
            this.rbUser.TabIndex = 1;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Usuario";
            this.rbUser.UseVisualStyleBackColor = true;
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
            this.name.Location = new System.Drawing.Point(87, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 29);
            this.name.TabIndex = 4;
            this.name.Text = "Filtrar por:";
            // 
            // filterUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 371);
            this.Controls.Add(this.btBrowser);
            this.Controls.Add(this.tbBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Name = "filterUserList";
            this.Text = "filterUserList";
            this.Load += new System.EventHandler(this.filterUserList_Load);
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
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbDni;
        private System.Windows.Forms.Label name;
    }
}