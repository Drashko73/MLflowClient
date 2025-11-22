using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Experiments.Response
{
    public class CreateExperimentResponse
    {
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
    }
}
