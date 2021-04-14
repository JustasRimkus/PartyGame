$migrationName = Read-Host -Prompt "Migration name"
dotnet ef --startup-project ..\PartyGame\ migrations add $migrationName --project ..\Database\
dotnet ef --startup-project ..\PartyGame\ database update