using Newtonsoft.Json;

namespace MLflowClient.Http.Models
{
    public class FileInfo
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("is_dir")]
        public bool IsDir { get; set; }

        [JsonProperty("file_size")]
        public long? FileSize { get; set; }

        public FileInfo(string path, bool isDir)
        {
            Path = path;
            IsDir = isDir;
        }
    }
}
