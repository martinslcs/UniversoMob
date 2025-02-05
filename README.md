# Cliente Mob

## Sobre o Projeto
UniversoMob é um sistema simples para cadastro e consulta de clientes. O projeto foi desenvolvido utilizando .NET Core e SQL Server.

## Tecnologias Utilizadas
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap 5

## Configuração do Banco de Dados
1. Configure a string de conexão no `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=ClienteDB;User Id=SEU_USUARIO;Password=SUA_SENHA;"
   }
   ```
2. Execute a migração para criar as tabelas no banco:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## Como Executar o Projeto
1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/cliente-manager.git
   ```
2. Acesse a pasta do projeto:
   ```sh
   cd cliente-manager
   ```
3. Execute o projeto:
   ```sh
   dotnet run
   ```
4. Acesse no navegador:
   ```
   http://localhost:5000
   ```

## Estrutura do Projeto
```
📂 ClienteMob
 ├── 📂 Controllers
 │   ├── ClienteController.cs
 │
 ├── 📂 Models
 │   ├── Cliente.cs
 │
 ├── 📂 Views
 │   ├── 📂 Cliente
 │   │   ├── Index.cshtml
 │   ├── 📂 Shared
 │   │   ├── _Layout.cshtml
 │
 ├── appsettings.json
 ├── Program.cs
 ├── Startup.cs
 └── README.md
```


## Licença
Este projeto está sob a licença MIT.
