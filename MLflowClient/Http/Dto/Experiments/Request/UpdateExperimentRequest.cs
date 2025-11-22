using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class UpdateExperimentRequest
    {
        [Required]
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [Required]
        [JsonProperty("new_name")]
        public string NewName { get; set; }
    }
}
