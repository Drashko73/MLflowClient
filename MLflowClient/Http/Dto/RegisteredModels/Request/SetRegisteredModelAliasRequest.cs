using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MLflowClient.Http.Dto.RegisteredModels.Request
{
    public class SetRegisteredModelAliasRequest
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [Required]
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
