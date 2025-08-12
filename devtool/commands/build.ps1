param(
    [ValidateSet("debug", "release")]
    [string]$Mode,
    [switch]$Clean,
    [switch]$Verbose
)

$DevToolRoot = Split-Path -Parent (Split-Path -Parent $MyInvocation.MyCommand.Definition)
$ProjectRoot = Split-Path -Parent $DevToolRoot
$ModulesPath = Join-Path $DevToolRoot "modules"

# Import Discord module
Import-Module (Join-Path $ModulesPath "Discord.psm1") -Force -ErrorAction SilentlyContinue

Write-Host "SwiftlyS2 - Build System" -ForegroundColor Cyan
Write-Host "Mode received: '$Mode'" -ForegroundColor White

# Start build timer
$BuildStartTime = Get-Date

# Check if xmake is available
try {
    $null = Get-Command xmake -ErrorAction Stop
}
catch {
    Write-Host "xmake is not installed" -ForegroundColor Red
    Write-Host "Run: ./devtool.ps1 install-prerequisites" -ForegroundColor Yellow
    exit 1
}

# Change to project directory
Set-Location $ProjectRoot

# Clean if requested
if ($Clean) {
    Write-Host "Cleaning..." -ForegroundColor Yellow
    & xmake clean
}

# Configure
Write-Host "Configuring..." -ForegroundColor Yellow
& xmake config -m $Mode

# Build
Write-Host "Building..." -ForegroundColor Yellow
if ($Verbose) {
    & xmake build -v
}
else {
    & xmake build
}

# Calculate build duration
$BuildEndTime = Get-Date
$BuildDuration = $BuildEndTime - $BuildStartTime
$DurationFormatted = "{0:mm\:ss}" -f ([datetime]$BuildDuration.Ticks)

if ($LASTEXITCODE -eq 0) {
    Write-Host "Build completed successfully!" -ForegroundColor Green
    Write-Host "Build duration: $DurationFormatted" -ForegroundColor Gray
    
    # Send success notification
    try {
        if (Get-Command Send-DiscordNotification -ErrorAction SilentlyContinue) {
            Send-DiscordNotification -Title "Build Successful" -Description "SwiftlyS2 built successfully in $Mode mode`nDuration: $DurationFormatted" -Color "Green"
        }
    }
    catch {
        # Ignore Discord notification errors
    }
}
else {
    Write-Host "Build failed!" -ForegroundColor Red
    Write-Host "Build duration: $DurationFormatted" -ForegroundColor Gray
    
    # Send failure notification
    try {
        if (Get-Command Send-DiscordNotification -ErrorAction SilentlyContinue) {
            Send-DiscordNotification -Title "Build Failed" -Description "SwiftlyS2 build failed in $Mode mode`nDuration: $DurationFormatted" -Color "Red"
        }
    }
    catch {
        # Ignore Discord notification errors
    }
    
    exit 1
}