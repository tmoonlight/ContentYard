namespace UpdatePublisher
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.tbUploadName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.rdbUpdateApp = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.pbUpload = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lvFileList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCDN = new System.Windows.Forms.Button();
            this.lblDownloadUrl = new System.Windows.Forms.Label();
            this.tbDownloadUrl = new System.Windows.Forms.TextBox();
            this.btnGetDownloadUrl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ckbDefault = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(83, 52);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(329, 21);
            this.tbFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "发布文件：";
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.Location = new System.Drawing.Point(419, 268);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSubmit.TabIndex = 0;
            this.btnUpdateSubmit.Text = "提交版本";
            this.btnUpdateSubmit.UseVisualStyleBackColor = true;
            this.btnUpdateSubmit.Click += new System.EventHandler(this.btnUpdateSubmit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(412, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(31, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(418, 130);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(83, 181);
            this.tbVer.Name = "tbVer";
            this.tbVer.Size = new System.Drawing.Size(329, 21);
            this.tbVer.TabIndex = 5;
            // 
            // tbUploadName
            // 
            this.tbUploadName.Location = new System.Drawing.Point(83, 103);
            this.tbUploadName.Name = "tbUploadName";
            this.tbUploadName.Size = new System.Drawing.Size(329, 21);
            this.tbUploadName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "服务器文件名：";
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Checked = true;
            this.rdbClient.Location = new System.Drawing.Point(142, 20);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(59, 16);
            this.rdbClient.TabIndex = 8;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "客户端";
            this.rdbClient.UseVisualStyleBackColor = true;
            // 
            // rdbUpdateApp
            // 
            this.rdbUpdateApp.AutoSize = true;
            this.rdbUpdateApp.Location = new System.Drawing.Point(261, 20);
            this.rdbUpdateApp.Name = "rdbUpdateApp";
            this.rdbUpdateApp.Size = new System.Drawing.Size(65, 16);
            this.rdbUpdateApp.TabIndex = 9;
            this.rdbUpdateApp.Text = "更新App";
            this.rdbUpdateApp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "版本号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "更新摘要：";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(84, 207);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(329, 114);
            this.rtbRemark.TabIndex = 12;
            this.rtbRemark.Text = "";
            // 
            // pbUpload
            // 
            this.pbUpload.Location = new System.Drawing.Point(83, 130);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(329, 23);
            this.pbUpload.TabIndex = 13;
            this.pbUpload.Value = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 25);
            this.menuStrip1.TabIndex = 14;
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // lvFileList
            // 
            this.lvFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFileList.FullRowSelect = true;
            this.lvFileList.GridLines = true;
            this.lvFileList.Location = new System.Drawing.Point(6, 50);
            this.lvFileList.MultiSelect = false;
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(231, 302);
            this.lvFileList.TabIndex = 15;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.Details;
            this.lvFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFileList_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 220;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDefault);
            this.groupBox1.Controls.Add(this.btnRefreshCDN);
            this.groupBox1.Controls.Add(this.lblDownloadUrl);
            this.groupBox1.Controls.Add(this.tbDownloadUrl);
            this.groupBox1.Controls.Add(this.btnGetDownloadUrl);
            this.groupBox1.Controls.Add(this.rdbUpdateApp);
            this.groupBox1.Controls.Add(this.rdbClient);
            this.groupBox1.Controls.Add(this.tbUploadName);
            this.groupBox1.Controls.Add(this.rtbRemark);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbUpload);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFilePath);
            this.groupBox1.Controls.Add(this.tbVer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnUpdateSubmit);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 358);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发布";
            // 
            // btnRefreshCDN
            // 
            this.btnRefreshCDN.Location = new System.Drawing.Point(419, 298);
            this.btnRefreshCDN.Name = "btnRefreshCDN";
            this.btnRefreshCDN.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCDN.TabIndex = 17;
            this.btnRefreshCDN.Text = "刷新CDN";
            this.btnRefreshCDN.UseVisualStyleBackColor = true;
            this.btnRefreshCDN.Visible = false;
            this.btnRefreshCDN.Click += new System.EventHandler(this.btnRefreshCDN_Click);
            // 
            // lblDownloadUrl
            // 
            this.lblDownloadUrl.AutoSize = true;
            this.lblDownloadUrl.Location = new System.Drawing.Point(21, 335);
            this.lblDownloadUrl.Name = "lblDownloadUrl";
            this.lblDownloadUrl.Size = new System.Drawing.Size(59, 12);
            this.lblDownloadUrl.TabIndex = 16;
            this.lblDownloadUrl.Text = "下载url：";
            this.lblDownloadUrl.Visible = false;
            // 
            // tbDownloadUrl
            // 
            this.tbDownloadUrl.Location = new System.Drawing.Point(83, 331);
            this.tbDownloadUrl.Name = "tbDownloadUrl";
            this.tbDownloadUrl.Size = new System.Drawing.Size(329, 21);
            this.tbDownloadUrl.TabIndex = 15;
            this.tbDownloadUrl.Visible = false;
            // 
            // btnGetDownloadUrl
            // 
            this.btnGetDownloadUrl.Location = new System.Drawing.Point(418, 330);
            this.btnGetDownloadUrl.Name = "btnGetDownloadUrl";
            this.btnGetDownloadUrl.Size = new System.Drawing.Size(75, 23);
            this.btnGetDownloadUrl.TabIndex = 14;
            this.btnGetDownloadUrl.Text = "下载链接";
            this.btnGetDownloadUrl.UseVisualStyleBackColor = true;
            this.btnGetDownloadUrl.Visible = false;
            this.btnGetDownloadUrl.Click += new System.EventHandler(this.btnGetDownloadUrl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.lvFileList);
            this.groupBox2.Location = new System.Drawing.Point(518, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 358);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "七牛云文件列表";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(140, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(34, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ckbDefault
            // 
            this.ckbDefault.AutoSize = true;
            this.ckbDefault.Checked = true;
            this.ckbDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDefault.Location = new System.Drawing.Point(29, 301);
            this.ckbDefault.Name = "ckbDefault";
            this.ckbDefault.Size = new System.Drawing.Size(48, 16);
            this.ckbDefault.TabIndex = 18;
            this.ckbDefault.Text = "默认";
            this.ckbDefault.UseVisualStyleBackColor = true;
            this.ckbDefault.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CY升级发布";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSubmit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.TextBox tbUploadName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.RadioButton rdbUpdateApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ProgressBar pbUpload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ListView lvFileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDownloadUrl;
        private System.Windows.Forms.TextBox tbDownloadUrl;
        private System.Windows.Forms.Button btnGetDownloadUrl;
        private System.Windows.Forms.Button btnRefreshCDN;
        private System.Windows.Forms.CheckBox ckbDefault;
    }
}

