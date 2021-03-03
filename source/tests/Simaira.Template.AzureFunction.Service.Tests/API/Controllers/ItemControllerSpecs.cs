namespace Simaira.Template.AzureFunction.Service.Tests.API.Controllers
{
    using System;
    using System.Net.Http;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class ItemControllerSpecs : IDisposable
    {
        private Exception _exception;
        private HttpRequestMessage _request;
        private HttpRequestMessage _authorized_Request;
        private HttpRequestMessage _unauthorized_Request;
        private HttpRequestMessage _forbidden_Request;

        public void Dispose()
        {
            ((IDisposable)_request).Dispose();
            ((IDisposable)_authorized_Request).Dispose();
            ((IDisposable)_unauthorized_Request).Dispose();
            ((IDisposable)_forbidden_Request).Dispose();
        }

        [TestInitialize]
        public virtual void InitTest()
        {
#pragma warning disable CA2201 // Do not raise reserved exception types
            _exception = new Exception();
#pragma warning restore CA2201 // Do not raise reserved exception types
            _request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://service.io?pageNumber=0&pageSize=25"));
            _authorized_Request = new HttpRequestMessage();
            _unauthorized_Request = new HttpRequestMessage();
            _forbidden_Request = new HttpRequestMessage();
        }
     }
}
