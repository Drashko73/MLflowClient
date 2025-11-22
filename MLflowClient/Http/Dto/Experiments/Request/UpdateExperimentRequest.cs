using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class UpdateExperimentRequest
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [JsonProperty("new_name")]
        public string NewName { get; set; }
    }
}
