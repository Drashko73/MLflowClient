using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class UpdateRegisteredModelRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
