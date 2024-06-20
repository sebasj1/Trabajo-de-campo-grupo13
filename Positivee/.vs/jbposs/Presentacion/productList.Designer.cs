namespace jbposs.Presentacion
{
    partial class productList
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
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new FontAwesome.Sharp.IconButton();
            this.cbCateg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterProd = new FontAwesome.Sharp.IconButton();
            this.panelUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserList
            // 
            this.panelUserList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelUserList.Controls.Add(this.lblUsList);
            this.panelUserList.Controls.Add(this.dataGridProd);
            this.panelUserList.Controls.Add(this.groupBox1);
            this.panelUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserList.Location = new System.Drawing.Point(0, 0);
            this.panelUserList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserList.Name = "panelUserList";
            this.panelUserList.Size = new System.Drawing.Size(1332, 549);
            this.panelUserList.TabIndex = 1;
            // 
            // lblUsList
            // 
            this.lblUsList.AutoSize = true;
            this.lblUsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsList.Location = new System.Drawing.Point(21, 30);
            this.lblUsList.Name = "lblUsList";
            this.lblUsList.Size = new System.Drawing.Size(26, 39);
            this.lblUsList.TabIndex = 13;
            this.lblUsList.Text = " ";
            // 
            // dataGridProd
            // 
            this.dataGridProd.AllowUserToAddRows = false;
            this.dataGridProd.AllowUserToDeleteRows = false;
            this.dataGridProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProd.Location = new System.Drawing.Point(3, 116);
            this.dataGridProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridProd.MultiSelect = false;
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.ReadOnly = true;
            this.dataGridProd.RowHeadersWidth = 62;
            this.dataGridProd.RowTemplate.Height = 28;
            this.dataGridProd.Size = new System.Drawing.Size(1326, 423);
            this.dataGridProd.TabIndex = 9;
            this.dataGridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellContentClick);
            this.dataGridProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Controls.Add(this.cbCateg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFilterProd);
            this.groupBox1.Location = new System.Drawing.Point(701, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(603, 73);
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
            this.btRefresh.Location = new System.Drawing.Point(446, 18);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(140, 46);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Actualizar";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cbCateg
            // 
            this.cbCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbCateg.FormattingEnabled = true;
            this.cbCateg.IntegralHeight = false;
            this.cbCateg.ItemHeight = 22;
            this.cbCateg.Location = new System.Drawing.Point(59, 28);
            this.cbCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCateg.Name = "cbCateg";
            this.cbCateg.Size = new System.Drawing.Size(221, 30);
            this.cbCateg.TabIndex = 10;
            this.cbCateg.Text = "Todos";
            this.cbCateg.SelectedIndexChanged += new System.EventHandler(this.cbCateg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ver :";
            // 
            // btnFilterProd
            // 
            this.btnFilterProd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilterProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFilterProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFilterProd.IconColor = System.Drawing.Color.Black;
            this.btnFilterProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilterProd.IconSize = 30;
            this.btnFilterProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterProd.Location = new System.Drawing.Point(299, 18);
            this.btnFilterProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilterProd.Name = "btnFilterProd";
            this.btnFilterProd.Size = new System.Drawing.Size(140, 46);
            this.btnFilterProd.TabIndex = 1;
            this.btnFilterProd.Text = "Filtrar ";
            this.btnFilterProd.UseVisualStyleBackColor = false;
            this.btnFilterProd.Click += new System.EventHandler(this.btnFilterProd_Click);
            // 
            // productList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 549);
            this.Controls.Add(this.panelUserList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "productList";
            this.Load += new System.EventHandler(this.productList_Load);
            this.panelUserList.ResumeLayout(false);
            this.panelUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserList;
        public System.Windows.Forms.Label lblUsList;
        public System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btRefresh;
        private System.Windows.Forms.ComboBox cbCateg;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnFilterProd;
    }
}