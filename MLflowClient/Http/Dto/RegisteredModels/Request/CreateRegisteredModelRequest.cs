using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class CreateRegisteredModelRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tags")]
        public List<RegisteredModelTag> Tags { get; set; } = new();
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
