:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\IO.ClickSend\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.13.0.3\lib\netstandard2.0\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\JsonSubTypes.1.8.0\lib\netstandard2.0\JsonSubTypes.dll bin\JsonSubTypes.dll
copy packages\RestSharp.112.1.0\lib\net48\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\JsonSubTypes.dll;bin\RestSharp.dll;bin\ /target:library /out:bin\IO.ClickSend.dll /recurse:src\IO.ClickSend\*.cs /doc:bin\IO.ClickSend.xml

