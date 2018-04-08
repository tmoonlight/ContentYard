using CY_System.Service.Dto;
using Qiniu.Http;
using Qiniu.Storage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UpdatePublisher
{
    public partial class FrmMain : Form
    {
        private string AutoUpdatePath = "AutoUpdate/";

        private RestClient _AutoUpdateServiceClient;
        private RestClient AutoUpdateServiceClient
        {
            get
            {
                if (_AutoUpdateServiceClient == null)
                {
                    //url 示例 :http://localhost:8076/api/AutoUpdate
                    _AutoUpdateServiceClient = new RestClient(ConfigurationManager.AppSettings["WebApiUrl"] +"AutoUpdate/");
                    _AutoUpdateServiceClient.Timeout = int.Parse(ConfigurationManager.AppSettings["WebApiTimeOut"]);
                }
                return _AutoUpdateServiceClient;
            }
        }

        private RestClient _QiNiuYunServiceClient;
        private RestClient QiNiuYunServiceClient
        {
            get
            {
                if (_QiNiuYunServiceClient == null)
                {
                    //url 示例 :http://localhost:8076/api/QiNiuYun
                    _QiNiuYunServiceClient = new RestClient(ConfigurationManager.AppSettings["WebApiUrl"] + "QiNiuYun/");
                    _QiNiuYunServiceClient.Timeout = int.Parse(ConfigurationManager.AppSettings["WebApiTimeOut"]);
                }
                return _QiNiuYunServiceClient;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            pbUpload.Value = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文件夹";
            if (rdbClient.Checked)
            {
                dialog.Filter = ".rar文件(.rar)|*.rar";
            }
            else
            {
                dialog.Filter = ".exe文件(.exe)|*.exe";
            }            
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFilePath.Text = dialog.FileName;
                System.IO.FileInfo info = new System.IO.FileInfo(dialog.FileName);
                tbUploadName.Text = info.Name;
                if (rdbUpdateApp.Checked)
                {
                    System.Diagnostics.FileVersionInfo file = System.Diagnostics.FileVersionInfo.GetVersionInfo(dialog.FileName);
                    tbVer.Text = "V" + file.FileVersion;
                }
                else
                {
                    tbVer.Text = info.Name.Remove(info.Name.Length - info.Extension.Length);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text.Trim()))
            {
                MessageBox.Show("发布文件不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(tbUploadName.Text.Trim()))
            {
                MessageBox.Show("服务器文件名不能为空！");
                return;
            }
            System.IO.FileInfo info = new System.IO.FileInfo(tbFilePath.Text.Trim());            
            if (!info.Exists)
            {
                MessageBox.Show("本地不存在该文件，请检查！"+tbFilePath.Text.Trim());
                return;
            }
            pbUpload.Minimum = 0;
            pbUpload.Maximum = (int)info.Length;
            pbUpload.Value = 0;
            btnUpload.Enabled = false;
            Thread demoThread = new Thread(new ThreadStart(Upload));
            demoThread.IsBackground = true;
            demoThread.Start();//启动线程 
        }

        private void Upload()
        {
            try
            {
                string key = tbUploadName.Text.Trim();
                string filePath = tbFilePath.Text.Trim();
                RestRequest req = new RestRequest("GetUploadToken" , Method.GET);
                req.AddParameter("key",key);
                var res = AutoUpdateServiceClient.Execute(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                string token = res.Content.Trim(new char[] { '"' });
                Config config = new Config();
                // 设置上传区域
                config.Zone = Zone.ZONE_CN_South;
                // 设置 http 或者 https 上传
                config.UseHttps = true;
                config.UseCdnDomains = true;
                config.ChunkSize = ChunkUnit.U1024K;//.U512K;
                ResumableUploader target = new ResumableUploader(config);
                PutExtra extra = new PutExtra();
                extra.ProgressHandler = new UploadProgressHandler(UploadProgress);
                //设置断点续传进度记录文件
                //extra.ResumeRecordFile = ResumeHelper.GetDefaultRecordKey(filePath, key);
                extra.ResumeRecordFile = key + ".progress";
                HttpResult result = target.UploadFile(filePath, AutoUpdatePath + key, token, extra);
                if (result.Code != (int)HttpCode.OK)
                {
                    MessageBox.Show("上传失败！" + result.ToString());
                }
                else
                {
                    MessageBox.Show("上传成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错:" + ex.Message);
            }
            finally
            {
                btnUpload.Enabled = true;
            }
        }

        private void UploadProgress(long uploadedBytes, long totalBytes)
        {
            pbUpload.Maximum = (int)totalBytes;
            pbUpload.Value = (int)uploadedBytes;
        }

        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbClient.Checked)//提交更新客户端
                {
                    if (!tbUploadName.Text.Trim().ToLower().EndsWith(".rar"))
                    {
                        MessageBox.Show("提交更新客户端，服务器文件名后辍需要为 .rar 格式！");
                        return;
                    }
                    if (!Verify())
                        return;
                    RestRequest req = new RestRequest("AddVer", Method.POST);
                    UpdateVerDto model = new UpdateVerDto();
                    model.Ver = tbVer.Text.Trim();
                    model.UpdatePackName = tbUploadName.Text.Trim();
                    model.Remark = rtbRemark.Text.Trim();
                    req.AddObject(model);
                    var res = AutoUpdateServiceClient.Execute(req);
                    if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                    int re = int.Parse(res.Content);
                    if (re > 0)
                    {
                        MessageBox.Show("提交成功！");
                    }
                    else
                    {
                        MessageBox.Show("提交失败！");
                    }
                }
                else//提交更新更新App
                {
                    if (!tbUploadName.Text.Trim().ToLower().EndsWith(".exe"))
                    {
                        MessageBox.Show("提交更新App，服务器文件名后辍需要为 .exe 格式！");
                        return;
                    }
                    if (!Verify())
                        return;
                    RestRequest req = new RestRequest("AddAutoUpdateAppVer", Method.POST);
                    AppUpdateVerDto model = new AppUpdateVerDto();
                    model.Ver = tbVer.Text.Trim();
                    model.UpdatePackName = tbUploadName.Text.Trim();
                    model.Remark = rtbRemark.Text.Trim();
                    req.AddObject(model);
                    var res = AutoUpdateServiceClient.Execute(req);
                    if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                    int re = int.Parse(res.Content);
                    if (re > 0)
                    {
                        MessageBox.Show("提交成功！");
                    }
                    else
                    {
                        MessageBox.Show("提交失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错:" + ex.Message);
            }
        }

        private bool Verify()
        {
            if (string.IsNullOrEmpty(tbVer.Text.Trim()))
            {
                MessageBox.Show("版本号不能为空！");
                return false;
            }
            if (!IsUpload(AutoUpdatePath + tbUploadName.Text.Trim()))
            {
                MessageBox.Show("服务器未上传该文件：" + tbUploadName.Text.Trim());
                return false;
            }
            if (rdbClient.Checked)//提交更新客户端
            {
                RestRequest req = new RestRequest("ExistVer/" + tbVer.Text.Trim(), Method.GET);
                var res = AutoUpdateServiceClient.Execute(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                string result = res.Content;
                if (result.ToLower().Contains("true"))
                {
                    MessageBox.Show("该版本号已经存在！请检查！");
                    return false;
                }
            }
            else//提交更新更新App
            {
                RestRequest req = new RestRequest("ExistAutoUpdateAppVer/" + tbVer.Text.Trim(), Method.GET);
                var res = AutoUpdateServiceClient.Execute(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                string result = res.Content;
                if (result.ToLower().Contains("true"))
                {
                    MessageBox.Show("该版本号已经存在！请检查！");
                    return false;
                }
            }
            return true;
        }

        private bool IsUpload(string filename)
        {
            RestRequest req = new RestRequest("GetListFiles", Method.GET);
            req.AddParameter("prefix", filename);
            var res = AutoUpdateServiceClient.Execute<List<string>>(req);
            if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
            foreach (string name in res.Data)
            {
                if (filename.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                lvFileList.Items.Clear();
                RestRequest req = new RestRequest("GetListFiles", Method.GET);
                if (ckbDefault.Checked)
                    req.AddParameter("prefix", AutoUpdatePath);
                var res = AutoUpdateServiceClient.Execute<List<string>>(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                foreach (string name in res.Data)
                {
                    ListViewItem itm = new ListViewItem(name);
                    lvFileList.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错:" + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (lvFileList.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("请选中要删除的文件！");
                    return;
                }
                string key = lvFileList.SelectedItems[0].Text;
                RestRequest req = new RestRequest("DelFile", Method.GET);
                req.AddParameter("key", key);
                var res = AutoUpdateServiceClient.Execute(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                string result = res.Content;
                if (result.ToLower().Contains("true"))
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错:" + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnGetDownloadUrl_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbUploadName.Text.Trim()))
                {
                    MessageBox.Show("服务器文件名不能为空！");
                    return;
                }
                string key = tbUploadName.Text.Trim();
                RestRequest req = new RestRequest("GetDownloadUrl", Method.GET);
                if (ckbDefault.Checked)
                    key = AutoUpdatePath + key;
                req.AddParameter("key", key);
                var res = QiNiuYunServiceClient.Execute(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                string downloadUrl = res.Content.Trim(new char[] { '"' });
                tbDownloadUrl.Text = downloadUrl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错:" + ex.Message);
            }
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            using (FrmHelp frm = new FrmHelp())
            {
                frm.ShowDialog();
            }
        }

        private void lvFileList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (lvFileList.SelectedItems.Count > 0)
                {
                    //将复制的内容放入剪切板中
                    if (lvFileList.SelectedItems[0].Text != "")
                        Clipboard.SetDataObject(lvFileList.SelectedItems[0].Text);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (msg.Msg)
            {
                case 0x100:
                case 0x104:
                    switch (keyData)
                    {
                        case Keys.Alt | Keys.S:
                            if (btnDel.Visible)
                            {
                                btnDel.Visible = false;
                                lblDownloadUrl.Visible = false;
                                tbDownloadUrl.Visible = false;
                                btnGetDownloadUrl.Visible = false;
                                btnRefreshCDN.Visible = false;
                            }
                            else
                            {
                                btnDel.Visible = true;
                                lblDownloadUrl.Visible = true;
                                tbDownloadUrl.Visible = true;
                                btnGetDownloadUrl.Visible = true;
                                btnRefreshCDN.Visible = true;
                                ckbDefault.Visible = true;
                            }
                            break;
                        case Keys.Alt | Keys.C:
                            using (FrmConfig frm = new FrmConfig())
                            {
                                if (frm.ShowDialog() == DialogResult.OK)
                                {
                                    _AutoUpdateServiceClient = null;
                                }
                            }
                            break;
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRefreshCDN_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (string.IsNullOrEmpty(tbUploadName.Text.Trim()))
                {
                    MessageBox.Show("服务器文件名不能为空！");
                    return;
                }
                string key = tbUploadName.Text.Trim();
                RestRequest req = new RestRequest("RefreshCDNUrl", Method.GET);
                if (ckbDefault.Checked)
                    key = AutoUpdatePath + key;
                req.AddParameter("key", key);
                var res = AutoUpdateServiceClient.Execute(req);
                if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
                string result = res.Content;
                if (result.ToLower().Contains("true"))
                {
                    MessageBox.Show("刷新CDN成功！");
                }
                else
                {
                    MessageBox.Show("刷新CDN失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错:" + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
