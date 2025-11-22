using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class DeleteExperimentRequest
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
    }
}
