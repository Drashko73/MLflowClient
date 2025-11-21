using MLflowClient.Http.Dto;
using System.Threading.Tasks;

namespace MLflowClient.Interfaces
{
    public interface IMLflowHttpClient
    {
        Task<CreateExperimentResponse> CreateExperiment(CreateExperimentRequest request);
        Task<SearchRunsResponse> SearchRuns(SearchRunsRequest request);
        Task<MetricHistoryResponse> GetMetricHistory(MetricHistoryRequest request);
    }
}