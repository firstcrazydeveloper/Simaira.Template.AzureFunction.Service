namespace SimairaDigital.Backend.ItemManagement.GenerateSwaggerCli.CliOptions
{
    using System.Diagnostics.CodeAnalysis;
    using CommandLine;

    [ExcludeFromCodeCoverage]
    [Verb("generateSwagger")]
    public class GenerateSwaggerOptions
    {
        [Option("swaggerFilePath", Required = true)]
        public string SwaggerFilePath { get; set; }
    }
}
