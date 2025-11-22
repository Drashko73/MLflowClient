using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class GetExperimentByNameRequest
    {
        [JsonProperty("experiment_name")]
        public string ExperimentName { get; set; }
    }
}
