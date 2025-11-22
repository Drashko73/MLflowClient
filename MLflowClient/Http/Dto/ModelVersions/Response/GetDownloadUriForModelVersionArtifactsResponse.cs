using Newtonsoft.Json;

namespace MLflowClient.Http.Dto.ModelVersions.Response
{
    public class GetDownloadUriForModelVersionArtifactsResponse
    {
        [JsonProperty("artifact_uri")]
        public string ArtifactUri { get; set; }
    }
}
