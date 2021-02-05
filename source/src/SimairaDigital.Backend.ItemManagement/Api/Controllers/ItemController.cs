namespace SimairaDigital.Backend.ItemManagement.Api.Controllers
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;
    using SimairaDigital.Backend.ItemManagement.Api.Common;
    using Swashbuckle.AspNetCore.Annotations;

    public class ItemController : ControllerBase
    {
        private const string ItemTag = "ItemTag";
        private readonly ILogger<ItemController> _logger;
        private readonly IUserAuthorization _authorizer;

        public ItemController(
           ILogger<ItemController> logger,
           IUserAuthorization authorizer)
        {
            _logger = logger;
            _authorizer = authorizer;
        }

        [HttpGet]
        [SwaggerOperation(
            OperationId = nameof(GetItemsAsync),
            Produces = new[] { "application/json" },
            Tags = new[] { ItemTag })]
        [SwaggerResponse(StatusCodes.Status200OK, nameof(StatusCodes.Status200OK))]
        [SwaggerResponse(StatusCodes.Status401Unauthorized, nameof(StatusCodes.Status401Unauthorized))]
        [SwaggerResponse(StatusCodes.Status403Forbidden, nameof(StatusCodes.Status403Forbidden))]
        [SwaggerResponse(StatusCodes.Status404NotFound, nameof(StatusCodes.Status404NotFound))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, nameof(StatusCodes.Status500InternalServerError))]
        [FunctionName(nameof(GetItemsAsync))]
        public async Task<IActionResult> GetItemsAsync(
            [HttpTrigger(AuthorizationLevel.Function, "GET", Route = "Item/{vendor}/{category}/{id}")] HttpRequestMessage req, string vendor, string category, string id)
        {
            try
            {
                string[] permittedActions = { "View" };
                var (isAuthorized, _, error) = await _authorizer.IsUserAuthorizedAsync(req, permittedActions).ConfigureAwait(false);
                if (!isAuthorized)
                {
                    return error;
                }

                return Ok(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }
    }
}
