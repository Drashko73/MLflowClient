using Newtonsoft.Json;

namespace MLflowClient.Http.Models
{
    public class RegisteredModelTag
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}