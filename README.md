Person API - CRUD com ASP.NET Core + EF Core + SQLite
API REST desenvolvida com .NET 7 utilizando o padrão Minimal API, Entity Framework Core e banco SQLite. O projeto permite operações CRUD de pessoas e possui documentação interativa via Swagger.

🛠️ Tecnologias
ASP.NET Core (.NET 7)

Entity Framework Core

SQLite

Swagger (Swashbuckle)

Visual Studio Code

🔗 Funcionalidades
CRUD completo de pessoas (POST, GET, PUT, DELETE)

Integração com banco de dados SQLite

Estrutura com separação de rotas, modelos e contexto

Documentação via Swagger UI

Ambiente local com HTTPS habilitado

⚙️ Como executar o projeto
1. Clone o repositório
  No terminal da IDE utilizada, Visual Studio Code, por exemplo, dê o comando dentro pasta em que estão os arquivos do projeto, exeplo: C:\API CRUD\Person:

git clone https://github.com/seu-usuario/Person-API.git

2. Restaure os pacotes e compile

dotnet restore
dotnet build

3. Rode a aplicação com perfil HTTPS
4. 
dotnet run --launch-profile https

No terminal da IDE, o projeto confira o link informado onde está rodando o projeto, por exemplo:

http://localhost:5267

https://localhost:7162

4. Acesse o Swagger:

https://localhost:7162/swagger

Utilize livremente a aplicação.

👨‍💻 Sobre mim

Wellington Garcia Silva
https://www.linkedin.com/in/wellington-garcia-/
