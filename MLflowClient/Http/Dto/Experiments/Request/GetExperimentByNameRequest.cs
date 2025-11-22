using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class GetExperimentByNameRequest
    {
        [Required]
        [JsonProperty("experiment_name")]
        public string ExperimentName { get; set; }
    }
}
