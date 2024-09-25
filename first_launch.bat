@echo off
set SOLUTION_DIR=Arcadia-front

git checkout demo
cd %SOLUTION_DIR% || exit /b
npm install
cd ..
call launch_scripts.bat
