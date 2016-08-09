using System;
using System.Net;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Infrastructure.Exceptions
{
    [Serializable]
    public class BadRequestException
        : XeroApiException
    {
        public BadRequestException() { }

        public BadRequestException(ApiException apiException)
            : base(HttpStatusCode.BadRequest, apiException.Message)
        {
            ErrorNumber = apiException.ErrorNumber;
            Type = apiException.Type;
            Json = apiException.Json;
        }

        public int ErrorNumber { get; private set; }
        public string Type { get; private set; }
        public string Json { get; private set; }   
    }
}
