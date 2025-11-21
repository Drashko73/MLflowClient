using System;
using System.Net;

namespace MLflowClient.Exceptions
{
    public class MLflowException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string Content { get; }

        public MLflowException(string message) : base(message)
        {
        }

        public MLflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MLflowException(HttpStatusCode statusCode, string content)
            : base($"Request failed with status code {statusCode}: {content}")
        {
            StatusCode = statusCode;
            Content = content;
        }

        public MLflowException(HttpStatusCode statusCode, string content, Exception innerException)
            : base($"Request failed with status code {statusCode}: {content}", innerException)
        {
            StatusCode = statusCode;
            Content = content;
        }
    }
}
