FROM microsoft/aspnetcore:2.0 AS base

COPY . /app
WORKDIR /app

EXPOSE 30000/tcp
ENV ASPNETCORE_URLS http://+:30000
COPY ${source:-bin/Release/netcoreapp2.0/publish} .
ENTRYPOINT dotnet TodoApi.dll