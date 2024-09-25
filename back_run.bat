@echo off
set SOLUTION_DIR=Arcadia-back
set CUSTOM_PROFILE=https

cd %SOLUTION_DIR% || exit /b

dotnet watch --project "Arcadia-back.csproj" --configuration Debug --launch-profile %CUSTOM_PROFILE%