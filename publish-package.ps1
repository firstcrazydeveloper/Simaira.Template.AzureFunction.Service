param (
    $path = "."
)
Write-Output "Path: $path"

$projectName = "SimairaDigital.Backend.ItemManagement"
$TOOLS_DIR = $path +  "\tools"
$artifacts_Dir = $path + "\artifacts"
$NUGET_EXE = $TOOLS_DIR  + "\nuget.exe"
$sourceUrl = "https://pkgs.dev.azure.com/abhishekjob/_packaging/Simaira-Digital/nuget/v3/index.json"

Write-Output "TOOLS_DIR: $TOOLS_DIR"
Write-Output "artifacts_Dir: $artifacts_Dir"
Write-Output "Path: $path"

$array = Get-ChildItem $artifacts_Dir -Filter "$projectName.*.nupkg" | Select

$packageFileName = ''
foreach ($element in $array) {
    Write-Output "Name: $element.Name"
	if ($element.Name -notlike "*symbols*") {
        $packageFileName = $element.Name
    }
}

$packageUrl = $artifacts_Dir + "\" + $packageFileName
Write-Output "My Package: $packageFileName"

Invoke-Expression "&`"$NUGET_EXE`" push  -Source `"$sourceUrl`" -ApiKey AzureArtifacts `"$packageUrl`""
Write-Output "Package Published"