using Newtonsoft.Json;
using System.Reflection;
using System;

namespace ClassDefinitions.Models.Configuration
{
    [Serializable]
    public class ConfigManager
    {
        private ConfigurationModel _config = new ConfigurationModel();
        private string _configPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Resources\Json\DefaultConf.json");

        public ConfigurationModel Configuration
        {
            get
            {
                if (_config == null)
                {
                    Load();
                }

                return _config;
            }
            set { _config = value; }
        }

        public void Load()
        {
            _config = JsonConvert.DeserializeObject<ConfigurationModel>(File.ReadAllText(_configPath)) ?? _config;
        }

        public void Save()
        {
            File.WriteAllText(_configPath, JsonConvert.SerializeObject(_config));
        }
    }
}
