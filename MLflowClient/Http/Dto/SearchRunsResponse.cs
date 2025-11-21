using MLflowClient.Http.Models;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class SearchRunsResponse
    {
        public List<Run> Runs { get; set; } = new List<Run>();
        public string NextPageToken { get; set; }
    }
}
