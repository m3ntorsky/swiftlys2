param(
    [Parameter(Mandatory=$true)]
    [ValidateSet("set", "get", "test")]
    [string]$Action,
    
    [string]$WebhookUrl = ""
)

Import-Module (Join-Path (Split-Path -Parent $PSScriptRoot) "modules\Discord.psm1") -Force

$Script:WebhookConfigPath = Join-Path (Split-Path -Parent $PSScriptRoot) "temp\discord_config.json"

function Set-WebhookConfig {
    param(
        [string]$Url
    )
    
    if (-not $Url) {
        $Url = Read-Host "Enter Discord webhook URL"
    }
    
    if (-not ($Url.StartsWith("https://discord.com/api/webhooks/") -or $Url.StartsWith("https://discordapp.com/api/webhooks/"))) {
        Write-Host "Invalid Discord webhook URL format" -ForegroundColor Red
        return
    }
    
    $tempDir = Split-Path -Parent $Script:WebhookConfigPath
    if (-not (Test-Path $tempDir)) {
        New-Item -ItemType Directory -Path $tempDir -Force | Out-Null
    }
    
    $config = @{
        webhook_url = $Url
        configured_at = (Get-Date).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
    }
    
    try {
        $config | ConvertTo-Json | Set-Content -Path $Script:WebhookConfigPath -Encoding UTF8
        Write-Host "Discord webhook configured successfully" -ForegroundColor Cyan
        
        Set-DiscordWebhook -WebhookUrl $Url
    }
    catch {
        Write-Host "Failed to save webhook configuration: $_" -ForegroundColor Red
    }
}

function Get-WebhookConfig {
    if (-not (Test-Path $Script:WebhookConfigPath)) {
        Write-Host "No Discord webhook configured" -ForegroundColor Yellow
        Write-Host "Use: ./devtool.ps1 discord-config set" -ForegroundColor Cyan
        return
    }
    
    try {
        $config = Get-Content -Path $Script:WebhookConfigPath -Raw | ConvertFrom-Json
        
        $maskedUrl = $config.webhook_url -replace '(?<=webhooks/\d+/)[^/]+', '***MASKED***'
        
        Write-Host "Discord Webhook Configuration:" -ForegroundColor Cyan
        Write-Host "=" * 35 -ForegroundColor Cyan
        Write-Host "URL: $maskedUrl" -ForegroundColor White
        Write-Host "Configured: $($config.configured_at)" -ForegroundColor White
        
        return $config.webhook_url
    }
    catch {
        Write-Host "Failed to read webhook configuration: $_" -ForegroundColor Red
        return $null
    }
}

function Test-WebhookConfig {
    $webhookUrl = Get-WebhookConfig
    
    if (-not $webhookUrl) {
        return
    }
    
    Write-Host "Testing Discord webhook..." -ForegroundColor Cyan
    
    Set-DiscordWebhook -WebhookUrl $webhookUrl
    
    try {
        Send-DiscordNotification -Title "Webhook Test" -Description "This is a test notification from SwiftlyS2 DevTool" -Fields @{
            "Status" = ":white_check_mark: Working"
            "Timestamp" = (Get-Date).ToString("yyyy-MM-dd HH:mm:ss")
        }
        
        Write-Host "Test notification sent successfully!" -ForegroundColor Green
    }
    catch {
        Write-Host "Test failed: $_" -ForegroundColor Red
    }
}

switch ($Action.ToLower()) {
    "set" {
        Set-WebhookConfig -Url $WebhookUrl
    }
    "get" {
        Get-WebhookConfig | Out-Null
    }
    "test" {
        Test-WebhookConfig
    }
}