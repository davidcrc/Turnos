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

## install entity framework??
```sh
dotnet tool install --global dotnet-ef --version=3.1
```
> Crear la migracion

```sh
dotnet ef migrations add Migracion
```

> Confirmar las migraciones en la BD
```sh
dotnet ef database update
```