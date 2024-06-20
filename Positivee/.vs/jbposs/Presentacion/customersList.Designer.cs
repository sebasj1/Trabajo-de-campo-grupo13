namespace jbposs.Presentacion
{
    partial class customersList
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
            this.panelUserList = new System.Windows.Forms.Panel();
            this.lblCustList = new System.Windows.Forms.Label();
            this.dataGridUserList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new FontAwesome.Sharp.IconButton();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.panelUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserList
            // 
            this.panelUserList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUserList.Controls.Add(this.lblCustList);
            this.panelUserList.Controls.Add(this.dataGridUserList);
            this.panelUserList.Controls.Add(this.groupBox1);
            this.panelUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserList.Location = new System.Drawing.Point(0, 0);
            this.panelUserList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserList.Name = "panelUserList";
            this.panelUserList.Size = new System.Drawing.Size(1498, 686);
            this.panelUserList.TabIndex = 1;
            this.panelUserList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserList_Paint);
            // 
            // lblCustList
            // 
            this.lblCustList.AutoSize = true;
            this.lblCustList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustList.Location = new System.Drawing.Point(24, 32);
            this.lblCustList.Name = "lblCustList";
            this.lblCustList.Size = new System.Drawing.Size(0, 46);
            this.lblCustList.TabIndex = 13;
            // 
            // dataGridUserList
            // 
            this.dataGridUserList.AllowUserToAddRows = false;
            this.dataGridUserList.AllowUserToDeleteRows = false;
            this.dataGridUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUserList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserList.Location = new System.Drawing.Point(3, 145);
            this.dataGridUserList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridUserList.MultiSelect = false;
            this.dataGridUserList.Name = "dataGridUserList";
            this.dataGridUserList.ReadOnly = true;
            this.dataGridUserList.RowHeadersWidth = 62;
            this.dataGridUserList.RowTemplate.Height = 28;
            this.dataGridUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUserList.Size = new System.Drawing.Size(1483, 505);
            this.dataGridUserList.TabIndex = 9;
            this.dataGridUserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridUserList_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(808, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(678, 91);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btRefresh.IconColor = System.Drawing.Color.Black;
            this.btRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btRefresh.IconSize = 30;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefresh.Location = new System.Drawing.Point(502, 32);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(158, 57);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Actualizar  ";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFilter.IconColor = System.Drawing.Color.Black;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 30;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(336, 32);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(158, 57);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrar    ";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ver :";
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.IntegralHeight = false;
            this.cbRol.ItemHeight = 26;
            this.cbRol.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.cbRol.Location = new System.Drawing.Point(66, 35);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(248, 34);
            this.cbRol.TabIndex = 10;
            this.cbRol.Text = "Todos";
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // customersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 686);
            this.Controls.Add(this.panelUserList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "customersList";
            this.Text = "customersList";
            this.Load += new System.EventHandler(this.customersList_Load);
            this.panelUserList.ResumeLayout(false);
            this.panelUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserList;
        public System.Windows.Forms.Label lblCustList;
        public System.Windows.Forms.DataGridView dataGridUserList;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btRefresh;
        private FontAwesome.Sharp.IconButton btnFilter;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label1;
    }
}