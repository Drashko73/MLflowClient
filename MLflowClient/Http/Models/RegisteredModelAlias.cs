using Newtonsoft.Json;

namespace MLflowClient.Http.Models
{
    public class RegisteredModelAlias
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}