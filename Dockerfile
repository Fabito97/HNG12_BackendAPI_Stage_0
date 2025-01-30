# Use .Net 8.0 SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HNG12BackendAPIStage0/HNG12BackendAPIStage0.csproj", "HNG12BackendAPIStage0/"]
RUN dotnet restore "HNG12BackendAPIStage0/HNG12BackendAPIStage0.csproj"
COPY . .
WORKDIR "/src/HNG12BackendAPIStage0"
RUN dotnet build "HNG12BackendAPIStage0.csproj" -c Release -o /app/build

# Publish the application for production
FROM build AS publish
RUN dotnet publish "HNG12BackendAPIStage0.csproj" -c Release -o /app/publish

# Use ASP.NET 8.0 image for building the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Copy the published application to the base image
COPY --from=publish /app/publish .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "HNG12BackendAPIStage0.dll"]