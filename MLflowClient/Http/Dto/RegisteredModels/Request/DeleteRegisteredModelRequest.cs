using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class DeleteRegisteredModelRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
