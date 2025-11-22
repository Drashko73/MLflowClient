using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class DeleteExperimentRequest
    {
        [Required]
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
    }
}
