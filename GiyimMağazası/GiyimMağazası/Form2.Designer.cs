namespace GiyimMağazası
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ürünlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünlerTableAdapter = new GiyimMağazası.MağazaKayitDataSet3TableAdapters.ÜrünlerTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet4 = new GiyimMağazası.MağazaKayitDataSet4();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ürünlerTableAdapter1 = new GiyimMağazası.MağazaKayitDataSet4TableAdapters.ÜrünlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ürünlerTableAdapter
            // 
            this.ürünlerTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(43, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "EYC BUTİK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 74);
            this.panel1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.cmbColor);
            this.panel3.Controls.Add(this.cmbSize);
            this.panel3.Controls.Add(this.cmbAdd);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtStokAdedi);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(379, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1161, 695);
            this.panel3.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "ARA :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(717, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 22);
            this.txtSearch.TabIndex = 52;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "KIRMIZI",
            "MAVİ",
            "YEŞİL",
            "SARI",
            "TURUNCU",
            "MOR",
            "PEMBE",
            "GRİ",
            "SİYAH",
            "BEYAZ",
            "TURKUAZ",
            "ALTIN",
            "GÜMÜŞ"});
            this.cmbColor.Location = new System.Drawing.Point(163, 340);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(160, 24);
            this.cmbColor.TabIndex = 51;
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cmbSize.Location = new System.Drawing.Point(163, 265);
            this.cmbSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(160, 24);
            this.cmbSize.TabIndex = 50;
            // 
            // cmbAdd
            // 
            this.cmbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cmbAdd.FormattingEnabled = true;
            this.cmbAdd.Items.AddRange(new object[] {
            "KAZAK",
            "GÖMLEK",
            "KABAN",
            "MONT",
            "YELEK",
            "CEKET",
            "HIRKA",
            "PANTOLON",
            "SWEATSHIRT",
            "T-SHIRT",
            "EŞOFMAN",
            "TAYT",
            "CROP"});
            this.cmbAdd.Location = new System.Drawing.Point(163, 186);
            this.cmbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAdd.Name = "cmbAdd";
            this.cmbAdd.Size = new System.Drawing.Size(160, 24);
            this.cmbAdd.TabIndex = 49;
            this.cmbAdd.SelectedIndexChanged += new System.EventHandler(this.cmbAdd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "plus.png";
            this.label1.ImageList = this.ımageList1;
            this.label1.Location = new System.Drawing.Point(140, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "ÜRÜN EKLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Stok Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Beden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ürün Adı";
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.txtStokAdedi.Location = new System.Drawing.Point(167, 420);
            this.txtStokAdedi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(156, 22);
            this.txtStokAdedi.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(188, 507);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(455, 64);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 695);
            this.panel2.TabIndex = 33;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageKey = "reject.png";
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(48, 236);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(265, 41);
            this.btnExit.TabIndex = 3;
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
            this.btnRemove.ImageKey = "minus.png";
            this.btnRemove.ImageList = this.ımageList1;
            this.btnRemove.Location = new System.Drawing.Point(48, 146);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(265, 41);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "ÜRÜN SİL";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "plus.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(48, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÜRÜN GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ürünlerTableAdapter1
            // 
            this.ürünlerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1540, 769);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ürünlerBindingSource;
        private MağazaKayitDataSet3TableAdapters.ÜrünlerTableAdapter ürünlerTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
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