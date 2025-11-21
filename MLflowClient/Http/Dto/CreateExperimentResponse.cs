using Newtonsoft.Json;

namespace MLflowClient.Http.Dto
{
    public class CreateExperimentResponse
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
    }
}
