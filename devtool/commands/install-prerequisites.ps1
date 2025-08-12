#!/usr/bin/env pwsh

param(
    [switch]$Force
)

$Script:DevToolRoot = Split-Path -Parent (Split-Path -Parent $MyInvocation.MyCommand.Definition)
$Script:TempPath = Join-Path $DevToolRoot "temp"
$Script:ModulesPath = Join-Path $DevToolRoot "modules"

# Import modules
Import-Module (Join-Path $ModulesPath "ProgressBar.psm1") -Force -ErrorAction SilentlyContinue
Import-Module (Join-Path $ModulesPath "StatusTracker.psm1") -Force -ErrorAction SilentlyContinue
Import-Module (Join-Path $ModulesPath "Discord.psm1") -Force -ErrorAction SilentlyContinue

function Test-XmakeInstalled {
    try {
        $null = Get-Command xmake -ErrorAction Stop
        return $true
    }
    catch {
        return $false
    }
}

function Install-Xmake {
    Write-Host "Installing xmake..." -ForegroundColor Cyan
    
    $xmakeUrl = "https://github.com/xmake-io/xmake/releases/latest/download/xmake-master.win64.exe"
    $xmakeInstaller = Join-Path $TempPath "xmake-installer.exe"
    
    try {
        # Download xmake installer
        Write-Host "Downloading xmake installer..." -ForegroundColor Yellow
        Show-Progress -Activity "Downloading xmake" -Status "Fetching latest release"
        
        Invoke-WebRequest -Uri $xmakeUrl -OutFile $xmakeInstaller -UseBasicParsing
        
        if (-not (Test-Path $xmakeInstaller)) {
            throw "Failed to download xmake installer"
        }
        
        # Install xmake
        Write-Host "Installing xmake (this may take a moment)..." -ForegroundColor Yellow
        Show-Progress -Activity "Installing xmake" -Status "Running installer"
        
        Start-Process -FilePath $xmakeInstaller -ArgumentList "/S" -Wait -NoNewWindow
        
        # Verify installation
        if (Test-XmakeInstalled) {
            Write-Host "✓ xmake installed successfully!" -ForegroundColor Green
            Set-BuildStatus -Component "xmake" -Status "installed" -Version (& xmake --version 2>$null | Select-Object -First 1)
            
            try {
                Send-DiscordNotification -Title "Prerequisites Installed" -Description "xmake has been successfully installed" -Color "Green"
            }
            catch {
                # Ignore Discord notification errors
            }
        }
        else {
            throw "xmake installation verification failed"
        }
        
        # Clean up installer
        if (Test-Path $xmakeInstaller) {
            Remove-Item $xmakeInstaller -Force -ErrorAction SilentlyContinue
        }
    }
    catch {
        Write-Host "✗ Failed to install xmake: $_" -ForegroundColor Red
        Set-BuildStatus -Component "xmake" -Status "failed" -Error $_
        
        try {
            Send-DiscordNotification -Title "Installation Failed" -Description "Failed to install xmake: $_" -Color "Red"
        }
        catch {
            # Ignore Discord notification errors
        }
        
        throw
    }
}

function Main {
    Write-Host "SwiftlyS2 - Prerequisites Installer" -ForegroundColor Cyan
    Write-Host "=====================================" -ForegroundColor Cyan
    
    # Ensure temp directory exists
    if (-not (Test-Path $TempPath)) {
        New-Item -ItemType Directory -Path $TempPath -Force | Out-Null
    }
    
    # Check if xmake is already installed
    if (Test-XmakeInstalled -and -not $Force) {
        Write-Host "✓ xmake is already installed" -ForegroundColor Green
        $version = & xmake --version 2>$null | Select-Object -First 1
        Write-Host "  Version: $version" -ForegroundColor Gray
        Write-Host "Use -Force to reinstall" -ForegroundColor Gray
        return
    }
    
    if ($Force -and (Test-XmakeInstalled)) {
        Write-Host "Forcing reinstallation of xmake..." -ForegroundColor Yellow
    }
    
    # Install xmake
    Install-Xmake
    
    Write-Host ""
    Write-Host "✓ All prerequisites installed successfully!" -ForegroundColor Green
    Write-Host "You can now run: ./devtool.ps1 build" -ForegroundColor Cyan
}

# Run main function
Main