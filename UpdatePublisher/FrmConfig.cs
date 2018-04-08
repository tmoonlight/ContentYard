using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpdatePublisher
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            cmbUrl.Text = ConfigurationManager.AppSettings["WebApiUrl"];
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbUrl.Text.Trim()))
            {
                WriteConfigSetting(Path.Combine(System.Environment.CurrentDirectory, "UpdatePublisher.exe.config"), "WebApiUrl", cmbUrl.Text);
                ConfigurationManager.RefreshSection("appSettings");
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// 更新配置文件节点
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        private void WriteConfigSetting(string strConfig, string strKey, string strValue)
        {
            ExeConfigurationFileMap configFile = new ExeConfigurationFileMap();
            configFile.ExeConfigFilename = strConfig;
            Configuration appConf
                = ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);

            if (appConf.AppSettings.Settings[strKey] != null)
                appConf.AppSettings.Settings[strKey].Value = strValue;
            else
                appConf.AppSettings.Settings.Add(strKey, strValue);
            appConf.Save();
        }
    }
}
