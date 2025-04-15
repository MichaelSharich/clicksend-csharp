:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off


if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\IO.ClickSend\packages.config -o packages

if not exist ".\bin" mkdir bin

dotnet --version >nul 2>&1
IF ERRORLEVEL 1 (
    echo .NET SDK not found. Please install it from https://dotnet.microsoft.com/download
    pause
    exit /b
)

copy packages\Newtonsoft.Json.13.0.3\lib\netstandard2.0\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.112.1.0\lib\net48\RestSharp.dll bin\RestSharp.dll
copy packages\JsonSubTypes.2.0.1\lib\netstandard2.0\JsonSubTypes.dll bin\JsonSubTypes.dll

dotnet build src/IO.ClickSend/IO.ClickSend.csproj --configuration Debug -o bin\IO.ClickSend --source packages
