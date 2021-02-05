//////////////////////////////////////////////////////////////////////
// PROJECT CONFIG
//////////////////////////////////////////////////////////////////////

#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#tool nuget:?package=Wyam&version=2.2.0
#tool "nuget:?package=GitVersion.CommandLine"
#tool "nuget:?package=GitReleaseNotes"
#addin nuget:?package=Cake.Wyam&version=2.1.3
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
var version = "0.0.1";
var gitUser = "";
var gitPassword = "";
var apiKey = "";

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
    var versionInfo = GitVersion(new GitVersionSettings{ OutputType = GitVersionOutput.Json });
    var branch =  versionInfo.BranchName; // releases/v1.1.0
    version = branch.Split('/')[1].Replace("v", "");
    Information("Version: " + version);
    var propsFile = projectFile + File("./SimairaDigital.Backend.ItemManagement.csproj");
    var updatedProjectFile = System.IO.File.ReadAllText(propsFile)
        .Replace("0.0.0.0", version);

    System.IO.File.WriteAllText(propsFile, updatedProjectFile);
});

Task("Package")
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

Task("Release")
    .Does(() =>
{
    var changelog = System.IO.File.ReadAllText(path + "/docs/changelog.md");
    if (string.IsNullOrEmpty(changelog))
    {
        System.IO.File.WriteAllText(outputDir +"releasenotes.md", "No issues closed since last release");
    }
    else
    {
        System.IO.File.WriteAllText(outputDir +"releasenotes.md", changelog);
    }

    GitTag(path, ("v" + version));
    GitPushRef(path, gitUser, gitPassword, "origin", ("v" + version));
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
    .IsDependentOn("Version")
    .IsDependentOn("Package")
    .IsDependentOn("Release")
    ;

///////////////////////////////////////////////////////////////////////////////
// EXECUTION
///////////////////////////////////////////////////////////////////////////////

RunTarget(target);
