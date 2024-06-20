namespace jbposs.Presentacion
{
    partial class usersList
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
            this.lblUsList = new System.Windows.Forms.Label();
            this.dataGridUserList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new FontAwesome.Sharp.IconButton();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.panelUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserList
            // 
            this.panelUserList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUserList.Controls.Add(this.lblUsList);
            this.panelUserList.Controls.Add(this.dataGridUserList);
            this.panelUserList.Controls.Add(this.groupBox1);
            this.panelUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserList.Location = new System.Drawing.Point(0, 0);
            this.panelUserList.Name = "panelUserList";
            this.panelUserList.Size = new System.Drawing.Size(1498, 686);
            this.panelUserList.TabIndex = 0;
            // 
            // lblUsList
            // 
            this.lblUsList.AutoSize = true;
            this.lblUsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsList.Location = new System.Drawing.Point(29, 37);
            this.lblUsList.Name = "lblUsList";
            this.lblUsList.Size = new System.Drawing.Size(321, 46);
            this.lblUsList.TabIndex = 13;
            this.lblUsList.Text = "Lista de usuarios";
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
            this.dataGridUserList.Size = new System.Drawing.Size(1483, 505);
            this.dataGridUserList.TabIndex = 9;
            this.dataGridUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUserList_CellContentClick);
            this.dataGridUserList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridUserList_MouseDoubleClick);
            this.dataGridUserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridUserList_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(789, 37);
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
            this.btRefresh.Location = new System.Drawing.Point(499, 23);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(158, 57);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Actualizar";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbRol.FormattingEnabled = true;
            this.cbRol.IntegralHeight = false;
            this.cbRol.ItemHeight = 26;
            this.cbRol.Location = new System.Drawing.Point(66, 35);
            this.cbRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(248, 34);
            this.cbRol.TabIndex = 10;
            this.cbRol.Text = "Todos";
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.btnFilter.Location = new System.Drawing.Point(333, 23);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(158, 57);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // usersList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1498, 686);
            this.Controls.Add(this.panelUserList);
            this.Name = "usersList";
            this.Load += new System.EventHandler(this.usersList_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.usersList_Paint);
            this.panelUserList.ResumeLayout(false);
            this.panelUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserList;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btRefresh;
        private FontAwesome.Sharp.IconButton btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRol;
        public System.Windows.Forms.DataGridView dataGridUserList;
        public System.Windows.Forms.Label lblUsList;
    }
}