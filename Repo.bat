@echo off

set /p REPO_NAME=Ha_Van_Dung_msv-2121051408
set CLONE_DIR=%USERPROFILE%\github
set REPO_URL=https://github.com/username_for_you/%REPO_NAME%.git

mkdir "%CLONE_DIR%" 2>nul
cd /d "%CLONE_DIR%"

if exist "%REPO_NAME%" (
    echo Repo da ton tai: %CLONE_DIR%\%REPO_NAME%
    pause
    exit /b
)

echo Dang clone repository...
git clone "%REPO_URL%"

pause
