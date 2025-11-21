namespace MLflowClient.Api
{
    public static class MLflowApi
    {
        public const string ExperimentsCreate = "api/2.0/mlflow/experiments/create";
        public const string ExperimentsSearch = "api/2.0/mlflow/experiments/search";
        public const string ExperimentsGet = "api/2.0/mlflow/experiments/get";
        public const string ExperimentsGetByName = "api/2.0/mlflow/experiments/get-by-name";
        public const string ExperimentsDelete = "api/2.0/mlflow/experiments/delete";
        public const string ExperimentsRestore = "api/2.0/mlflow/experiments/restore";
        public const string ExperimentsUpdate = "api/2.0/mlflow/experiments/update";
        public const string ExperimentsSetTag = "api/2.0/mlflow/experiments/set-experiment-tag";

        public const string RunsCreate = "api/2.0/mlflow/runs/create";
        public const string RunsDelete = "api/2.0/mlflow/runs/delete";
        public const string RunsRestore = "api/2.0/mlflow/runs/restore";
        public const string RunsGet = "api/2.0/mlflow/runs/get";
        public const string RunsLogMetric = "api/2.0/mlflow/runs/log-metric";
        public const string RunsLogBatch = "api/2.0/mlflow/runs/log-batch";
        public const string RunsLogModel = "api/2.0/mlflow/runs/log-model";
        public const string RunsSetTag = "api/2.0/mlflow/runs/set-tag";
        public const string RunsDeleteTag = "api/2.0/mlflow/runs/delete-tag";
        public const string RunsLogParam = "api/2.0/mlflow/runs/log-parameter";
        public const string RunsSearch = "api/2.0/mlflow/runs/search";
        public const string RunsUpdate = "api/2.0/mlflow/runs/update";

        public const string MetricsGetHistory = "api/2.0/mlflow/metrics/get-history";

        public const string ArtifactsList = "api/2.0/mlflow/artifacts/list";

        public const string RegisteredModelsCreate = "api/2.0/mlflow/registered-models/create";
        public const string RegisteredModelsGet = "api/2.0/mlflow/registered-models/get";
        public const string RegisteredModelsRename = "api/2.0/mlflow/registered-models/rename";
        public const string RegisteredModelsUpdate = "api/2.0/mlflow/registered-models/update";
        public const string RegisteredModelsDelete = "api/2.0/mlflow/registered-models/delete";
        public const string RegisteredModelsGetLatestVersions = "api/2.0/mlflow/registered-models/get-latest-versions";
        public const string RegisteredModelsSearch = "api/2.0/mlflow/registered-models/search";
        public const string RegisteredModelsSetTag = "api/2.0/mlflow/registered-models/set-tag";
        public const string RegisteredModelsDeleteTag = "api/2.0/mlflow/registered-models/delete-tag";
        public const string RegisteredModelsDeleteAlias = "api/2.0/mlflow/registered-models/delete-alias";
        public const string RegisteredModelsGetModelVersionByAlias = "api/2.0/mlflow/registered-models/alias";
        public const string RegisteredModelsSetAlias = "api/2.0/mlflow/registered-models/alias";

        public const string ModelVersionsCreate = "api/2.0/mlflow/model-versions/create";
        public const string ModelVersionsGet = "api/2.0/mlflow/model-versions/get";
        public const string ModelVersionsUpdate = "api/2.0/mlflow/model-versions/update";
        public const string ModelVersionsDelete = "api/2.0/mlflow/model-versions/delete";
        public const string ModelVersionsSearch = "api/2.0/mlflow/model-versions/search";
        public const string ModelVersionsGetDownloadUri = "api/2.0/mlflow/model-versions/get-download-uri";
        public const string ModelVersionsTransitionStage = "api/2.0/mlflow/model-versions/transition-stage";
        public const string ModelVersionsSetTag = "api/2.0/mlflow/model-versions/set-tag";
        public const string ModelVersionsDeleteTag = "api/2.0/mlflow/model-versions/delete-tag";
    }
}
