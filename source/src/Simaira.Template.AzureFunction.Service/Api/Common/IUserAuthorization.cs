namespace Simaira.Template.AzureFunction.Service.Api.Common
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Simaira.Template.AzureFunction.Service.Api.Models.Common;

    public interface IUserAuthorization
    {
        Task<(bool isAuthorized, Token token, ErrorResponse error)> IsUserAuthorizedAsync(HttpRequestMessage request, string[] requiredPrivileges);

        (bool, ErrorResponse) IsHealthCheckAuthorized(HttpRequestMessage request);

        public (bool, Token, ErrorResponse) IsInternalService(HttpRequestMessage request);

        string GetRequestId(HttpRequestMessage request);
    }
}
