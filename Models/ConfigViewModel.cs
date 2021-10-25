using Newtonsoft.Json;

namespace ApiTestFramework.Models
{
    public class ConfigViewModel
    {
        [JsonProperty("BaseUrl")]
        public string BaseUrl { get; set; } 
    }
}
