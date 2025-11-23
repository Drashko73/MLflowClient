# MLflowClient

A .NET client library for the MLflow Tracking Server REST API. This library allows you to interact with MLflow from your .NET applications (supporting .NET 6.0, and 8.0).

## Features

- **Experiments**: Create, search, get, delete, restore, update, and tag experiments.
- **Runs**: Create, delete, restore, get, search, and update runs.
- **Logging**: Log metrics, parameters, and tags to runs.
- **Models**: Manage registered models, model versions, and transitions.
- **Artifacts**: List artifacts.

## Installation

Install via NuGet Package Manager (Not published yet, example command below):

```bash
Install-Package MLflowClient
```

## Getting Started

### Initialization

You can initialize the client with a base URL or an existing `HttpClient`.

```csharp
using MLflowClient;

// Initialize with base URL
var client = new MLflowHttpClient("http://localhost:5000");

// Or with HttpClient
var httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000") };
var client = new MLflowHttpClient(httpClient);
```

### Examples

#### Create an Experiment

```csharp
using MLflowClient.Http.Dto.Experiments.Request;

var request = new CreateExperimentRequest 
{ 
    Name = "My New Experiment",
    ArtifactLocation = "s3://my-bucket/artifacts"
};

var response = await client.CreateExperiment(request);
Console.WriteLine($"Created Experiment ID: {response.ExperimentId}");
```

#### Create a Run

```csharp
using MLflowClient.Http.Dto.Runs.Request;
using MLflowClient.Http.Models;

var createRunRequest = new CreateRunRequest 
{ 
    ExperimentId = "1",
    RunName = "My Run",
    StartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
    Tags = new List<RunTag> { new RunTag { Key = "user", Value = "me" } }
};

var runResponse = await client.CreateRun(createRunRequest);
string runId = runResponse.Run.Info.RunId;
```

#### Log Metrics and Parameters

```csharp
using MLflowClient.Http.Dto.Runs.Request;

// Log a metric
var logMetricRequest = new LogRunMetricRequest 
{ 
    RunId = runId, 
    Key = "accuracy", 
    Value = 0.95, 
    Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
    Step = 1
};
await client.LogRunMetric(logMetricRequest);

// Log a parameter
var logParamRequest = new LogRunParamRequest 
{ 
    RunId = runId, 
    Key = "learning_rate", 
    Value = "0.01" 
};
await client.LogRunParam(logParamRequest);
```

#### Search Experiments

```csharp
using MLflowClient.Http.Dto.Experiments.Request;

var searchRequest = new SearchExperimentsRequest
{
    Filter = "name LIKE 'My New Experiment'",
    MaxResults = 10
};

var searchResponse = await client.SearchExperiments(searchRequest);
foreach (var experiment in searchResponse.Experiments)
{
    Console.WriteLine($"Found Experiment: {experiment.Name}");
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details.
