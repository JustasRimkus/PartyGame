# MSSQL control scripts
Currently there are two scripts that can be used

## DockerMSSQLFirstLaunchScript.ps1
The script does a first time setup of the _MSSQL_ server on docker
```powershell
DockerMSSQLFirstLaunchScript.ps1 (-p <password>)
```
The password has to be at least 8 characters including uppercase, lowercase letters, base-10 digits and/or non-alphanumeric symbols.
By default the password is set to _JumpTeam2122_

## DockerMSSQLRestartScript.ps1
The script that should be used when it is needed to recreate the _MSSQL_ server
```powershell
DockerMSSQLRestartScript.ps1 (-p <password>)
```
The password has to be at least 8 characters including uppercase, lowercase letters, base-10 digits and/or non-alphanumeric symbols.
By default the password is set to _JumpTeam2122_

## Scripts failing to launch

If the scripts can not be executed, try running the following code in PowerShell as administrator
```powershell
set-executionpolicy RemoteSigned
```
