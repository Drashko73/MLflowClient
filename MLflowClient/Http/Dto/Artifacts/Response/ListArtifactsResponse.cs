using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto.Artifacts.Response
{
    public class ListArtifactsResponse
    {
        [JsonProperty("root_uri")]
        public string RootUri { get; set; }
        [JsonProperty("files")]
        public List<FileInfo> Files { get; set; } = new List<FileInfo>();
        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }
    }
}
