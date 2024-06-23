namespace Positive.Presentacion
{
    partial class Lista_productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUsers = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCli = new System.Windows.Forms.RadioButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LABELPRINCIPAL = new System.Windows.Forms.Label();
            this.DATAGRIDCELL = new System.Windows.Forms.DataGridView();
            this.panelUsers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUsers.Controls.Add(this.groupBox2);
            this.panelUsers.Controls.Add(this.label2);
            this.panelUsers.Controls.Add(this.LABELPRINCIPAL);
            this.panelUsers.Controls.Add(this.DATAGRIDCELL);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(1506, 698);
            this.panelUsers.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Controls.Add(this.rbCli);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.cbRol);
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Location = new System.Drawing.Point(775, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(719, 91);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // rbCli
            // 
            this.rbCli.AutoSize = true;
            this.rbCli.Checked = true;
            this.rbCli.Location = new System.Drawing.Point(31, 37);
            this.rbCli.Name = "rbCli";
            this.rbCli.Size = new System.Drawing.Size(78, 24);
            this.rbCli.TabIndex = 12;
            this.rbCli.TabStop = true;
            this.rbCli.Text = "Todos";
            this.rbCli.UseVisualStyleBackColor = true;
            this.rbCli.Click += new System.EventHandler(this.rbCli_CheckedChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(546, 23);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(158, 57);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Actualizar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.IntegralHeight = false;
            this.cbRol.ItemHeight = 26;
            this.cbRol.Items.AddRange(new object[] {
            "Todos"});
            this.cbRol.Location = new System.Drawing.Point(143, 35);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(218, 34);
            this.cbRol.TabIndex = 10;
            this.cbRol.Text = "Todos";
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            this.cbRol.Click += new System.EventHandler(this.cbRol_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(380, 23);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(158, 57);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Filtrar";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(715, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ver :";
            // 
            // LABELPRINCIPAL
            // 
            this.LABELPRINCIPAL.AutoSize = true;
            this.LABELPRINCIPAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELPRINCIPAL.Location = new System.Drawing.Point(34, 29);
            this.LABELPRINCIPAL.Name = "LABELPRINCIPAL";
            this.LABELPRINCIPAL.Size = new System.Drawing.Size(347, 46);
            this.LABELPRINCIPAL.TabIndex = 16;
            this.LABELPRINCIPAL.Text = "Lista de productos";
            // 
            // DATAGRIDCELL
            // 
            this.DATAGRIDCELL.AllowUserToAddRows = false;
            this.DATAGRIDCELL.AllowUserToDeleteRows = false;
            this.DATAGRIDCELL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATAGRIDCELL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DATAGRIDCELL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDCELL.Location = new System.Drawing.Point(24, 150);
            this.DATAGRIDCELL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DATAGRIDCELL.MultiSelect = false;
            this.DATAGRIDCELL.Name = "DATAGRIDCELL";
            this.DATAGRIDCELL.ReadOnly = true;
            this.DATAGRIDCELL.RowHeadersWidth = 62;
            this.DATAGRIDCELL.RowTemplate.Height = 28;
            this.DATAGRIDCELL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGRIDCELL.Size = new System.Drawing.Size(1470, 593);
            this.DATAGRIDCELL.TabIndex = 14;
            this.DATAGRIDCELL.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGRIDCELL_CellContentDoubleClick);
            // 
            // Lista_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 698);
            this.Controls.Add(this.panelUsers);
            this.Name = "Lista_productos";
            this.Text = "Lista_productos";
            this.Load += new System.EventHandler(this.Lista_productos_Load_1);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDCELL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsers;
        public System.Windows.Forms.Label LABELPRINCIPAL;
        public System.Windows.Forms.DataGridView DATAGRIDCELL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCli;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox cbRol;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label2;
    }
}