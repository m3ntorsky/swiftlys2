function Show-ProgressBar {
    param(
        [Parameter(Mandatory=$true)]
        [string]$Activity,
        
        [Parameter(Mandatory=$true)]
        [int]$PercentComplete,
        
        [string]$Status = "",
        
        [int]$Id = 0
    )
    
    Write-Progress -Id $Id -Activity $Activity -Status $Status -PercentComplete $PercentComplete
}

function Start-CustomProgress {
    param(
        [Parameter(Mandatory=$true)]
        [string]$Title,
        
        [Parameter(Mandatory=$true)]
        [int]$Total,
        
        [int]$Id = 0
    )
    
    $script:ProgressData = @{
        Title = $Title
        Total = $Total
        Current = 0
        Id = $Id
    }
    
    Write-Host "[$Title] Starting..." -ForegroundColor Cyan
    Show-ProgressBar -Activity $Title -PercentComplete 0 -Status "Initializing..." -Id $Id
}

function Update-CustomProgress {
    param(
        [Parameter(Mandatory=$true)]
        [string]$Status,
        
        [int]$Increment = 1
    )
    
    if (-not $script:ProgressData) {
        Write-Warning "Progress not initialized. Call Start-CustomProgress first."
        return
    }
    
    $script:ProgressData.Current += $Increment
    $percentComplete = [math]::Round(($script:ProgressData.Current / $script:ProgressData.Total) * 100, 2)
    
    $progressChar = switch ($percentComplete) {
        {$_ -lt 25} { "[=   ]" }
        {$_ -lt 50} { "[==  ]" }
        {$_ -lt 75} { "[=== ]" }
        default { "[====]" }
    }
    
    Write-Host "[$($script:ProgressData.Title)] $progressChar $Status ($($script:ProgressData.Current)/$($script:ProgressData.Total))" -ForegroundColor Cyan
    Show-ProgressBar -Activity $script:ProgressData.Title -PercentComplete $percentComplete -Status $Status -Id $script:ProgressData.Id
}

function Complete-CustomProgress {
    param(
        [string]$FinalMessage = "Completed successfully!"
    )
    
    if (-not $script:ProgressData) {
        return
    }
    
    Write-Progress -Id $script:ProgressData.Id -Completed -Activity "Activity Completed"
    Write-Host "[$($script:ProgressData.Title)] [DONE] $FinalMessage" -ForegroundColor Green
    
    $script:ProgressData = $null
}

Export-ModuleMember -Function Show-ProgressBar, Start-CustomProgress, Update-CustomProgress, Complete-CustomProgress