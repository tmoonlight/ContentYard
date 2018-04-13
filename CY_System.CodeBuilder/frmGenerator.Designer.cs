namespace CY_System.CodeBuilder
{
    partial class frmGenerator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            this.btnGenterate = new System.Windows.Forms.Button();
            this.cbxRepository = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDTOName = new System.Windows.Forms.TextBox();
            this.cbxWebApi = new System.Windows.Forms.CheckBox();
            this.cbxDTO = new System.Windows.Forms.CheckBox();
            this.cbxBLL = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxModelName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ddlDomain = new System.Windows.Forms.ComboBox();
            this.ddlRepository = new System.Windows.Forms.ComboBox();
            this.ddlDTO = new System.Windows.Forms.ComboBox();
            this.ddlService = new System.Windows.Forms.ComboBox();
            this.ddlBLL = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomain = new System.Windows.Forms.CheckBox();
            this.tbxSolutionDir = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trvDBInfo = new System.Windows.Forms.TreeView();
            this.btnChangeDbConn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenterate
            // 
            this.btnGenterate.Location = new System.Drawing.Point(637, 466);
            this.btnGenterate.Name = "btnGenterate";
            this.btnGenterate.Size = new System.Drawing.Size(100, 46);
            this.btnGenterate.TabIndex = 9;
            this.btnGenterate.Text = "生成";
            this.btnGenterate.UseVisualStyleBackColor = true;
            this.btnGenterate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxRepository
            // 
            this.cbxRepository.AutoSize = true;
            this.cbxRepository.Checked = true;
            this.cbxRepository.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRepository.Location = new System.Drawing.Point(19, 352);
            this.cbxRepository.Name = "cbxRepository";
            this.cbxRepository.Size = new System.Drawing.Size(60, 16);
            this.cbxRepository.TabIndex = 12;
            this.cbxRepository.Tag = "Repository";
            this.cbxRepository.Text = "仓库类";
            this.cbxRepository.UseVisualStyleBackColor = true;
            this.cbxRepository.CheckedChanged += new System.EventHandler(this.cbxBLL_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Server.gif");
            this.imageList1.Images.SetKeyName(1, "Database.gif");
            this.imageList1.Images.SetKeyName(2, "Folder.gif");
            this.imageList1.Images.SetKeyName(3, "Table.gif");
            this.imageList1.Images.SetKeyName(4, "View.gif");
            this.imageList1.Images.SetKeyName(5, "Procedure.gif");
            this.imageList1.Images.SetKeyName(6, "Function.gif");
            this.imageList1.Images.SetKeyName(7, "Column.gif");
            this.imageList1.Images.SetKeyName(8, "PK.gif");
            this.imageList1.Images.SetKeyName(9, "FK.gif");
            this.imageList1.Images.SetKeyName(10, "UK.gif");
            this.imageList1.Images.SetKeyName(11, "Index.gif");
            this.imageList1.Images.SetKeyName(12, "null.gif");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "解决方案目录:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "表名:";
            // 
            // tbxDTOName
            // 
            this.tbxDTOName.Location = new System.Drawing.Point(20, 114);
            this.tbxDTOName.Name = "tbxDTOName";
            this.tbxDTOName.ReadOnly = true;
            this.tbxDTOName.Size = new System.Drawing.Size(543, 21);
            this.tbxDTOName.TabIndex = 16;
            // 
            // cbxWebApi
            // 
            this.cbxWebApi.AutoSize = true;
            this.cbxWebApi.Checked = true;
            this.cbxWebApi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWebApi.Location = new System.Drawing.Point(19, 300);
            this.cbxWebApi.Name = "cbxWebApi";
            this.cbxWebApi.Size = new System.Drawing.Size(96, 16);
            this.cbxWebApi.TabIndex = 18;
            this.cbxWebApi.Tag = "Service";
            this.cbxWebApi.Text = "Web Core Api";
            this.cbxWebApi.UseVisualStyleBackColor = true;
            this.cbxWebApi.CheckedChanged += new System.EventHandler(this.cbxBLL_CheckedChanged);
            // 
            // cbxDTO
            // 
            this.cbxDTO.AutoSize = true;
            this.cbxDTO.Checked = true;
            this.cbxDTO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDTO.Location = new System.Drawing.Point(19, 326);
            this.cbxDTO.Name = "cbxDTO";
            this.cbxDTO.Size = new System.Drawing.Size(42, 16);
            this.cbxDTO.TabIndex = 19;
            this.cbxDTO.Tag = "DTO";
            this.cbxDTO.Text = "DTO";
            this.cbxDTO.UseVisualStyleBackColor = true;
            this.cbxDTO.CheckedChanged += new System.EventHandler(this.cbxBLL_CheckedChanged);
            // 
            // cbxBLL
            // 
            this.cbxBLL.AutoSize = true;
            this.cbxBLL.Location = new System.Drawing.Point(19, 274);
            this.cbxBLL.Name = "cbxBLL";
            this.cbxBLL.Size = new System.Drawing.Size(42, 16);
            this.cbxBLL.TabIndex = 20;
            this.cbxBLL.Tag = "BLL";
            this.cbxBLL.Text = "BLL";
            this.cbxBLL.UseVisualStyleBackColor = true;
            this.cbxBLL.CheckedChanged += new System.EventHandler(this.cbxBLL_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxModelName);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.ddlDomain);
            this.groupBox1.Controls.Add(this.ddlRepository);
            this.groupBox1.Controls.Add(this.ddlDTO);
            this.groupBox1.Controls.Add(this.ddlService);
            this.groupBox1.Controls.Add(this.ddlBLL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxDomain);
            this.groupBox1.Controls.Add(this.cbxRepository);
            this.groupBox1.Controls.Add(this.cbxDTO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxSolutionDir);
            this.groupBox1.Controls.Add(this.cbxWebApi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxDTOName);
            this.groupBox1.Controls.Add(this.cbxBLL);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 429);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成目录";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(462, 377);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(241, 21);
            this.textBox5.TabIndex = 41;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(462, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 21);
            this.textBox4.TabIndex = 40;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(462, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 21);
            this.textBox3.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 301);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 21);
            this.textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 21);
            this.textBox1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(460, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "*相对项目路径";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "实体名:";
            // 
            // tbxModelName
            // 
            this.tbxModelName.Location = new System.Drawing.Point(21, 172);
            this.tbxModelName.Name = "tbxModelName";
            this.tbxModelName.Size = new System.Drawing.Size(543, 21);
            this.tbxModelName.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 253);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(720, 10);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // ddlDomain
            // 
            this.ddlDomain.DisplayMember = "key";
            this.ddlDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDomain.FormattingEnabled = true;
            this.ddlDomain.Location = new System.Drawing.Point(237, 378);
            this.ddlDomain.Name = "ddlDomain";
            this.ddlDomain.Size = new System.Drawing.Size(210, 20);
            this.ddlDomain.TabIndex = 32;
            this.ddlDomain.ValueMember = "Value";
            // 
            // ddlRepository
            // 
            this.ddlRepository.DisplayMember = "key";
            this.ddlRepository.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRepository.FormattingEnabled = true;
            this.ddlRepository.Location = new System.Drawing.Point(237, 352);
            this.ddlRepository.Name = "ddlRepository";
            this.ddlRepository.Size = new System.Drawing.Size(210, 20);
            this.ddlRepository.TabIndex = 31;
            this.ddlRepository.ValueMember = "Value";
            // 
            // ddlDTO
            // 
            this.ddlDTO.DisplayMember = "key";
            this.ddlDTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDTO.FormattingEnabled = true;
            this.ddlDTO.Location = new System.Drawing.Point(237, 326);
            this.ddlDTO.Name = "ddlDTO";
            this.ddlDTO.Size = new System.Drawing.Size(210, 20);
            this.ddlDTO.TabIndex = 30;
            this.ddlDTO.ValueMember = "Value";
            // 
            // ddlService
            // 
            this.ddlService.DisplayMember = "key";
            this.ddlService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlService.FormattingEnabled = true;
            this.ddlService.Location = new System.Drawing.Point(237, 300);
            this.ddlService.Name = "ddlService";
            this.ddlService.Size = new System.Drawing.Size(210, 20);
            this.ddlService.TabIndex = 29;
            this.ddlService.ValueMember = "Value";
            // 
            // ddlBLL
            // 
            this.ddlBLL.DisplayMember = "key";
            this.ddlBLL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBLL.FormattingEnabled = true;
            this.ddlBLL.Location = new System.Drawing.Point(237, 274);
            this.ddlBLL.Name = "ddlBLL";
            this.ddlBLL.Size = new System.Drawing.Size(210, 20);
            this.ddlBLL.TabIndex = 28;
            this.ddlBLL.ValueMember = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(235, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "项目名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "代码";
            // 
            // cbxDomain
            // 
            this.cbxDomain.AutoSize = true;
            this.cbxDomain.Checked = true;
            this.cbxDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDomain.Location = new System.Drawing.Point(19, 378);
            this.cbxDomain.Name = "cbxDomain";
            this.cbxDomain.Size = new System.Drawing.Size(60, 16);
            this.cbxDomain.TabIndex = 24;
            this.cbxDomain.Tag = "Domain";
            this.cbxDomain.Text = "Domain";
            this.cbxDomain.UseVisualStyleBackColor = true;
            this.cbxDomain.CheckedChanged += new System.EventHandler(this.cbxBLL_CheckedChanged);
            // 
            // tbxSolutionDir
            // 
            this.tbxSolutionDir.Location = new System.Drawing.Point(21, 55);
            this.tbxSolutionDir.Name = "tbxSolutionDir";
            this.tbxSolutionDir.ReadOnly = true;
            this.tbxSolutionDir.Size = new System.Drawing.Size(543, 21);
            this.tbxSolutionDir.TabIndex = 11;
            this.tbxSolutionDir.Text = "{SolutionDirectory}";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(531, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 46);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(260, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 1);
            this.panel3.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1129, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "耗时:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(1, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trvDBInfo
            // 
            this.trvDBInfo.CheckBoxes = true;
            this.trvDBInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDBInfo.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.trvDBInfo.ImageIndex = 0;
            this.trvDBInfo.ImageList = this.imageList1;
            this.trvDBInfo.Location = new System.Drawing.Point(0, 44);
            this.trvDBInfo.Name = "trvDBInfo";
            this.trvDBInfo.SelectedImageIndex = 0;
            this.trvDBInfo.Size = new System.Drawing.Size(376, 480);
            this.trvDBInfo.TabIndex = 3;
            this.trvDBInfo.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvDBInfo_AfterCheck);
            this.trvDBInfo.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.trvDBInfo_DrawNode);
            this.trvDBInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDBInfo_AfterSelect);
            // 
            // btnChangeDbConn
            // 
            this.btnChangeDbConn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeDbConn.Location = new System.Drawing.Point(0, 0);
            this.btnChangeDbConn.Name = "btnChangeDbConn";
            this.btnChangeDbConn.Size = new System.Drawing.Size(376, 44);
            this.btnChangeDbConn.TabIndex = 2;
            this.btnChangeDbConn.Text = "(CYYZ)修改连接字符串";
            this.btnChangeDbConn.UseVisualStyleBackColor = true;
            this.btnChangeDbConn.Click += new System.EventHandler(this.btnChangeDbConn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvDBInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnChangeDbConn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenterate);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 524);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(46, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "路径\"TEST\"会生成到\"BLL\\Migrate\\TEST\"下";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(33, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "*:相对项目路径是指模板代码生成到项目中后追加的路径,比如\"\\BLL\\Migrate\"模板的相对";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(10, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 504);
            this.splitter1.TabIndex = 27;
            this.splitter1.TabStop = false;
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 546);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CY代码生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerator_FormClosing);
            this.Load += new System.EventHandler(this.frmGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenterate;
        private System.Windows.Forms.CheckBox cbxRepository;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDTOName;
        private System.Windows.Forms.CheckBox cbxWebApi;
        private System.Windows.Forms.CheckBox cbxDTO;
        private System.Windows.Forms.CheckBox cbxBLL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cbxDomain;
        private System.Windows.Forms.TextBox tbxSolutionDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlDomain;
        private System.Windows.Forms.ComboBox ddlRepository;
        private System.Windows.Forms.ComboBox ddlDTO;
        private System.Windows.Forms.ComboBox ddlService;
        private System.Windows.Forms.ComboBox ddlBLL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView trvDBInfo;
        private System.Windows.Forms.Button btnChangeDbConn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxModelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

