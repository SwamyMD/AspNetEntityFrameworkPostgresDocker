FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY AspNetEFCorePostgresDocker/AspNetEFCorePostgresDocker.csproj AspNetEFCorePostgresDocker/
RUN dotnet restore AspNetEFCorePostgresDocker/AspNetEFCorePostgresDocker.csproj
COPY . .
WORKDIR /src/AspNetEFCorePostgresDocker
RUN dotnet build AspNetEFCorePostgresDocker.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AspNetEFCorePostgresDocker.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspNetEFCorePostgresDocker.dll"]
