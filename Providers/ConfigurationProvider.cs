using ApiTestFramework.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ApiTestFramework.Providers
{
    public class ConfigurationProvider
    {
        private const string configPath = "appsettings.json";

        public static ConfigViewModel Read()
        {
            var jsonFile = File.ReadAllText(configPath);
            var config = JsonConvert.DeserializeObject<ConfigViewModel>(jsonFile);
            return config;
        }
    }
}
