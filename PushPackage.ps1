param(
    [string] $version = "1.0.0"
)

dotnet nuget push ~/LocalNuGet/FeInfo.Common.$version.nupkg --api-key $Env:FE_NugetApiKey
