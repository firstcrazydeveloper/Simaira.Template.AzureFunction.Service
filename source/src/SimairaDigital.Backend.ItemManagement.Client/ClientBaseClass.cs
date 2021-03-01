namespace SimairaDigital.Backend.ItemManagement.Client
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

#pragma warning disable // Disable all warnings
    public class ClientBaseClass
    {
        /// <summary>
        /// Token need to valiate the request
        /// </summary>
        public string Token { get; set; }

        protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage();
            if (Token == null || string.IsNullOrEmpty(Token))
            {
                throw new InvalidOperationException("Token is not set");
            }

            request.Headers.Add("Authorization", Token);
            return Task.FromResult(request);
        }
    }
}
