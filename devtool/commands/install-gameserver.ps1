param(
    [Parameter(Mandatory=$true)]
    [string]$GameName
)

Import-Module (Join-Path (Split-Path -Parent $PSScriptRoot) "modules\ProgressBar.psm1") -Force
Import-Module (Join-Path (Split-Path -Parent $PSScriptRoot) "modules\Discord.psm1") -Force
Import-Module (Join-Path (Split-Path -Parent $PSScriptRoot) "modules\StatusTracker.psm1") -Force
Import-Module (Join-Path (Split-Path -Parent $PSScriptRoot) "modules\GameServer.psm1") -Force

function Install-GameServer {
    param(
        [string]$Game
    )
    
    try {
        Write-Host "Installing Game Server for: $Game" -ForegroundColor Cyan
        
        if ($Game.ToLower() -ne "cs2") {
            Write-Host "Error: Only CS2 is currently supported" -ForegroundColor Red
            return
        }
        
        Write-Host ""
        Write-Host "External Library Configuration" -ForegroundColor Cyan
        Write-Host "=" * 40 -ForegroundColor Cyan
        
        $repoUrl = Read-Host "Enter GitHub repository URL for external library (or press Enter to skip)"
        $branch = "main"
        
        if ($repoUrl) {
            $branch = Read-Host "Enter branch name (default: main)"
            if (-not $branch) { $branch = "main" }
            
            Write-Host "Repository: $repoUrl" -ForegroundColor White
            Write-Host "Branch: $branch" -ForegroundColor White
            Write-Host ""
        }
        
        Add-BuildStatus -BuildType "GameServer-$Game" -Status "Starting" -Details "Beginning installation process" -Metadata @{
            repository = $repoUrl
            branch = $branch
        }
        
        Send-DiscordNotification -Title "Game Server Installation Started" -Description "Installing $Game server..." -Fields @{
            "Game" = $Game
            "Repository" = if ($repoUrl) { $repoUrl } else { "None" }
            "Branch" = if ($repoUrl) { $branch } else { "N/A" }
        }
        
        if ($repoUrl) {
            Start-CustomProgress -Title "External Library Download" -Total 2
            
            $repoName = ($repoUrl -split '/')[-1] -replace '\.git$', ''
            $folderName = "$repoName-$branch"
            
            $externalBasePath = Join-Path (Split-Path -Parent (Split-Path -Parent $PSScriptRoot)) "external"
            $externalPath = Join-Path $externalBasePath $folderName
            
            if (-not (Test-Path $externalBasePath)) {
                New-Item -ItemType Directory -Path $externalBasePath -Force | Out-Null
            }
            
            Update-CustomProgress -Status "Cloning repository..."
            
            $cloneArgs = @("clone", "--branch", $branch, $repoUrl, $externalPath)
            $gitProcess = Start-Process -FilePath "git" -ArgumentList $cloneArgs -Wait -PassThru -NoNewWindow -RedirectStandardError NUL
            
            if ($gitProcess.ExitCode -eq 0) {
                Update-CustomProgress -Status "Repository cloned successfully"
                Complete-CustomProgress -FinalMessage "External library downloaded to $externalPath"
            }
            else {
                throw "Failed to clone repository"
            }
        }
        
        Write-Host ""
        $serverPath = Download-GameServer -GameName $Game
        
        Add-BuildStatus -BuildType "GameServer-$Game" -Status "Success" -Details "Server installed to: $serverPath" -Metadata @{
            serverPath = $serverPath
            repository = $repoUrl
            branch = $branch
        }
        
        Send-DiscordNotification -Title "Game Server Installation Complete" -Description "$Game server has been successfully installed!" -Color "Green" -Fields @{
            "Game" = $Game
            "Install Path" = $serverPath
            "Repository" = if ($repoUrl) { $repoUrl } else { "None" }
        }
        
        Write-Host ""
        Write-Host "Installation Summary:" -ForegroundColor Cyan
        Write-Host "=" * 30 -ForegroundColor Cyan
        Write-Host "Game: $Game" -ForegroundColor White
        Write-Host "Server Path: $serverPath" -ForegroundColor White
        if ($repoUrl) {
            Write-Host "External Library: $externalPath" -ForegroundColor White
        }
        Write-Host ""
        Write-Host "Installation completed successfully!" -ForegroundColor Green
        
    }
    catch {
        $errorMsg = $_.Exception.Message
        Write-Host "Installation failed: $errorMsg" -ForegroundColor Red
        
        Add-BuildStatus -BuildType "GameServer-$Game" -Status "Failed" -Details $errorMsg
        Send-DiscordNotification -Title "Game Server Installation Failed" -Description "Installation failed for $Game" -Color "Red" -Fields @{
            "Game" = $Game
            "Error" = $errorMsg
        }
    }
}

Install-GameServer -Game $GameName