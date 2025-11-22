using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.ModelVersions.Request
{
    public class UpdateModelVersionRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
