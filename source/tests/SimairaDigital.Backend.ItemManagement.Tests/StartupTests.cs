namespace SimairaDigital.Backend.ItemManagement.Tests
{
    using System;
    using Microsoft.Extensions.Hosting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Swashbuckle.AspNetCore.Swagger;

    [TestClass]
    public class StartupTests
    {
        [TestMethod]
        public void Startup_WhenCalled_ThenObjectsInitialized()
        {
            // Arrange
            Environment.SetEnvironmentVariable("LOCAL_SETTINGS", "true");
            var startup = new Startup();
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(item => startup.Configure(item));

            // Act
            var host = builder.Build();

            // Assert
            Assert.IsNotNull(host.Services.GetService(typeof(IAppConfiguration)));
            Assert.IsNotNull(host.Services.GetService(typeof(ISwaggerProvider)));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Environment.SetEnvironmentVariable("ENVIRONMENT", "local");
            Environment.SetEnvironmentVariable("LOCAL_SETTINGS", "false");
        }
    }
}
