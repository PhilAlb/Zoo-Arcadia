# Stage 1: Build the Angular frontend
FROM node:18 AS frontend-build

# Set working directory
WORKDIR /app/frontend

# Copy package.json and package-lock.json files
COPY ./Arcadia-front/package*.json ./

# Install dependencies
RUN npm install

# Copy the rest of the Angular app's files
COPY ./Arcadia-front/ ./

# Build the Angular app
RUN npm run build --prod

# Stage 2: Build the .NET backend
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

# Copy the Angular build output to the backend's static files directory
COPY --from=frontend-build /app/frontend/dist/arcadia-front ./wwwroot

# Expose the port that your application will run on
EXPOSE 80

# Set the entry point to run your .NET application
ENTRYPOINT ["dotnet", "Arcadia-back.dll"]