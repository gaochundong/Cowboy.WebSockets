Commands
------------
nuget setApiKey xxx-xxx-xxxx-xxxx

nuget push .\packages\Cowboy.WebSockets.1.0.0.0.nupkg
nuget pack ..\Cowboy.WebSockets\Cowboy.WebSockets\Cowboy.WebSockets.csproj -IncludeReferencedProjects -Symbols -Build -Prop Configuration=Release -OutputDirectory ".\packages"
