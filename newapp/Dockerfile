# Use the latest .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code and build the application
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Use the latest ASP.NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /app
COPY --from=build /app/publish ./

# Set environment variable for ASP.NET Core
ENV ASPNETCORE_URLS=http://+:5274

ENTRYPOINT ["dotnet", "MyApp.dll"]
