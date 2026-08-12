# Backend .NET Roadmap

## 🟥 Fase 1 — C# sólido

- [ ] Finalizar fundamentos de C#
- [ ] Collections
- [ ] Generics
- [ ] Interfaces
- [ ] Exceptions
- [ ] LINQ
- [ ] Nullable Reference Types
- [ ] async / await
- [ ] Task
- [ ] Debugging no Visual Studio / VS Code

### Objetivo
Conseguir implementar pequenas funcionalidades em C#
sem depender constantemente de exemplos prontos.

---

## 🟥 Fase 2 — Web / HTTP

- [ ] Como HTTP funciona
- [ ] Request / Response
- [ ] GET / POST / PUT / PATCH / DELETE
- [ ] Status Codes
- [ ] Headers
- [ ] JSON
- [ ] REST
- [ ] Postman / Bruno / curl

### Objetivo
Entender o que acontece entre frontend e backend.

---

## 🟥 Fase 3 — ASP.NET Core

- [ ] Criar Web API
- [ ] Minimal APIs
- [ ] Controllers
- [ ] Routing
- [ ] Model Binding
- [ ] DTOs
- [ ] Validation
- [ ] Dependency Injection
- [ ] Configuration
- [ ] Middleware
- [ ] Logging
- [ ] Exception handling

### Projeto
Transformar o Holy Gauge em uma API real.

---

## 🟧 Fase 4 — Banco de dados

### SQL

- [ ] Consolidar JOINs
- [ ] GROUP BY / HAVING
- [ ] Subqueries
- [ ] CTEs
- [ ] Window Functions
- [ ] Transactions
- [ ] Índices
- [ ] Execution Plans
- [ ] Locks / Deadlocks
- [ ] Modelagem relacional
- [ ] Performance

### .NET + Banco

- [ ] ADO.NET — entender o conceito
- [ ] EF Core
- [ ] DbContext / DbSet
- [ ] Migrations
- [ ] Relationships
- [ ] LINQ → SQL
- [ ] Tracking / AsNoTracking
- [ ] Dapper

### Projeto
Persistir abastecimentos do Holy Gauge em banco real.

---

## 🟧 Fase 5 — APIs profissionais

- [ ] Validation
- [ ] Global exception handling
- [ ] Logging estruturado
- [ ] Authentication
- [ ] Authorization
- [ ] JWT
- [ ] Swagger / OpenAPI
- [ ] Pagination
- [ ] Filtering
- [ ] Configuration por ambiente
- [ ] Secrets

### Projeto
Transformar a API do Holy Gauge em algo próximo
de uma aplicação de produção.

---

## 🟧 Fase 6 — Testes

- [ ] xUnit
- [ ] Arrange / Act / Assert
- [ ] Unit Tests
- [ ] Mocking
- [ ] Integration Tests
- [ ] Testes de API

### Projeto
Criar testes para regras de consumo, abastecimento
e endpoints do Holy Gauge.

---

## 🟨 Fase 7 — Engenharia de software

- [ ] SOLID
- [ ] Dependency Injection em profundidade
- [ ] Separation of Concerns
- [ ] Service Layer
- [ ] Repository — entender quando faz sentido
- [ ] Design Patterns fundamentais
- [ ] Code Review
- [ ] Refactoring

---

## 🟨 Fase 8 — Docker

- [ ] Images
- [ ] Containers
- [ ] Dockerfile
- [ ] Volumes
- [ ] Networks
- [ ] Environment Variables
- [ ] Docker Compose

### Projeto

Subir:

Holy Gauge API
+
Banco

com:

docker compose up

---

## 🟨 Fase 9 — CI/CD

- [ ] Build automatizado
- [ ] Testes no pipeline
- [ ] GitHub Actions ou Azure Pipelines
- [ ] Docker build
- [ ] Deploy automatizado

---

## 🟨 Fase 10 — Cloud / Azure

- [ ] Conceitos básicos de cloud
- [ ] App Service
- [ ] Azure SQL
- [ ] Storage
- [ ] Key Vault
- [ ] Application Insights
- [ ] Deploy
- [ ] Logs / monitoring

### Objetivo

Colocar o Holy Gauge online.

---

## 🟦 Fase 11 — Mensageria

- [ ] Conceito de mensageria
- [ ] RabbitMQ
- [ ] Producer / Consumer
- [ ] Queue
- [ ] Exchange
- [ ] Routing
- [ ] ACK / NACK
- [ ] Retry
- [ ] Dead Letter Queue
- [ ] Idempotência
- [ ] Event-driven architecture

---

## 🟦 Fase 12 — Performance / sistemas distribuídos

- [ ] Redis
- [ ] Cache
- [ ] TTL
- [ ] Cache invalidation
- [ ] Concorrência
- [ ] Race conditions
- [ ] Resiliência
- [ ] Observabilidade

---

## ⬜ Futuro

Somente depois de ter uma aplicação backend sólida:

- [ ] Clean Architecture
- [ ] DDD
- [ ] CQRS
- [ ] Microservices
- [ ] Kubernetes
- [ ] System Design mais avançado
