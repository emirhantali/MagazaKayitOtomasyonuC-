namespace GiyimMağazası
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet4 = new GiyimMağazası.MağazaKayitDataSet4();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateStokAdedi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUpdateColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUpdateSize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUpdateName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateStokNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ürünlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mağazaKayitDataSet31 = new GiyimMağazası.MağazaKayitDataSet3();
            this.ürünlerTableAdapter = new GiyimMağazası.MağazaKayitDataSet3TableAdapters.ÜrünlerTableAdapter();
            this.ürünlerTableAdapter1 = new GiyimMağazası.MağazaKayitDataSet4TableAdapters.ÜrünlerTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet31)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 74);
            this.panel1.TabIndex = 0;
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
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageKey = "reject.png";
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(68, 213);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "ÇIKIŞ YAP";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnRemove.Location = new System.Drawing.Point(68, 143);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(221, 41);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "ÜRÜN SİL";
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
            this.btnAdd.Location = new System.Drawing.Point(68, 64);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ÜRÜN EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtUpdateStokAdedi);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbUpdateColor);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmbUpdateSize);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbUpdateName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtUpdateStokNo);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(379, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 695);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "ARA :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(631, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 22);
            this.txtSearch.TabIndex = 54;
            this.txtSearch.Tag = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(125, 500);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageKey = "refresh.png";
            this.label6.ImageList = this.ımageList1;
            this.label6.Location = new System.Drawing.Point(91, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "GÜNCELLE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUpdateStokAdedi
            // 
            this.txtUpdateStokAdedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.txtUpdateStokAdedi.Location = new System.Drawing.Point(125, 430);
            this.txtUpdateStokAdedi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateStokAdedi.Name = "txtUpdateStokAdedi";
            this.txtUpdateStokAdedi.Size = new System.Drawing.Size(160, 22);
            this.txtUpdateStokAdedi.TabIndex = 39;
            this.txtUpdateStokAdedi.TextChanged += new System.EventHandler(this.txtUpdateStokAdedi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "StokNo";
            // 
            // cmbUpdateColor
            // 
            this.cmbUpdateColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cmbUpdateColor.FormattingEnabled = true;
            this.cmbUpdateColor.Items.AddRange(new object[] {
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
            this.cmbUpdateColor.Location = new System.Drawing.Point(125, 364);
            this.cmbUpdateColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUpdateColor.Name = "cmbUpdateColor";
            this.cmbUpdateColor.Size = new System.Drawing.Size(160, 24);
            this.cmbUpdateColor.TabIndex = 38;
            this.cmbUpdateColor.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateColor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ürün Adı";
            // 
            // cmbUpdateSize
            // 
            this.cmbUpdateSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cmbUpdateSize.FormattingEnabled = true;
            this.cmbUpdateSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cmbUpdateSize.Location = new System.Drawing.Point(125, 303);
            this.cmbUpdateSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUpdateSize.Name = "cmbUpdateSize";
            this.cmbUpdateSize.Size = new System.Drawing.Size(160, 24);
            this.cmbUpdateSize.TabIndex = 37;
            this.cmbUpdateSize.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateSize_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Beden";
            // 
            // cmbUpdateName
            // 
            this.cmbUpdateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cmbUpdateName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUpdateName.FormattingEnabled = true;
            this.cmbUpdateName.Items.AddRange(new object[] {
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
            this.cmbUpdateName.Location = new System.Drawing.Point(125, 224);
            this.cmbUpdateName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUpdateName.Name = "cmbUpdateName";
            this.cmbUpdateName.Size = new System.Drawing.Size(160, 24);
            this.cmbUpdateName.TabIndex = 36;
            this.cmbUpdateName.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 368);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Renk";
            // 
            // txtUpdateStokNo
            // 
            this.txtUpdateStokNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.txtUpdateStokNo.Enabled = false;
            this.txtUpdateStokNo.Location = new System.Drawing.Point(125, 159);
            this.txtUpdateStokNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateStokNo.Name = "txtUpdateStokNo";
            this.txtUpdateStokNo.Size = new System.Drawing.Size(160, 22);
            this.txtUpdateStokNo.TabIndex = 35;
            this.txtUpdateStokNo.TextChanged += new System.EventHandler(this.txtUpdateStokNo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 433);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Stok Adedi";
            // 
            // ürünlerBindingSource
            // 
            this.ürünlerBindingSource.DataMember = "Ürünler";
            this.ürünlerBindingSource.DataSource = this.mağazaKayitDataSet31BindingSource;
            // 
            // mağazaKayitDataSet31BindingSource
            // 
            this.mağazaKayitDataSet31BindingSource.DataSource = this.mağazaKayitDataSet31;
            this.mağazaKayitDataSet31BindingSource.Position = 0;
            // 
            // mağazaKayitDataSet31
            // 
            this.mağazaKayitDataSet31.DataSetName = "MağazaKayitDataSet3";
            this.mağazaKayitDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünlerTableAdapter
            // 
            this.ürünlerTableAdapter.ClearBeforeFill = true;
            // 
            // ürünlerTableAdapter1
            // 
            this.ürünlerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1571, 769);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mağazaKayitDataSet31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateStokAdedi;
        private System.Windows.Forms.ComboBox cmbUpdateColor;
        private System.Windows.Forms.ComboBox cmbUpdateSize;
        private System.Windows.Forms.ComboBox cmbUpdateName;
        private System.Windows.Forms.TextBox txtUpdateStokNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MağazaKayitDataSet3 mağazaKayitDataSet31;
        private System.Windows.Forms.BindingSource mağazaKayitDataSet31BindingSource;
        private System.Windows.Forms.BindingSource ürünlerBindingSource;
        private MağazaKayitDataSet3TableAdapters.ÜrünlerTableAdapter ürünlerTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
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