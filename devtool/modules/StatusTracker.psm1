$Script:StatusFilePath = Join-Path (Split-Path -Parent $PSScriptRoot) "temp\build_status.json"

function Initialize-StatusFile {
    $tempDir = Split-Path -Parent $Script:StatusFilePath
    if (-not (Test-Path $tempDir)) {
        New-Item -ItemType Directory -Path $tempDir -Force | Out-Null
    }
    
    if (-not (Test-Path $Script:StatusFilePath)) {
        $initialData = @{
            builds = @()
            lastUpdated = (Get-Date).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
        }
        $initialData | ConvertTo-Json -Depth 10 | Set-Content -Path $Script:StatusFilePath -Encoding UTF8
    }
}

function Add-BuildStatus {
    param(
        [Parameter(Mandatory=$true)]
        [string]$BuildType,
        
        [Parameter(Mandatory=$true)]
        [string]$Status,
        
        [string]$Details = "",
        
        [hashtable]$Metadata = @{}
    )
    
    Initialize-StatusFile
    
    try {
        $statusData = Get-Content -Path $Script:StatusFilePath -Raw | ConvertFrom-Json
    }
    catch {
        Write-Warning "Could not read status file, creating new one"
        $statusData = @{
            builds = @()
            lastUpdated = (Get-Date).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
        }
    }
    
    $buildEntry = @{
        id = [System.Guid]::NewGuid().ToString()
        buildType = $BuildType
        status = $Status
        details = $Details
        timestamp = (Get-Date).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
        metadata = $Metadata
    }
    
    $statusData.builds = @($buildEntry) + $statusData.builds
    
    if ($statusData.builds.Count -gt 50) {
        $statusData.builds = $statusData.builds[0..49]
    }
    
    $statusData.lastUpdated = (Get-Date).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
    
    try {
        $statusData | ConvertTo-Json -Depth 10 | Set-Content -Path $Script:StatusFilePath -Encoding UTF8
        Write-Host "Build status recorded: $BuildType - $Status" -ForegroundColor Cyan
    }
    catch {
        Write-Warning "Failed to save build status: $_"
    }
}

function Get-BuildHistory {
    param(
        [int]$Limit = 10,
        [string]$BuildType = ""
    )
    
    Initialize-StatusFile
    
    try {
        $statusData = Get-Content -Path $Script:StatusFilePath -Raw | ConvertFrom-Json
        $builds = $statusData.builds
        
        if ($BuildType) {
            $builds = $builds | Where-Object { $_.buildType -eq $BuildType }
        }
        
        return $builds | Select-Object -First $Limit
    }
    catch {
        Write-Warning "Could not read build history: $_"
        return @()
    }
}

function Get-LastBuildStatus {
    param(
        [string]$BuildType = ""
    )
    
    $history = Get-BuildHistory -Limit 1 -BuildType $BuildType
    return $history | Select-Object -First 1
}

function Show-BuildHistory {
    param(
        [int]$Limit = 10,
        [string]$BuildType = ""
    )
    
    $history = Get-BuildHistory -Limit $Limit -BuildType $BuildType
    
    if ($history.Count -eq 0) {
        Write-Host "No build history found" -ForegroundColor Yellow
        return
    }
    
    Write-Host "Build History:" -ForegroundColor Cyan
    Write-Host "=" * 50 -ForegroundColor Cyan
    
    foreach ($build in $history) {
        $statusColor = switch ($build.status.ToLower()) {
            "success" { "Green" }
            "failed" { "Red" }
            "warning" { "Yellow" }
            default { "White" }
        }
        
        $timestamp = [DateTime]::Parse($build.timestamp).ToString("yyyy-MM-dd HH:mm:ss")
        Write-Host "[$timestamp] " -ForegroundColor Gray -NoNewline
        Write-Host "$($build.buildType) - " -ForegroundColor Cyan -NoNewline
        Write-Host "$($build.status)" -ForegroundColor $statusColor
        
        if ($build.details) {
            Write-Host "  Details: $($build.details)" -ForegroundColor Gray
        }
        
        Write-Host ""
    }
}

Export-ModuleMember -Function Add-BuildStatus, Get-BuildHistory, Get-LastBuildStatus, Show-BuildHistory