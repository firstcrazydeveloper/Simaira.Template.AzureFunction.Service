namespace Simaira.Template.AzureFunction.Service.Api.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using EnsureThat;
    using Microsoft.AspNetCore.WebUtilities;
    using Microsoft.Extensions.Logging;
    using Simaira.Template.AzureFunction.Service.Api.Models.Common;

    public class UserAuthorization : IUserAuthorization
    {
        private const string AuthorizationKey = "Authorization";
        private const string RequestIdHeader = "Request-Id";

        private readonly ILogger<UserAuthorization> _logger;
        private readonly IAppConfiguration _configuration;

        public UserAuthorization(IAppConfiguration configuration, ILogger<UserAuthorization> logger)
        {
            EnsureArg.IsNotNull(configuration);
            EnsureArg.IsNotNull(logger);

            _logger = logger;
            _configuration = configuration;
        }

        public async Task<(bool, Token, ErrorResponse)> IsUserAuthorizedAsync(HttpRequestMessage request, string[] requiredPrivileges)
        {
            CheckRequiredParameters(request, requiredPrivileges);

            var token = GetToken(request, AuthorizationKey);
            if (token == null)
            {
                return await Task.FromResult<(bool, Token, ErrorResponse)>((false, null, new ErrorResponse("Token is required", HttpStatusCode.Unauthorized))).ConfigureAwait(false);
            }

            try
            {
                if (token != null)
                {
                    return await Task.FromResult<(bool, Token, ErrorResponse)>((true, token, null)).ConfigureAwait(false);
                }

                return await Task.FromResult<(bool, Token, ErrorResponse)>(
                    (false, null, new ErrorResponse("Not enough rights to execute this method", HttpStatusCode.Forbidden)
                    )).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public (bool, Token, ErrorResponse) IsInternalService(HttpRequestMessage request)
        {
            try
            {
                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var token = GetToken(request, AuthorizationKey);
                if (token == null)
                {
                    return (false, null, new ErrorResponse("Token is required", HttpStatusCode.Unauthorized));
                }

                if (token.IsInternalService)
                {
                    return (true, token, null);
                }

                return (false, null, new ErrorResponse("Not enough rights to execute this method", HttpStatusCode.Forbidden));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public (bool, ErrorResponse) IsHealthCheckAuthorized(HttpRequestMessage request)
        {
            try
            {
                if (request == null)
                {
                    return (false, new ErrorResponse("Token is required", HttpStatusCode.Unauthorized));
                }

                var query = QueryHelpers.ParseQuery(request.RequestUri.Query);
                var queryStringItems = query.SelectMany(x => x.Value, (col, value) => new KeyValuePair<string, string>(col.Key, value)).ToList();
                var token = queryStringItems.FirstOrDefault(i => i.Key == "token").Value;

                if (token != null && token == _configuration.HealthCheckAuthenticationToken)
                {
                    return (true, null);
                }

                return (false, new ErrorResponse("Not enough rights to execute this method", HttpStatusCode.Forbidden));
            }
            catch (Exception ex)
            {
                return (false, new ErrorResponse(ex.Message, HttpStatusCode.Unauthorized));
                throw;
            }
        }

        public string GetRequestId(HttpRequestMessage request)
        {
            EnsureArg.IsNotNull(request, nameof(request));
            var headerItem = request.Headers.FirstOrDefault(f => f.Key == RequestIdHeader);

            if (!headerItem.Equals(default(KeyValuePair<string, IEnumerable<string>>)))
            {
                var requestId = headerItem.Value.FirstOrDefault();
                try
                {
                    return string.IsNullOrEmpty(requestId) ? Guid.NewGuid().ToString() : requestId;
                }
                catch
                {
                    return Guid.NewGuid().ToString();
                }
            }

            return Guid.NewGuid().ToString();
        }

        private void CheckRequiredParameters(HttpRequestMessage request, string[] requiredPrivileges)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (requiredPrivileges == null)
            {
                throw new ArgumentNullException(nameof(requiredPrivileges));
            }
        }

        private string GetErpId(string path)
        {
            var pathParts = path.Split('/');

            var plantIndex = Array.IndexOf(pathParts, "plants");

            if (plantIndex != -1)
            {
                return pathParts[plantIndex + 1];
            }

            return string.Empty;
        }

        private Token GetToken(HttpRequestMessage request, string headerKey)
        {
            var headerItem = request.Headers.FirstOrDefault(f => f.Key == headerKey);

            if (!headerItem.Equals(default(KeyValuePair<string, IEnumerable<string>>)))
            {
                var authHeaderValue = headerItem.Value.FirstOrDefault();
                try
                {
                    return Token.GetToken(authHeaderValue);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    _logger.LogError(ex, ex.Message);
                    return null;
                }
            }

            return null;
        }
    }
}
