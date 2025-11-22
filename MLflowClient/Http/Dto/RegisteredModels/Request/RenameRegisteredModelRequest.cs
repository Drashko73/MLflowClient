using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class RenameRegisteredModelRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("new_name")]
        public string? NewName { get; set; }
    }
}
