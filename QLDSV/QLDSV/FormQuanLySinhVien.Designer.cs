namespace QLDSV
{
    partial class FormQuanLySinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nOISINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySinhVien));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mALOPComboBox = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.tENKHOAComboBox = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nGHIHOCCheckBox = new System.Windows.Forms.CheckBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.nOISINHTextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pHAICheckBox = new System.Windows.Forms.CheckBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.mASVTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrDSSV = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nghihoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.btnXuat = new System.Windows.Forms.Button();
            mASVLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nOISINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(11, 22);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(50, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(11, 54);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(60, 17);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MALOP:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(11, 92);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(11, 142);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(40, 17);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(11, 190);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(43, 17);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(11, 226);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(83, 17);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nOISINHLabel
            // 
            nOISINHLabel.AutoSize = true;
            nOISINHLabel.Location = new System.Drawing.Point(11, 258);
            nOISINHLabel.Name = "nOISINHLabel";
            nOISINHLabel.Size = new System.Drawing.Size(68, 17);
            nOISINHLabel.TabIndex = 12;
            nOISINHLabel.Text = "NOISINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(11, 299);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(56, 17);
            dIACHILabel.TabIndex = 14;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(11, 346);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(76, 17);
            nGHIHOCLabel.TabIndex = 16;
            nGHIHOCLabel.Text = "NGHIHOC:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(400, 26);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(60, 17);
            mALOPLabel1.TabIndex = 28;
            mALOPLabel1.Text = "MALOP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(mALOPLabel1);
            this.groupBox3.Controls.Add(this.mALOPComboBox);
            this.groupBox3.Controls.Add(this.tENKHOAComboBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(6, 72);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1041, 70);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // mALOPComboBox
            // 
            this.mALOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MALOP", true));
            this.mALOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mALOPComboBox.FormattingEnabled = true;
            this.mALOPComboBox.Location = new System.Drawing.Point(466, 23);
            this.mALOPComboBox.Name = "mALOPComboBox";
            this.mALOPComboBox.Size = new System.Drawing.Size(169, 24);
            this.mALOPComboBox.TabIndex = 29;
            this.mALOPComboBox.SelectedIndexChanged += new System.EventHandler(this.mALOPComboBox_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tENKHOAComboBox
            // 
            this.tENKHOAComboBox.DataSource = this.vDSPHANMANHBindingSource;
            this.tENKHOAComboBox.DisplayMember = "TENKHOA";
            this.tENKHOAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENKHOAComboBox.FormattingEnabled = true;
            this.tENKHOAComboBox.Location = new System.Drawing.Point(95, 23);
            this.tENKHOAComboBox.Name = "tENKHOAComboBox";
            this.tENKHOAComboBox.Size = new System.Drawing.Size(248, 24);
            this.tENKHOAComboBox.TabIndex = 28;
            this.tENKHOAComboBox.ValueMember = "TENSERVER";
            this.tENKHOAComboBox.SelectedIndexChanged += new System.EventHandler(this.tENKHOAComboBox_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(nGHIHOCLabel);
            this.groupBox2.Controls.Add(this.nGHIHOCCheckBox);
            this.groupBox2.Controls.Add(dIACHILabel);
            this.groupBox2.Controls.Add(this.dIACHITextBox);
            this.groupBox2.Controls.Add(nOISINHLabel);
            this.groupBox2.Controls.Add(this.nOISINHTextBox);
            this.groupBox2.Controls.Add(nGAYSINHLabel);
            this.groupBox2.Controls.Add(this.nGAYSINHDateTimePicker);
            this.groupBox2.Controls.Add(pHAILabel);
            this.groupBox2.Controls.Add(this.pHAICheckBox);
            this.groupBox2.Controls.Add(tENLabel);
            this.groupBox2.Controls.Add(this.tENTextBox);
            this.groupBox2.Controls.Add(hOLabel);
            this.groupBox2.Controls.Add(this.hOTextBox);
            this.groupBox2.Controls.Add(mALOPLabel);
            this.groupBox2.Controls.Add(mASVLabel);
            this.groupBox2.Controls.Add(this.mASVTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 137);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(329, 390);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MALOP", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nGHIHOCCheckBox
            // 
            this.nGHIHOCCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sINHVIENBindingSource, "NGHIHOC", true));
            this.nGHIHOCCheckBox.Location = new System.Drawing.Point(95, 346);
            this.nGHIHOCCheckBox.Name = "nGHIHOCCheckBox";
            this.nGHIHOCCheckBox.Size = new System.Drawing.Size(104, 24);
            this.nGHIHOCCheckBox.TabIndex = 17;
            this.nGHIHOCCheckBox.Text = "checkBox1";
            this.nGHIHOCCheckBox.UseVisualStyleBackColor = true;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(95, 296);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(196, 22);
            this.dIACHITextBox.TabIndex = 15;
            // 
            // nOISINHTextBox
            // 
            this.nOISINHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "NOISINH", true));
            this.nOISINHTextBox.Location = new System.Drawing.Point(95, 255);
            this.nOISINHTextBox.Name = "nOISINHTextBox";
            this.nOISINHTextBox.Size = new System.Drawing.Size(196, 22);
            this.nOISINHTextBox.TabIndex = 13;
            // 
            // nGAYSINHDateTimePicker
            // 
            this.nGAYSINHDateTimePicker.CustomFormat = "";
            this.nGAYSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sINHVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateTimePicker.Location = new System.Drawing.Point(95, 221);
            this.nGAYSINHDateTimePicker.Name = "nGAYSINHDateTimePicker";
            this.nGAYSINHDateTimePicker.Size = new System.Drawing.Size(196, 22);
            this.nGAYSINHDateTimePicker.TabIndex = 11;
            // 
            // pHAICheckBox
            // 
            this.pHAICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sINHVIENBindingSource, "PHAI", true));
            this.pHAICheckBox.Location = new System.Drawing.Point(90, 183);
            this.pHAICheckBox.Name = "pHAICheckBox";
            this.pHAICheckBox.Size = new System.Drawing.Size(104, 24);
            this.pHAICheckBox.TabIndex = 9;
            this.pHAICheckBox.Text = "checkBox1";
            this.pHAICheckBox.UseVisualStyleBackColor = true;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "TEN", true));
            this.tENTextBox.Location = new System.Drawing.Point(90, 142);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(201, 22);
            this.tENTextBox.TabIndex = 7;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(90, 92);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(201, 22);
            this.hOTextBox.TabIndex = 5;
            // 
            // mASVTextBox
            // 
            this.mASVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASV", true));
            this.mASVTextBox.Location = new System.Drawing.Point(90, 17);
            this.mASVTextBox.Name = "mASVTextBox";
            this.mASVTextBox.Size = new System.Drawing.Size(201, 22);
            this.mASVTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrDSSV);
            this.groupBox1.Location = new System.Drawing.Point(343, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(704, 405);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgrDSSV
            // 
            this.dgrDSSV.AllowUserToAddRows = false;
            this.dgrDSSV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.Malop,
            this.Ho,
            this.Ten,
            this.Phai,
            this.Ngaysinh,
            this.Noisinh,
            this.diachi,
            this.Nghihoc});
            this.dgrDSSV.Location = new System.Drawing.Point(8, 18);
            this.dgrDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgrDSSV.Name = "dgrDSSV";
            this.dgrDSSV.ReadOnly = true;
            this.dgrDSSV.Size = new System.Drawing.Size(688, 387);
            this.dgrDSSV.TabIndex = 0;
            this.dgrDSSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDSSV_CellContentClick);
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã Sinh Viên";
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "Mã  Lớp";
            this.Malop.Name = "Malop";
            this.Malop.ReadOnly = true;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "PHAI";
            this.Phai.HeaderText = "Phái";
            this.Phai.Name = "Phai";
            this.Phai.ReadOnly = true;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            // 
            // Noisinh
            // 
            this.Noisinh.DataPropertyName = "Noisinh";
            this.Noisinh.HeaderText = "Nơi sinh";
            this.Noisinh.Name = "Noisinh";
            this.Noisinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // Nghihoc
            // 
            this.Nghihoc.DataPropertyName = "NGHIHOC";
            this.Nghihoc.HeaderText = "Nghỉ học";
            this.Nghihoc.Name = "Nghihoc";
            this.Nghihoc.ReadOnly = true;
            this.Nghihoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nghihoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(295, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1055, 395);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 43);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1055, 313);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 43);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(1055, 191);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(104, 43);
            this.btnThemmoi.TabIndex = 24;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1055, 253);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 43);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(1055, 463);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(97, 37);
            this.btnXuat.TabIndex = 30;
            this.btnXuat.Text = "In Bảng Điểm";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // FormQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 570);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1182, 617);
            this.MinimumSize = new System.Drawing.Size(1182, 617);
            this.Name = "FormQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLySinhVien";
            this.Load += new System.EventHandler(this.FormQuanLySinhVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrDSSV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.CheckBox nGHIHOCCheckBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox nOISINHTextBox;
        private System.Windows.Forms.DateTimePicker nGAYSINHDateTimePicker;
        private System.Windows.Forms.CheckBox pHAICheckBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox mASVTextBox;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tENKHOAComboBox;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nghihoc;
        private System.Windows.Forms.ComboBox mALOPComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnXuat;
    }
}