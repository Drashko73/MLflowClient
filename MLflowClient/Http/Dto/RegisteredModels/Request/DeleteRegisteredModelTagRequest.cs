using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class DeleteRegisteredModelTagRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
