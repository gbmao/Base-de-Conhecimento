# Resumo — CTE, View, Temporary Table e Subquery

| Recurso | Duração | Armazena dados? | Quando usar |
|---------|----------|-----------------|-------------|
| **Subquery** | Apenas durante a consulta | ❌ Não | Consultas simples e filtros pontuais. |
| **CTE (`WITH`)** | Apenas durante a consulta | ❌ Não | Organizar consultas complexas e melhorar a legibilidade. |
| **View** | Permanente | ❌ Não (guarda apenas o `SELECT`) | Reutilizar consultas frequentes como se fossem tabelas. |
| **Temporary Table** | Até o fim da sessão | ✅ Sim | Armazenar resultados intermediários para reutilização e melhor desempenho. |

## Resumindo

### Subquery
- Consulta dentro de outra consulta.
- Ideal para casos simples.
- Pode ficar difícil de ler quando muito aninhada.

```sql
SELECT *
FROM (
    SELECT *
    FROM products
) AS p;
```

---

### CTE (`WITH`)
- Uma subquery com nome.
- Existe apenas durante a execução da consulta.
- Torna consultas grandes muito mais legíveis.

```sql
WITH produtos AS (
    SELECT *
    FROM products
)
SELECT *
FROM produtos;
```

---

### View
- Um `SELECT` salvo no banco.
- Pode ser consultada como uma tabela.
- Não copia os dados (na maioria dos bancos).

```sql
CREATE VIEW vw_products AS
SELECT *
FROM products;
```

Depois:

```sql
SELECT *
FROM vw_products;
```

---

### Temporary Table
- Tabela temporária criada durante a sessão.
- Armazena dados fisicamente.
- Pode ser reutilizada em várias consultas da mesma sessão.

```sql
SELECT *
INTO #temp_products
FROM products;

SELECT *
FROM #temp_products;
```

---

## Regra prática

- **Subquery** → Consulta rápida.
- **CTE** → Organizar consultas complexas.
- **View** → Reutilizar consultas frequentemente.
- **Temporary Table** → Guardar resultados para usar várias vezes.
