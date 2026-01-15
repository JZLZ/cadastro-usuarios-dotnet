# 📌 Cadastro de Usuários – API REST em .NET

API REST desenvolvida com **ASP.NET Core** para gerenciamento de usuários, utilizando **Entity Framework Core** e **SQL Server**.  
Este projeto tem como objetivo demonstrar conhecimentos práticos em desenvolvimento backend com a plataforma Microsoft, sendo ideal para **portfólio e processos seletivos de estágio/júnior**.

---

## 🚀 Tecnologias Utilizadas

- .NET (ASP.NET Core)
- C#
- Entity Framework Core
- SQL Server (LocalDB / Express)
- Swagger (OpenAPI)
- Visual Studio Code
- Git & GitHub

---

## 🏗️ Estrutura do Projeto

CadastroUsuarios
│
├── Controllers
│ └── UsuarioController.cs
│
├── Data
│ └── UsuarioContext.cs
│
├── Models
│ └── Usuario.cs
│
├── Program.cs
├── appsettings.json
└── README.md


---

## 📋 Funcionalidades

- Cadastro de usuários
- Listagem de usuários
- Atualização de usuários
- Remoção de usuários
- Validações de campos com DataAnnotations
- Integração com SQL Server via Entity Framework Core
- Documentação automática da API com Swagger

---

## 🔌 Endpoints da API

| Método | Endpoint | Descrição |
|------|--------|----------|
| GET | `/api/Usuario` | Lista todos os usuários |
| POST | `/api/Usuario` | Cria um novo usuário |
| PUT | `/api/Usuario/{id}` | Atualiza um usuário |
| DELETE | `/api/Usuario/{id}` | Remove um usuário |

---

## 🧪 Testando a API

A API pode ser testada utilizando o **Swagger UI**:

http://localhost:5090/swagger/index.html


### Exemplo de requisição (POST)

```json
{
  "nome": "Luiz Amorim",
  "email": "luiz@email.com",
  "senha": "123456"
}

🗄️ Banco de Dados

O projeto utiliza SQL Server integrado ao Entity Framework Core.

🎯 Objetivo do Projeto

Aplicar conceitos de API REST

Praticar Entity Framework Core

Trabalhar com Migrations

Desenvolver um CRUD completo

Servir como projeto de portfólio profissional

📌 Próximas Melhorias

Implementação de DTOs

Criptografia de senha

Autenticação com JWT

Tratamento global de erros

Testes automatizados

Paginação e filtros

👤 Autor

Luiz Amorim
Desenvolvedor Full Stack em formação | Técnico em Eletrônica
Foco em .NET, Backend e Desenvolvimento de Sistemas