using MLflowClient.Http.Models;
using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.Experiments.Response
{
    public class GetExperimentResponse
    {
        [JsonProperty("experiment")]
        public Experiment Experiment { get; set; }
    }
}
