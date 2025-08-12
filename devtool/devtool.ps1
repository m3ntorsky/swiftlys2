#!/usr/bin/env pwsh

param(
    [Parameter(Mandatory=$true, Position=0)]
    [string]$Command,
    
    [Parameter(ValueFromRemainingArguments=$true)]
    [string[]]$Arguments
)

$Script:DevToolRoot = Split-Path -Parent $MyInvocation.MyCommand.Definition
$Script:CommandsPath = Join-Path $DevToolRoot "commands"
$Script:ModulesPath = Join-Path $DevToolRoot "modules"
$Script:TempPath = Join-Path $DevToolRoot "temp"
$Script:StatusFile = Join-Path $TempPath "build_status.json"
$Script:ProjectColor = "#01ffef"

if (-not (Test-Path $TempPath)) {
    New-Item -ItemType Directory -Path $TempPath -Force | Out-Null
}

function Show-Help {
    Write-Host "DevTool - Development Utility" -ForegroundColor Cyan
    Write-Host "Usage: ./devtool.ps1 <command> [arguments...]" -ForegroundColor White
    Write-Host ""
    Write-Host "Available Commands:" -ForegroundColor Cyan
    
    $commandFiles = Get-ChildItem -Path $CommandsPath -Filter "*.ps1" -ErrorAction SilentlyContinue
    foreach ($file in $commandFiles) {
        $commandName = $file.BaseName
        Write-Host "  $commandName" -ForegroundColor White
    }
}

function Invoke-Command {
    param(
        [string]$CommandName,
        [string[]]$Args
    )
    
    $commandFile = Join-Path $CommandsPath "$CommandName.ps1"
    
    if (-not (Test-Path $commandFile)) {
        Write-Host "Command '$CommandName' not found. Available commands:" -ForegroundColor Red
        Show-Help
        return
    }
    
    try {
        & $commandFile @Args
    }
    catch {
        Write-Host "Error executing command '$CommandName': $_" -ForegroundColor Red
        try {
            Import-Module (Join-Path $ModulesPath "Discord.psm1") -Force -ErrorAction SilentlyContinue
            Send-DiscordNotification -Title "Command Failed" -Description "Command '$CommandName' failed with error: $_" -Color "Red"
        }
        catch {
            # Ignore Discord notification errors during command failures
        }
    }
}

if ($Command -eq "help" -or $Command -eq "-h" -or $Command -eq "--help") {
    Show-Help
}
else {
    Invoke-Command -CommandName $Command -Args $Arguments
}