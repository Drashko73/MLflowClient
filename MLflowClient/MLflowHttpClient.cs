using MLflowClient.Api;
using MLflowClient.Http;
using MLflowClient.Http.Dto;
using MLflowClient.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MLflowClient
{
    public class MLflowHttpClient : IMLflowHttpClient
    {
        private readonly ApiClient _apiClient;

        public MLflowHttpClient(HttpClient httpClient)
        {
            _apiClient = new ApiClient(httpClient);
        }

        public MLflowHttpClient(string baseUrl) : this(new Uri(baseUrl))
        {
        }

        public MLflowHttpClient(Uri baseUri)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = baseUri
            };
            _apiClient = new ApiClient(httpClient);
        }

        public async Task<CreateExperimentResponse> CreateExperiment(CreateExperimentRequest request)
        {
            return await _apiClient.Post<CreateExperimentRequest, CreateExperimentResponse>(MLflowApi.ExperimentsCreate, request);
        }

        public async Task<SearchRunsResponse> SearchRuns(SearchRunsRequest request)
        {
            return await _apiClient.Post<SearchRunsRequest, SearchRunsResponse>(MLflowApi.RunsSearch, request);
        }

        public async Task<MetricHistoryResponse> GetMetricHistory(MetricHistoryRequest request)
        {
            return await _apiClient.Post<MetricHistoryRequest, MetricHistoryResponse>(MLflowApi.MetricsGetHistory, request);
        }
    }
}
