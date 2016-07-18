Write-Host "Importing module from build."
Import-Module .\PowershellModule\CloudCompute.Powershell\bin\Release\DD.CBU.Compute.Powershell.dll
$commands = Get-Command -Module CaaS
Write-Host "Writing documentation"
if((Test-Path ".\docs\powershell\") -eq 0){
    mkdir ".\docs\powershell\"}
foreach ($command in $commands){
    Write-Host "Writing output for $command.name"
	.\Get-HelpToRst.ps1 $command.name | Set-Content -Encoding utf8 .\docs\powershell\$command.rst
}

