//////////////////////////////////////////////////////////////////////
// PROJECT CONFIG
//////////////////////////////////////////////////////////////////////

#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#tool nuget:?package=Wyam&version=2.2.0
#tool "nuget:?package=GitVersion.CommandLine"
#tool "nuget:?package=GitReleaseNotes"
#addin nuget:?package=Cake.Wyam&version=2.1.3
#addin nuget:?package=Cake.SemVer
#addin nuget:?package=semver&version=2.0.4
#addin "Cake.Git"



var projectName = "SimairaDigital.Backend.ItemManagement";
var projectKey = "SimairaDigital.Backend.ItemManagement";

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var path = Argument("path", ".");

var projectFile = Directory(path + "/source/src/SimairaDigital.Backend.ItemManagement");
var sourceDir = Directory(path + "/source");

var outputDir = path + "/artifacts/";
var solution = path + "/source/SimairaDigital.Backend.ItemManagement.sln";
var version = "v0.0.1";
var gitUser = "";
var gitPassword = "";
var apiKey = "AzureArtifacts";

//////////////////////////////////////////////////////////////////////
// BUILD TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() => {
        if (DirectoryExists(outputDir))
        {
            DeleteDirectory(outputDir, recursive:true);
        }
        CreateDirectory(outputDir);
});

Task("Restore")
    .Does(() => {
        DotNetCoreRestore(sourceDir);
});

Task("Version")
    .Does(() =>
{
    var tags = GitTags(path);
    var versionInfo = GitVersion(new GitVersionSettings{ OutputType = GitVersionOutput.Json });

    if (tags.Count > 0)
    {
    Information("last tag: " + tags[tags.Count-1]);
    Information("Last Version: " +  tags[tags.Count-1].ToString().Split('/')[2]);
    version = tags[tags.Count-1].ToString().Split('/')[2];
    }
    var prerelease = "";
    var versionList = version.Split('.');
    int major = int.Parse(versionList[0].Replace("v", ""));
    int minor = int.Parse(versionList[1]);
    int patch = 0;
    if (version.Contains("alpha"))
        {
            Information("Tag is Prerelease Section with alpha : ");
            prerelease ="alpha" + versionInfo.CommitsSinceVersionSourcePadded;
            Information("rc");
        }
        else
        {
            Information("Tag is Prerelease Section without alpha : ");
            minor = minor + 1;
            patch = 0;
            prerelease = "alpha" + versionInfo.CommitsSinceVersionSourcePadded;
            
        }  

    version = CreateSemVer(major, minor, patch, prerelease).ToString();
    Information("Next Version: " + version);
    var propsFile = projectFile + File("./SimairaDigital.Bakend.Models.Food.csproj");
    var updatedProjectFile = System.IO.File.ReadAllText(propsFile)
        .Replace("0.0.0.0", version);

    System.IO.File.WriteAllText(propsFile, updatedProjectFile);
});

Task("package")
    .Does(() =>
{
    var settings = new DotNetCorePackSettings
        {
            OutputDirectory = outputDir,
            NoBuild = false,
            IncludeSymbols = true
        };

    DotNetCorePack(projectFile + File("./SimairaDigital.Backend.ItemManagement.csproj"), settings);
});

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(() => {
        MSBuild(solution);
    });
///////////////////////////////////////////////////////////////////////////////
// PRIMARY TARGETS
///////////////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("Version")
    .IsDependentOn("Package")
    ;
///////////////////////////////////////////////////////////////////////////////
// EXECUTION
///////////////////////////////////////////////////////////////////////////////

RunTarget(target);
