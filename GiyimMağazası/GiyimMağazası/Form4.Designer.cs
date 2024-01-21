namespace GiyimMağazası
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRmove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet4 = new GiyimMağazası.MağazaKayitDataSet4();
            this.ürünlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet3 = new GiyimMağazası.MağazaKayitDataSet3();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ürünlerTableAdapter = new GiyimMağazası.MağazaKayitDataSet3TableAdapters.ÜrünlerTableAdapter();
            this.ürünlerTableAdapter1 = new GiyimMağazası.MağazaKayitDataSet4TableAdapters.ÜrünlerTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "EYC BUTİK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 74);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnRmove);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(379, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 695);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "ARA :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(628, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 22);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.ImageKey = "minus.png";
            this.label12.ImageList = this.ımageList1;
            this.label12.Location = new System.Drawing.Point(133, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 33);
            this.label12.TabIndex = 43;
            this.label12.Text = "SİL";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "minus.png");
            this.ımageList1.Images.SetKeyName(1, "plus.png");
            this.ımageList1.Images.SetKeyName(2, "refresh.png");
            this.ımageList1.Images.SetKeyName(3, "reject.png");
            // 
            // btnRmove
            // 
            this.btnRmove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnRmove.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRmove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRmove.ImageKey = "minus.png";
            this.btnRmove.Location = new System.Drawing.Point(93, 167);
            this.btnRmove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRmove.Name = "btnRmove";
            this.btnRmove.Size = new System.Drawing.Size(176, 71);
            this.btnRmove.TabIndex = 42;
            this.btnRmove.Text = "SİL";
            this.btnRmove.UseVisualStyleBackColor = false;
            this.btnRmove.Click += new System.EventHandler(this.btnRmove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokNoDataGridViewTextBoxColumn,
            this.ürünAdiDataGridViewTextBoxColumn,
            this.bedenDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.stokAdediDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ürünlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(381, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(724, 513);
            this.dataGridView1.TabIndex = 41;
            // 
            // stokNoDataGridViewTextBoxColumn
            // 
            this.stokNoDataGridViewTextBoxColumn.DataPropertyName = "StokNo";
            this.stokNoDataGridViewTextBoxColumn.HeaderText = "StokNo";
            this.stokNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokNoDataGridViewTextBoxColumn.Name = "stokNoDataGridViewTextBoxColumn";
            this.stokNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünAdiDataGridViewTextBoxColumn
            // 
            this.ürünAdiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.HeaderText = "ÜrünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünAdiDataGridViewTextBoxColumn.Name = "ürünAdiDataGridViewTextBoxColumn";
            this.ürünAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ürünAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // bedenDataGridViewTextBoxColumn
            // 
            this.bedenDataGridViewTextBoxColumn.DataPropertyName = "Beden";
            this.bedenDataGridViewTextBoxColumn.HeaderText = "Beden";
            this.bedenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bedenDataGridViewTextBoxColumn.Name = "bedenDataGridViewTextBoxColumn";
            this.bedenDataGridViewTextBoxColumn.ReadOnly = true;
            this.bedenDataGridViewTextBoxColumn.Width = 125;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "Renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "Renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            this.renkDataGridViewTextBoxColumn.ReadOnly = true;
            this.renkDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokAdediDataGridViewTextBoxColumn
            // 
            this.stokAdediDataGridViewTextBoxColumn.DataPropertyName = "StokAdedi";
            this.stokAdediDataGridViewTextBoxColumn.HeaderText = "StokAdedi";
            this.stokAdediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokAdediDataGridViewTextBoxColumn.Name = "stokAdediDataGridViewTextBoxColumn";
            this.stokAdediDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokAdediDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünlerBindingSource1
            // 
            this.ürünlerBindingSource1.DataMember = "Ürünler";
            this.ürünlerBindingSource1.DataSource = this.mağazaKayitDataSet4BindingSource;
            // 
            // mağazaKayitDataSet4BindingSource
            // 
            this.mağazaKayitDataSet4BindingSource.DataSource = this.mağazaKayitDataSet4;
            this.mağazaKayitDataSet4BindingSource.Position = 0;
            // 
            // mağazaKayitDataSet4
            // 
            this.mağazaKayitDataSet4.DataSetName = "MağazaKayitDataSet4";
            this.mağazaKayitDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünlerBindingSource
            // 
            this.ürünlerBindingSource.DataMember = "Ürünler";
            this.ürünlerBindingSource.DataSource = this.mağazaKayitDataSet3BindingSource;
            // 
            // mağazaKayitDataSet3BindingSource
            // 
            this.mağazaKayitDataSet3BindingSource.DataSource = this.mağazaKayitDataSet3;
            this.mağazaKayitDataSet3BindingSource.Position = 0;
            // 
            // mağazaKayitDataSet3
            // 
            this.mağazaKayitDataSet3.DataSetName = "MağazaKayitDataSet3";
            this.mağazaKayitDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 695);
            this.panel2.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageKey = "reject.png";
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(48, 238);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(265, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ÇIKIŞ YAP";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(341, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 692);
            this.panel4.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.ImageKey = "refresh.png";
            this.btnRemove.ImageList = this.ımageList1;
            this.btnRemove.Location = new System.Drawing.Point(48, 148);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(265, 41);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "ÜRÜN GÜNCELLE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageKey = "plus.png";
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(48, 64);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ÜRÜN EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1571, 74);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "EYC BUTİK";
            // 
            // ürünlerTableAdapter
            // 
            this.ürünlerTableAdapter.ClearBeforeFill = true;
            // 
            // ürünlerTableAdapter1
            // 
            this.ürünlerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 769);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRmove;
        private System.Windows.Forms.BindingSource mağazaKayitDataSet3BindingSource;
        private MağazaKayitDataSet3 mağazaKayitDataSet3;
        private System.Windows.Forms.BindingSource ürünlerBindingSource;
        private MağazaKayitDataSet3TableAdapters.ÜrünlerTableAdapter ürünlerTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource mağazaKayitDataSet4BindingSource;
        private MağazaKayitDataSet4 mağazaKayitDataSet4;
        private System.Windows.Forms.BindingSource ürünlerBindingSource1;
        private MağazaKayitDataSet4TableAdapters.ÜrünlerTableAdapter ürünlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn;
    }
}