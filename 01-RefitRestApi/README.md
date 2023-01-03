create project by
```
dotnet new globaljson --sdk-version 6.0.404
dotnet new console -f net6.0
dotnet add package Refit -v 6.3.2
dotnet add package Refit.HttpClientFactory -v 6.3.2
# for di/ioc
dotnet add package Microsoft.Extensions.Hosting -v 6.0.1
```