Param(
    [string]$p = "Pwd12345"
)﻿

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=$p" -p 1434:1433 --name familysql -d mcr.microsoft.com/mssql/server:2019-latest
