FROM microsoft/dotnet:latest

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

EXPOSE 443/tcp

CMD ["dotnet", "run", "--server.urls", "https://aspnetcoressoperu.mybluemix.net"]
