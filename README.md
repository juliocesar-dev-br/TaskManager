# TaskManager — Gerenciamento de Tarefas

## Descrição

API REST para gerenciamento de tarefas desenvolvida durante meus estudos de Back-end com C# e .NET.

## Tecnologias

* C#
* ASP.NET Core
* Entity Framework Core
* PostgreSQL
* Postman
* Git/GitHub
* Docker

## Arquitetura

```text
HTTP Request
     ↓
Controller
     ↓
Service
     ↓
DbContext
     ↓
Entity Framework Core
     ↓
PostgreSQL
```

## Endpoints

```text
POST   /tarefas
GET    /tarefas
GET    /tarefas/{id}
PUT    /tarefas/{id}
DELETE /tarefas/{id}
```

## O que já foi implementado

* ✅ Criar tarefa
* ✅ Listar tarefas
* ✅ Buscar tarefa por ID
* ✅ Atualizar tarefa
* ✅ Remover tarefa
* ✅ Persistência com PostgreSQL
* ✅ Entity Framework Core
* ✅ Migrations

## Status

**Em desenvolvimento.**
