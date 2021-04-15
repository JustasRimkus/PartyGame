"----------------Migration list----------------"
dotnet ef --startup-project ..\PartyGame\ migrations list
$migrationName = Read-Host -Prompt "Migration name"
dotnet ef --startup-project ..\PartyGame\ database update $migrationName