$Script:ProjectColor = 0x01ffef
$Script:WebhookConfigPath = Join-Path (Split-Path -Parent $PSScriptRoot) "temp\discord_config.json"

function Initialize-DiscordWebhook {
    if (Test-Path $Script:WebhookConfigPath) {
        try {
            $config = Get-Content -Path $Script:WebhookConfigPath -Raw | ConvertFrom-Json
            $Script:DiscordWebhookUrl = $config.webhook_url
        }
        catch {
            $Script:DiscordWebhookUrl = $env:DISCORD_WEBHOOK_URL
        }
    }
    else {
        $Script:DiscordWebhookUrl = $env:DISCORD_WEBHOOK_URL
    }
}

Initialize-DiscordWebhook

function Set-DiscordWebhook {
    param(
        [Parameter(Mandatory=$true)]
        [string]$WebhookUrl
    )
    
    $Script:DiscordWebhookUrl = $WebhookUrl
    Write-Host "Discord webhook configured" -ForegroundColor Cyan
}

function Send-DiscordNotification {
    param(
        [Parameter(Mandatory=$true)]
        [string]$Title,
        
        [Parameter(Mandatory=$true)]
        [string]$Description,
        
        [string]$Color = "Cyan",
        
        [hashtable]$Fields = @{},
        
        [string]$ThumbnailUrl = "",
        
        [string]$Footer = "SwiftlyS2 DevTool"
    )
    
    if (-not $Script:DiscordWebhookUrl) {
        Write-Warning "Discord webhook not configured. Use: ./devtool.ps1 discord-config set"
        return
    }
    
    $colorValue = switch ($Color.ToLower()) {
        "red" { 0xff0000 }
        "green" { 0x00ff00 }
        "yellow" { 0xffff00 }
        "cyan" { $Script:ProjectColor }
        default { $Script:ProjectColor }
    }
    
    $embed = @{
        title = $Title
        description = $Description
        color = $colorValue
        timestamp = (Get-Date).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
        footer = @{
            text = $Footer
        }
    }
    
    if ($Fields.Count -gt 0) {
        $embed.fields = @()
        foreach ($key in $Fields.Keys) {
            $fieldValue = $Fields[$key]
            if ($fieldValue -eq $null) { $fieldValue = "N/A" }
            $embed.fields += @{
                name = [string]$key
                value = [string]$fieldValue
                inline = $true
            }
        }
    }
    
    if ($ThumbnailUrl) {
        $embed.thumbnail = @{
            url = $ThumbnailUrl
        }
    }
    
    $payload = @{
        embeds = @($embed)
    } | ConvertTo-Json -Depth 10
    
    try {
        Invoke-RestMethod -Uri $Script:DiscordWebhookUrl -Method Post -Body $payload -ContentType "application/json" | Out-Null
        Write-Host "Discord notification sent: $Title" -ForegroundColor Green
    }
    catch {
        Write-Warning "Failed to send Discord notification: $_"
    }
}

function Send-BuildStatus {
    param(
        [Parameter(Mandatory=$true)]
        [string]$BuildType,
        
        [Parameter(Mandatory=$true)]
        [string]$Status,
        
        [string]$Details = "",
        
        [hashtable]$BuildInfo = @{}
    )
    
    $color = switch ($Status.ToLower()) {
        "success" { "Green" }
        "failed" { "Red" }
        "warning" { "Yellow" }
        default { "Cyan" }
    }
    
    $emoji = switch ($Status.ToLower()) {
        "success" { ":white_check_mark:" }
        "failed" { ":x:" }
        "warning" { ":warning:" }
        default { ":arrows_counterclockwise:" }
    }
    
    $fields = @{
        "Build Type" = $BuildType
        "Status" = "$emoji $Status"
    }
    
    if ($Details) {
        $fields["Details"] = $Details
    }
    
    foreach ($key in $BuildInfo.Keys) {
        $fields[$key] = $BuildInfo[$key]
    }
    
    Send-DiscordNotification -Title "Build Status Update" -Description "Build status has been updated" -Color $color -Fields $fields
}

Export-ModuleMember -Function Set-DiscordWebhook, Send-DiscordNotification, Send-BuildStatus