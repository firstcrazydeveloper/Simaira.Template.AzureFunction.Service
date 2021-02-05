namespace SimairaDigital.Backend.ItemManagement.Api.Models.Common
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Newtonsoft.Json;

    public class ErrorResponse : IActionResult
    {
        public ErrorResponse(string message, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Message = message;
        }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "statusCode")]
        public HttpStatusCode StatusCode { get; set; }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(this)
            {
                StatusCode = (int)StatusCode,
                Value = this,
                ContentTypes = new MediaTypeCollection(),
                Formatters = new FormatterCollection<IOutputFormatter>(new List<IOutputFormatter>()),
            };
            await objectResult.ExecuteResultAsync(context).ConfigureAwait(false);
        }
    }
}
