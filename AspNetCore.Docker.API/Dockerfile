FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 62702
EXPOSE 44398

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY AspNetCore.Docker.API/AspNetCore.Docker.API.csproj AspNetCore.Docker.API/
RUN dotnet restore AspNetCore.Docker.API/AspNetCore.Docker.API.csproj
COPY . .
WORKDIR /src/AspNetCore.Docker.API
RUN dotnet build AspNetCore.Docker.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AspNetCore.Docker.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspNetCore.Docker.API.dll"]
