using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.Experiments.Request
{
    public class SetExperimentTagRequest
    {
        [Required]
        [JsonProperty("experiment_id")]
        public string ExperimentId { get; set; }
        [Required]
        [JsonProperty("key")]
        public string Key { get; set; }
        [Required]
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
