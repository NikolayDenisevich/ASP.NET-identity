﻿# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .

WORKDIR ./src/IdentityWebApi
RUN dotnet restore "IdentityWebApi.csproj"
RUN dotnet publish "IdentityWebApi.csproj" -c Release -o /publish --no-restore

# Serve stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
RUN groupadd -r nonrootgroup && useradd -r -g nonrootgroup nonrootuser
WORKDIR /app
COPY --from=build /publish ./
USER nonrootuser
ENTRYPOINT ["dotnet", "IdentityWebApi.dll"]
