# Init
- dotnet new -h
```sh
dotnet new mvc
```

## Hide folders to vscode
 - Preferences -> TextEditor -> Files : Exclude : **/bin , **/obj

## Compile and Run
```sh
dotnet run
```

## Conect to db ( ver este commit )

> add to appsettings.json:
```json
"ConnectionStrings": {
  "TurnosContext": "Data Source=.\\;Initial Catalog=Turnos;Persist Security Info=false;Trusted_Conecction=True"
},
```