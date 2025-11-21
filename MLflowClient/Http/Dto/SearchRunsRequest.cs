using MLflowClient.Http.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MLflowClient.Http.Dto
{
    public class SearchRunsRequest
    {
        public List<string> ExperimentIds { get; set; } = new List<string>();
        public string Filter { get; set; }
        public ViewType RunViewType { get; set; }
        public int MaxResults { get; set; }
        public List<string> OrderBy { get; set; } = new List<string>();
        public string PageToken { get; set; }
    }
}
