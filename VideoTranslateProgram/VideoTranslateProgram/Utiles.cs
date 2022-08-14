using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    #region confighelper
    public class ConfigHelper
    {
        private string ConfigPath = string.Empty;

        /// <summary>
        /// 获取配置文件指定的Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetConfigKey(string key)
        {
            Configuration ConfigurationInstance = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
            {
                ExeConfigFilename = ConfigPath
            }, ConfigurationUserLevel.None);

            if (ConfigurationInstance.AppSettings.Settings[key] != null)
                return ConfigurationInstance.AppSettings.Settings[key].Value;
            else
                return string.Empty;
        }

        /// <summary>
        /// 设置配置文件指定的Key，如果Key不存在则添加
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vls"></param>
        /// <returns></returns>
        public bool SetConfigKey(string key, string vls)
        {
            try
            {
                Configuration ConfigurationInstance = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
                {
                    ExeConfigFilename = ConfigPath
                }, ConfigurationUserLevel.None);

                if (ConfigurationInstance.AppSettings.Settings[key] != null)
                    ConfigurationInstance.AppSettings.Settings[key].Value = vls;
                else
                    ConfigurationInstance.AppSettings.Settings.Add(key, vls);

                ConfigurationInstance.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="configPath">配置文件路径</param>
        public ConfigHelper(string configPath)
        {
            ConfigPath = configPath;
        }
    }
    #endregion
}
