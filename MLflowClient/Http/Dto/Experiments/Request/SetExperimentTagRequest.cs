using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class SetExperimentTagRequest
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
