@echo off
echo ===== AUTO PUSH GITHUB =====

REM Luon chay tai thu muc chua file push.bat (Prac_HTML)
cd /d "%~dp0"

echo.
echo Repo hien tai:
git rev-parse --show-toplevel

echo.
echo Kiem tra trang thai repository...
git status

REM Kiem tra co thay doi hay khong
git status --porcelain | findstr . >nul
if errorlevel 1 (
    echo Khong co thay doi nao de commit.
    pause
    exit /b
)

echo.
echo Dang add tat ca file...
git add .

echo.
set /p MSG=Nhap noi dung commit: 

git commit -m "%MSG%"

echo.
echo Dang day code len GitHub...
git push origin main

echo.
echo ===== HOAN THANH =====
pause
