using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class GetRegisteredModelRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
