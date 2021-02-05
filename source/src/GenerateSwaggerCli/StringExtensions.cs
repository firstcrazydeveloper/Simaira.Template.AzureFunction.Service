namespace SimairaDigital.Backend.ItemManagement.GenerateSwaggerCli
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    [ExcludeFromCodeCoverage]
    public static class StringExtensions
    {
        public static string GetRootedPath(this string filePath)
        {
            string appFolder = Path.GetDirectoryName(typeof(StringExtensions).Assembly.Location);

            var expandedFilePath = Environment.ExpandEnvironmentVariables(filePath);

            if (!Path.IsPathRooted(expandedFilePath))
            {
                expandedFilePath = new DirectoryInfo(Path.Combine(appFolder, expandedFilePath)).FullName;
            }

            return expandedFilePath;
        }
    }
}
