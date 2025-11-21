using Newtonsoft.Json;

namespace MLflowClient.Http.Models
{
    public class ExperimentTag
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        public ExperimentTag(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}