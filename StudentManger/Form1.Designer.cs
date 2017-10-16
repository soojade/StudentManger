namespace StudentManger {
    partial class fmMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbQueryInformation = new System.Windows.Forms.GroupBox();
            this.tbQueryId = new System.Windows.Forms.TextBox();
            this.lbQueryName = new System.Windows.Forms.Label();
            this.tbQueryPhone = new System.Windows.Forms.TextBox();
            this.lbQueryPhone = new System.Windows.Forms.Label();
            this.tbQueryName = new System.Windows.Forms.TextBox();
            this.lbQueryId = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.lbSex = new System.Windows.Forms.Label();
            this.dtpBDay = new System.Windows.Forms.DateTimePicker();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbQueryInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQueryInformation
            // 
            this.gbQueryInformation.BackColor = System.Drawing.Color.SteelBlue;
            this.gbQueryInformation.Controls.Add(this.tbQueryId);
            this.gbQueryInformation.Controls.Add(this.lbQueryName);
            this.gbQueryInformation.Controls.Add(this.tbQueryPhone);
            this.gbQueryInformation.Controls.Add(this.lbQueryPhone);
            this.gbQueryInformation.Controls.Add(this.tbQueryName);
            this.gbQueryInformation.Controls.Add(this.lbQueryId);
            this.gbQueryInformation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbQueryInformation.ForeColor = System.Drawing.Color.Black;
            this.gbQueryInformation.Location = new System.Drawing.Point(14, 14);
            this.gbQueryInformation.Name = "gbQueryInformation";
            this.gbQueryInformation.Size = new System.Drawing.Size(234, 236);
            this.gbQueryInformation.TabIndex = 0;
            this.gbQueryInformation.TabStop = false;
            this.gbQueryInformation.Text = "学生信息查询";
            this.gbQueryInformation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbQueryId
            // 
            this.tbQueryId.BackColor = System.Drawing.Color.SteelBlue;
            this.tbQueryId.Location = new System.Drawing.Point(98, 101);
            this.tbQueryId.Name = "tbQueryId";
            this.tbQueryId.Size = new System.Drawing.Size(128, 29);
            this.tbQueryId.TabIndex = 2;
            // 
            // lbQueryName
            // 
            this.lbQueryName.AutoSize = true;
            this.lbQueryName.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQueryName.Location = new System.Drawing.Point(7, 51);
            this.lbQueryName.Name = "lbQueryName";
            this.lbQueryName.Size = new System.Drawing.Size(72, 19);
            this.lbQueryName.TabIndex = 1;
            this.lbQueryName.Text = "姓名：";
            // 
            // tbQueryPhone
            // 
            this.tbQueryPhone.BackColor = System.Drawing.Color.SteelBlue;
            this.tbQueryPhone.Location = new System.Drawing.Point(98, 166);
            this.tbQueryPhone.Name = "tbQueryPhone";
            this.tbQueryPhone.Size = new System.Drawing.Size(128, 29);
            this.tbQueryPhone.TabIndex = 2;
            // 
            // lbQueryPhone
            // 
            this.lbQueryPhone.AutoSize = true;
            this.lbQueryPhone.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQueryPhone.Location = new System.Drawing.Point(-5, 177);
            this.lbQueryPhone.Name = "lbQueryPhone";
            this.lbQueryPhone.Size = new System.Drawing.Size(93, 19);
            this.lbQueryPhone.TabIndex = 1;
            this.lbQueryPhone.Text = "手机号：";
            // 
            // tbQueryName
            // 
            this.tbQueryName.BackColor = System.Drawing.Color.SteelBlue;
            this.tbQueryName.Location = new System.Drawing.Point(98, 40);
            this.tbQueryName.Name = "tbQueryName";
            this.tbQueryName.Size = new System.Drawing.Size(128, 29);
            this.tbQueryName.TabIndex = 2;
            // 
            // lbQueryId
            // 
            this.lbQueryId.AutoSize = true;
            this.lbQueryId.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQueryId.Location = new System.Drawing.Point(2, 114);
            this.lbQueryId.Name = "lbQueryId";
            this.lbQueryId.Size = new System.Drawing.Size(72, 19);
            this.lbQueryId.TabIndex = 1;
            this.lbQueryId.Text = "学号：";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToOrderColumns = true;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.Location = new System.Drawing.Point(255, 14);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(561, 236);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // 学号
            // 
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "性别";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 120F;
            this.Column3.HeaderText = "出生日期";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "手机号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(824, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(824, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModify.Location = new System.Drawing.Point(824, 142);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(96, 50);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.Location = new System.Drawing.Point(824, 28);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(96, 50);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BTNImport_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.BackColor = System.Drawing.Color.SteelBlue;
            this.gbInformation.Controls.Add(this.rbWoman);
            this.gbInformation.Controls.Add(this.rbMan);
            this.gbInformation.Controls.Add(this.lbSex);
            this.gbInformation.Controls.Add(this.dtpBDay);
            this.gbInformation.Controls.Add(this.btnPhoto);
            this.gbInformation.Controls.Add(this.btnCancel);
            this.gbInformation.Controls.Add(this.btnSubmit);
            this.gbInformation.Controls.Add(this.pbPhoto);
            this.gbInformation.Controls.Add(this.tbEmail);
            this.gbInformation.Controls.Add(this.tbPhone);
            this.gbInformation.Controls.Add(this.tbAddress);
            this.gbInformation.Controls.Add(this.lbEmail);
            this.gbInformation.Controls.Add(this.tbId);
            this.gbInformation.Controls.Add(this.lbPhone);
            this.gbInformation.Controls.Add(this.lbDate);
            this.gbInformation.Controls.Add(this.lbAddress);
            this.gbInformation.Controls.Add(this.lbId);
            this.gbInformation.Controls.Add(this.tbName);
            this.gbInformation.Controls.Add(this.lbName);
            this.gbInformation.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbInformation.Location = new System.Drawing.Point(14, 266);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(905, 189);
            this.gbInformation.TabIndex = 3;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "学生明细";
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbWoman.Location = new System.Drawing.Point(267, 103);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(42, 20);
            this.rbWoman.TabIndex = 5;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "女";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbMan.Location = new System.Drawing.Point(208, 103);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(42, 20);
            this.rbMan.TabIndex = 5;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "男";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSex.Location = new System.Drawing.Point(132, 107);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(56, 16);
            this.lbSex.TabIndex = 4;
            this.lbSex.Text = "性别：";
            // 
            // dtpBDay
            // 
            this.dtpBDay.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpBDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBDay.Location = new System.Drawing.Point(629, 24);
            this.dtpBDay.Name = "dtpBDay";
            this.dtpBDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBDay.Size = new System.Drawing.Size(125, 26);
            this.dtpBDay.TabIndex = 3;
            // 
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPhoto.Location = new System.Drawing.Point(9, 148);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(94, 30);
            this.btnPhoto.TabIndex = 1;
            this.btnPhoto.Text = "选择照片";
            this.btnPhoto.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(796, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(796, 89);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(7, 21);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(96, 126);
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.tbEmail.ForeColor = System.Drawing.Color.Yellow;
            this.tbEmail.Location = new System.Drawing.Point(626, 94);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmail.Size = new System.Drawing.Size(128, 26);
            this.tbEmail.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.SteelBlue;
            this.tbPhone.ForeColor = System.Drawing.Color.Yellow;
            this.tbPhone.Location = new System.Drawing.Point(409, 94);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPhone.Size = new System.Drawing.Size(128, 26);
            this.tbPhone.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.tbAddress.ForeColor = System.Drawing.Color.Yellow;
            this.tbAddress.Location = new System.Drawing.Point(238, 136);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAddress.Size = new System.Drawing.Size(516, 26);
            this.tbAddress.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.lbEmail.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEmail.Location = new System.Drawing.Point(544, 107);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 16);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "邮箱：";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.SteelBlue;
            this.tbId.ForeColor = System.Drawing.Color.Yellow;
            this.tbId.Location = new System.Drawing.Point(401, 24);
            this.tbId.Name = "tbId";
            this.tbId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbId.Size = new System.Drawing.Size(128, 26);
            this.tbId.TabIndex = 2;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.SteelBlue;
            this.lbPhone.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPhone.Location = new System.Drawing.Point(339, 107);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(56, 16);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "电话：";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.SteelBlue;
            this.lbDate.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDate.Location = new System.Drawing.Point(544, 37);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(88, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "出生日期：";
            this.lbDate.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.SteelBlue;
            this.lbAddress.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAddress.Location = new System.Drawing.Point(128, 147);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(88, 16);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "家庭地址：";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.SteelBlue;
            this.lbId.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbId.Location = new System.Drawing.Point(339, 37);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(56, 16);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "学号：";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.SteelBlue;
            this.tbName.ForeColor = System.Drawing.Color.Yellow;
            this.tbName.Location = new System.Drawing.Point(188, 24);
            this.tbName.Name = "tbName";
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.Size = new System.Drawing.Size(128, 26);
            this.tbName.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(132, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "姓名：";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(925, -6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // fmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 464);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.gbQueryInformation);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.gbQueryInformation.ResumeLayout(false);
            this.gbQueryInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQueryInformation;
        private System.Windows.Forms.TextBox tbQueryId;
        private System.Windows.Forms.Label lbQueryName;
        private System.Windows.Forms.TextBox tbQueryPhone;
        private System.Windows.Forms.Label lbQueryPhone;
        private System.Windows.Forms.TextBox tbQueryName;
        private System.Windows.Forms.Label lbQueryId;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.DateTimePicker dtpBDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
    }
}

