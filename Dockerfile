# Build the .NET backend
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS backend-build

# Set working directory
WORKDIR /app

# Copy the backend project files
COPY ./Arcadia-back/*.csproj ./
RUN dotnet restore

# Copy the rest of the backend files
COPY ./Arcadia-back/ ./

# Build the .NET application
RUN dotnet publish -c Release -o out

# Stage 3: Build the final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set working directory
WORKDIR /app

# Copy the published backend files
COPY --from=backend-build /app/out ./
COPY ./Arcadia-back/assets ./assets

# Expose the port that your application will run on
EXPOSE 8080

# Set the entry point to run your .NET application
ENTRYPOINT ["dotnet", "Arcadia-back.dll"]