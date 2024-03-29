set-alias stsadm "C:\Program Files\Common Files\Microsoft Shared\Web Server Extensions\14\BIN\stsadm.exe"

Function kill-process($s)
{
    Write-Host Stopping $s
    if(Get-Process $s -ea Silentlycontinue){Stop-Process -processname $s -force} else{Write-Host $s not running}
}

Function kill-service([string]$s)
{
    Write-Host Stopping $s
    get-service $s | Where{$_.Status -eq "Running"} | stop-service -force
}

Function stop-spservice-type([string]$s)
{
    Write-Host Stopping $s
    stsadm -o provisionservice -action stop -servicetype $s 
    Write-Host
}

Function stop-spservice-typename([string]$s,[string]$n)
{
    Write-Host Stopping $n
    stsadm -o provisionservice -action stop -servicetype $s -servicename $n
    Write-Host
}
Function set-sqlmemory
{
    get-pssnapin | Where{$_.Name -eq "sqlserverprovidersnapin100"} | remove-pssnapin
    get-pssnapin | Where{$_.Name -eq "sqlservercmdletsnapin100"} | remove-pssnapin
    
    add-pssnapin sqlserverprovidersnapin100
    add-pssnapin sqlservercmdletsnapin100

    Write-Host Setting SQL Server max and min memory...    
    invoke-sqlcmd "exec sp_configure 'show advanced options', 1;"
    invoke-sqlcmd "GO"
    invoke-sqlcmd "RECONFIGURE"
    invoke-sqlcmd "exec sp_configure 'max server memory',500;"
    invoke-sqlcmd "RECONFIGURE WITH OVERRIDE"
    invoke-sqlcmd "exec sp_configure 'min server memory',100;"
    invoke-sqlcmd "RECONFIGURE WITH OVERRIDE"
}
set-sqlmemory

kill-service ProjectQueueService14

kill-service ProjectEventService14

kill-service DCLauncher14

kill-service DCLoadBalancer14

kill-service WebAnalyticsService

kill-service OSearch14

kill-service SPUserCodeV4

kill-service SPSearch4

kill-service SPTimerV4

kill-service SPTraceV4

kill-service FontCache3.0.0.0

kill-service 'MSSQL$RTC'

kill-service ReportServer



kill-service FASTSearchService

kill-service FASTSearchBrowserEngine

kill-service FASTSearchMonitoring

kill-process mqsvc

kill-process MSASCui

kill-process ntfrs

kill-process OSPPSVC

kill-process PresentationFontCache

kill-process sqlwriter

kill-process SYNCPROC

stop-spservice-type ExcelServerWebService

stop-spservice-type WordService

iisreset /noforce

Write-Host
Write-Host Finished optimizing the VM for lab.
Write-Host