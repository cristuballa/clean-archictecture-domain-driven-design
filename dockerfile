# Use the official Microsoft .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env

# Set the working directory
WORKDIR /source

# Copy the solution and project files to the working directory
COPY src/*.csproj .
# Restore the solution and its dependencies
RUN dotnet restore --os linux --arch x64

COPY . .
# Build the solution
RUN dotnet publish -c Release -o /app  --os linux --arch x64 --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "WebApi.dll"]
# ENTRYPOINT ["dotnet", "WebApi.dll"]