# bubble
## 拡張
1. C#
1. Debugger for Firefox
1. Remote - WSL
1. vscode-solution-explorer

## ソリューション作成
```shell
dotnet new sln -n bubble
dotnet new mvc -n bubble.web -f netcoreapp3.1 --no-https true
dotnet sln add bubble.web
```

http://localhost:5000/


## SignalRの利用
```shell
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
libman install @microsoft/signalr@latest -p unpkg -d wwwroot/lib/signalr --files dist/browser/signalr.js --files dist/browser/signalr.min.js
```
