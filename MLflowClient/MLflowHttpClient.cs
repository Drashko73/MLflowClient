using MLflowClient.Api;
using MLflowClient.Http;
using MLflowClient.Http.Dto;
using MLflowClient.Http.Dto.Artifacts.Request;
using MLflowClient.Http.Dto.Artifacts.Response;
using MLflowClient.Http.Dto.Experiments.Request;
using MLflowClient.Http.Dto.Experiments.Response;
using MLflowClient.Http.Dto.Runs.Request;
using MLflowClient.Http.Dto.Runs.Response;
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

        // Experiments
        public async Task<CreateExperimentResponse> CreateExperiment(CreateExperimentRequest request) => await _apiClient.Post<CreateExperimentRequest, CreateExperimentResponse>(MLflowApi.ExperimentsCreate, request);
        public async Task<SearchExperimentsResponse> SearchExperiments(SearchExperimentsRequest request) => await _apiClient.Post<SearchExperimentsRequest, SearchExperimentsResponse>(MLflowApi.ExperimentsSearch, request);
        public async Task<GetExperimentResponse> GetExperiment(GetExperimentRequest request) => await _apiClient.GetWithBody<GetExperimentRequest, GetExperimentResponse>(MLflowApi.ExperimentsGet, request);
        public async Task<GetExperimentResponse> GetExperimentByName(GetExperimentByNameRequest request) => await _apiClient.GetWithBody<GetExperimentByNameRequest, GetExperimentResponse>(MLflowApi.ExperimentsGetByName, request);
        public async void DeleteExperiment(DeleteExperimentRequest request) => await _apiClient.Post(MLflowApi.ExperimentsDelete, request);
        public async void RestoreExperiment(RestoreExperimentRequest request) => await _apiClient.Post(MLflowApi.ExperimentsRestore, request);
        public async void UpdateExperiment(UpdateExperimentRequest request) => await _apiClient.Post(MLflowApi.ExperimentsUpdate, request);
        public async void SetExperimentTag(SetExperimentTagRequest request) => await _apiClient.Post(MLflowApi.ExperimentsSetTag, request);

        // Runs
        public async Task<CreateRunResponse> CreateRun(CreateRunRequest request) => await _apiClient.Post<CreateRunRequest, CreateRunResponse>(MLflowApi.RunsCreate, request);
        public async void DeleteRun(DeleteRunRequest request) => await _apiClient.Post(MLflowApi.RunsDelete, request);
        public async void RestoreRun(RestoreRunRequest request) => await _apiClient.Post(MLflowApi.RunsRestore, request);
        public async Task<SearchRunsResponse> SearchRuns(SearchRunsRequest request) => await _apiClient.Post<SearchRunsRequest, SearchRunsResponse>(MLflowApi.RunsSearch, request);
        public async Task<GetRunResponse> GetRun(GetRunRequest request) => await _apiClient.GetWithBody<GetRunRequest, GetRunResponse>(MLflowApi.RunsGet, request);
        public async void LogRunMetric(LogRunMetricRequest request) => await _apiClient.Post(MLflowApi.RunsLogMetric, request);
        public async void LogRunBatch(LogRunBatchRequest request) => await _apiClient.Post(MLflowApi.RunsLogBatch, request);
        public async void SetRunTag(SetRunTagRequest request) => await _apiClient.Post(MLflowApi.RunsSetTag, request);
        public async void DeleteRunTag(DeleteRunTagRequest request) => await _apiClient.Post(MLflowApi.RunsDeleteTag, request);
        public async void LogRunParam(LogRunParamRequest request) => await _apiClient.Post(MLflowApi.RunsLogParam, request);
        public async Task<UpdateRunResponse> UpdateRun(UpdateRunRequest request) => await _apiClient.Post<UpdateRunRequest, UpdateRunResponse>(MLflowApi.RunsUpdate, request);

        // Metrics
        public async Task<MetricHistoryResponse> GetMetricHistory(MetricHistoryRequest request) => await _apiClient.GetWithBody<MetricHistoryRequest, MetricHistoryResponse>(MLflowApi.MetricsGetHistory, request);

        // Artifacts
        public async Task<ListArtifactsResponse> ListArtifacts(ListArtifactsRequest request) => await _apiClient.GetWithBody<ListArtifactsRequest, ListArtifactsResponse>(MLflowApi.ArtifactsList, request);
    }
}
