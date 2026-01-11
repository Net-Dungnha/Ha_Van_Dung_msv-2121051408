@echo off

:: ===== CONFIG =====
set GITHUB_USERNAME=Net-Dungnha
set REPO_NAME=Ha_Van_Dung_msv-2121051408
set CLONE_DIR=%USERPROFILE%\github
:: ==================

set REPO_URL=https://github.com/%GITHUB_USERNAME%/%REPO_NAME%.git

:: Tao thu muc github neu chua co
mkdir "%CLONE_DIR%" 2>nul
cd /d "%CLONE_DIR%"

:: Kiem tra repo da ton tai chua
if exist "%REPO_NAME%" (
    echo Repo da ton tai: %CLONE_DIR%\%REPO_NAME%
    pause
    exit /b
)

echo Dang clone repository tu GitHub...
git clone "%REPO_URL%"

echo.
echo  - Username: %GITHUB_USERNAME%
echo  - Password: GitHub TOKEN
echo.

pause
