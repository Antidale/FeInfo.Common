param(
    [string] $version = "1.0.0"
)

dotnet pack -p:Version=$version --output ~/LocalNuGet