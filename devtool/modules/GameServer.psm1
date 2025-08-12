$Script:GameAppIds = @{
    "cs2" = 730
}

function Get-GameAppId {
    param(
        [Parameter(Mandatory=$true)]
        [string]$GameName
    )
    
    $gameLower = $GameName.ToLower()
    if ($Script:GameAppIds.ContainsKey($gameLower)) {
        return $Script:GameAppIds[$gameLower]
    }
    
    Write-Warning "Unknown game: $GameName. Available games: $($Script:GameAppIds.Keys -join ', ')"
    return $null
}

function Show-AvailableGames {
    Write-Host "Available Games:" -ForegroundColor Cyan
    Write-Host "=" * 30 -ForegroundColor Cyan
    
    foreach ($game in $Script:GameAppIds.GetEnumerator() | Sort-Object Key) {
        Write-Host "$($game.Key.PadRight(15)) AppID: $($game.Value)" -ForegroundColor White
    }
}

function Download-SteamCMD {
    param(
        [string]$TargetPath = (Join-Path (Split-Path -Parent $PSScriptRoot) "temp\steamcmd")
    )
    
    Start-CustomProgress -Title "SteamCMD Download" -Total 3
    
    try {
        if (-not (Test-Path $TargetPath)) {
            New-Item -ItemType Directory -Path $TargetPath -Force | Out-Null
        }
        
        $steamCmdExe = Join-Path $TargetPath "steamcmd.exe"
        
        if (Test-Path $steamCmdExe) {
            Update-CustomProgress -Status "SteamCMD already exists, skipping download"
            Complete-CustomProgress -FinalMessage "SteamCMD ready"
            return $steamCmdExe
        }
        
        Update-CustomProgress -Status "Downloading SteamCMD..."
        
        $steamCmdUrl = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"
        $zipPath = Join-Path $TargetPath "steamcmd.zip"
        
        Invoke-WebRequest -Uri $steamCmdUrl -OutFile $zipPath -UseBasicParsing
        
        Update-CustomProgress -Status "Extracting SteamCMD..."
        
        Add-Type -AssemblyName System.IO.Compression.FileSystem
        [System.IO.Compression.ZipFile]::ExtractToDirectory($zipPath, $TargetPath)
        
        Remove-Item $zipPath -Force
        
        Update-CustomProgress -Status "SteamCMD ready"
        Complete-CustomProgress -FinalMessage "SteamCMD downloaded successfully"
        
        return $steamCmdExe
    }
    catch {
        Write-Host "Failed to download SteamCMD: $_" -ForegroundColor Red
        throw
    }
}

function Download-GameServer {
    param(
        [Parameter(Mandatory=$true)]
        [string]$GameName,
        
        [string]$InstallPath = "",
        
        [string]$SteamCmdPath = ""
    )
    
    $appId = Get-GameAppId -GameName $GameName
    if (-not $appId) {
        throw "Unknown game: $GameName"
    }
    
    if (-not $SteamCmdPath) {
        $SteamCmdPath = Download-SteamCMD
    }
    
    if (-not $InstallPath) {
        $InstallPath = Join-Path (Split-Path -Parent $PSScriptRoot) "temp\gameservers\$GameName"
    }
    
    Start-CustomProgress -Title "Game Server Download" -Total 2
    
    try {
        if (-not (Test-Path $InstallPath)) {
            New-Item -ItemType Directory -Path $InstallPath -Force | Out-Null
        }
        
        Update-CustomProgress -Status "Downloading $GameName server (AppID: $appId)..."
        
        $arguments = @(
            "+force_install_dir `"$InstallPath`""
            "+login anonymous"
            "+app_update $appId validate"
            "+quit"
        )
        
        $process = Start-Process -FilePath $SteamCmdPath -ArgumentList ($arguments -join " ") -Wait -PassThru -NoNewWindow
        
        $validExitCodes = @(0, 7)
        if ($validExitCodes -contains $process.ExitCode) {
            Update-CustomProgress -Status "Download completed successfully"
            Complete-CustomProgress -FinalMessage "$GameName server downloaded to $InstallPath"
            return $InstallPath
        }
        else {
            throw "SteamCMD failed with exit code $($process.ExitCode)"
        }
    }
    catch {
        Write-Host "Failed to download game server: $_" -ForegroundColor Red
        throw
    }
}

Export-ModuleMember -Function Get-GameAppId, Show-AvailableGames, Download-SteamCMD, Download-GameServer