using System;
using System.Runtime.CompilerServices;

[assembly: CLSCompliant(false)]
[assembly: InternalsVisibleTo("SimairaDigital.Backend.ItemManagement.Tests")]

namespace SimairaDigital.Backend.ItemManagement
{
    using System;

    internal class AppConfiguration : IAppConfiguration
    {
        public string Environment => throw new NotImplementedException();

        public SecretSource SecretSource => throw new NotImplementedException();

        public string KeyVaultName => throw new NotImplementedException();

        public string KeyVaultSecretName => throw new NotImplementedException();

        public string ServicePrincipalId => throw new NotImplementedException();

        public string ServicePrincipalSecret => throw new NotImplementedException();

        public Uri TopologyManagementUri => throw new NotImplementedException();

        public Uri CosmosDatabaseEndpointUrl => throw new NotImplementedException();

        public Uri TelemetryUri => throw new NotImplementedException();

        public string CosmosDatabaseAuthorizationKey => throw new NotImplementedException();

        public string CosmosDatabaseId => throw new NotImplementedException();

        public string ApplicationInsightsInstrumentationKey => throw new NotImplementedException();

        public string HealthCheckAuthenticationToken => throw new NotImplementedException();
    }
}
