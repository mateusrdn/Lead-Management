# Lead-Management
Sistema de gerenciamento de leads, com backend em .NET 6 (API RESTful) e frontend em Angular (SPA). A API é responsável pela lógica de negócios e persistência de dados, enquanto a aplicação Angular oferece a interface de usuário. Projetado para rodar localmente com SQL Server e Entity Framework Core.

# Execução Local (Angular + .Net)

Pré-requisitos:

.NET 6 SDK

Node.js + npm

Angular CLI (npm install -g @angular/cli)

SQL Server (ou ajuste para outro SGBD compatível)

Git

# Como Rodar

**1. Backend (.Net API)**

**Passos:**

*1. Abra o terminal e navegue até a API:*

```
cd caminho/para/o/repositorio/LeadManagement/LeadManagement.Api
```

*2. Edite o appsettings.json com:*

```
{
  "ConnectionStrings": {
    "DefaultConnection": "SUA_STRING_DE_CONEXAO_AQUI"
  }
}
```

*3. Restaure as dependências:*

```
dotnet restore
```

*4. Criar Migração:*

```
dotnet ef migrations add [Nome da migração]
```

*5. Aplique as migrações do banco:*

```
dotnet ef database update
```

*6. Execute a API:*

```
dotnet run
```

**2. Frontend (Angular)**

*1. Navegue até o projeto Angular:*

```
cd caminho/para/o/repositorio/angular
```

*2. Configure o endpoint da API:*

* Edite src/environments/environment.ts:

```
export const environment = {
  API_URL: "URL_DA_SUA_API_AQUI"
};
```

*3. Instale as dependências:*

```
npm install
```

*4. Rode o frontend:*

```
ng serve -o
```

- A aplicação abrirá automaticamente em http://localhost:4200/.
