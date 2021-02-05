namespace SimairaDigital.Backend.ItemManagement
{
    using System;

    public interface IAppConfiguration
    {
        string Environment { get; }

        SecretSource SecretSource { get; }

        string KeyVaultName { get; }

        string KeyVaultSecretName { get; }

        string ServicePrincipalId { get; }

        string ServicePrincipalSecret { get; }

        // Device Management parameters
        Uri TopologyManagementUri { get; }

        Uri CosmosDatabaseEndpointUrl { get; }

        Uri TelemetryUri { get; }

        string CosmosDatabaseAuthorizationKey { get; }

        string CosmosDatabaseId { get; }

        string ApplicationInsightsInstrumentationKey { get; }

        string HealthCheckAuthenticationToken { get; }
    }
}
