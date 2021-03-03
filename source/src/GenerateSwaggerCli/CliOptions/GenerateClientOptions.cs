namespace Simaira.Template.AzureFunction.Service.GenerateSwaggerCli.CliOptions
{
    using System.Diagnostics.CodeAnalysis;
    using CommandLine;

    [ExcludeFromCodeCoverage]
    [Verb("generateClient")]
    public class GenerateClientOptions
    {
        [Option("csFilePath", Required = true)]
        public string CsFilePath { get; set; }
    }
}
