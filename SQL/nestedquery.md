# Nested Query (Subquery)

Uma **Nested Query**, também chamada de **Subquery** ou **Subconsulta**, é uma consulta SQL escrita **dentro de outra consulta**.

A ideia é usar o resultado de uma query como informação para outra query.

---

## Estrutura básica

```sql
SELECT coluna
FROM tabela
WHERE coluna = (
    SELECT coluna
    FROM outra_tabela
    WHERE condicao
);
```

A consulta interna fornece um valor ou conjunto de valores para a consulta externa.

---

## Exemplo

```sql
SELECT name
FROM employee
WHERE salary > (
    SELECT AVG(salary)
    FROM employee
);
```

Nesse caso, primeiro é calculada a média salarial:

```sql
SELECT AVG(salary)
FROM employee;
```

Depois, a query externa retorna os funcionários que possuem salário acima dessa média.

---

## Subquery retornando um único valor

Quando a subquery retorna **apenas um valor**, podemos utilizar operadores como:

- `=`
- `>`
- `<`
- `>=`
- `<=`
- `<>`

Exemplo:

```sql
SELECT name
FROM product
WHERE price = (
    SELECT MAX(price)
    FROM product
);
```

A subquery retorna o maior preço da tabela e a query externa busca o produto que possui esse preço.

---

## Subquery retornando vários valores

Quando a subquery retorna **várias linhas**, normalmente utilizamos:

- `IN`
- `NOT IN`
- `EXISTS`
- `NOT EXISTS`

Exemplo com `IN`:

```sql
SELECT name
FROM employee
WHERE department_id IN (
    SELECT id
    FROM department
    WHERE city = 'Rio de Janeiro'
);
```

A subquery retorna os IDs dos departamentos localizados no Rio de Janeiro.

Depois, a query externa retorna os funcionários pertencentes a esses departamentos.

---

## EXISTS

`EXISTS` verifica se a subquery retorna **pelo menos uma linha**.

```sql
SELECT name
FROM customer c
WHERE EXISTS (
    SELECT 1
    FROM orders o
    WHERE o.customer_id = c.id
);
```

Nesse exemplo, são retornados apenas os clientes que possuem pelo menos um pedido.

Dentro de um `EXISTS`, normalmente utilizamos:

```sql
SELECT 1
```

Isso ocorre porque não importa quais dados a subquery retorna.

O banco precisa apenas verificar se **alguma linha existe**.

---

## NOT EXISTS

`NOT EXISTS` faz o contrário de `EXISTS`.

```sql
SELECT name
FROM customer c
WHERE NOT EXISTS (
    SELECT 1
    FROM orders o
    WHERE o.customer_id = c.id
);
```

Nesse caso, são retornados os clientes que **não possuem pedidos**.

---

## Subquery no FROM

Uma subquery também pode ser utilizada no `FROM`.

Nesse caso, o resultado da subquery funciona como uma tabela intermediária.

```sql
SELECT department, average_salary
FROM (
    SELECT department,
           AVG(salary) AS average_salary
    FROM employee
    GROUP BY department
) AS salaries;
```

A consulta interna gera uma tabela temporária com:

- departamento
- média salarial

A consulta externa utiliza esse resultado.

> Subqueries utilizadas no `FROM` normalmente precisam possuir um **alias**.

No exemplo:

```sql
AS salaries
```

---

## Subquery no SELECT

Também é possível utilizar uma subquery para gerar uma coluna.

```sql
SELECT 
    name,
    (
        SELECT COUNT(*)
        FROM orders o
        WHERE o.customer_id = c.id
    ) AS total_orders
FROM customer c;
```

Nesse caso, para cada cliente é calculada a quantidade de pedidos.

---

## Correlated Subquery

Uma **Correlated Subquery** é uma subquery que depende da linha atual da query externa.

```sql
SELECT e.name,
       e.salary
FROM employee e
WHERE e.salary > (
    SELECT AVG(e2.salary)
    FROM employee e2
    WHERE e2.department_id = e.department_id
);
```

Nesse exemplo, a subquery calcula a média salarial do departamento de cada funcionário.

A correlação acontece aqui:

```sql
e2.department_id = e.department_id
```

- `e2` pertence à subquery.
- `e` pertence à query externa.

Portanto, a subquery depende da linha que está sendo analisada pela query externa.

---

## Nested Query vs JOIN

Muitas subqueries também podem ser escritas utilizando `JOIN`.

### Com Subquery

```sql
SELECT name
FROM employee
WHERE department_id IN (
    SELECT id
    FROM department
    WHERE city = 'Rio de Janeiro'
);
```

### Com JOIN

```sql
SELECT e.name
FROM employee e
INNER JOIN department d
    ON e.department_id = d.id
WHERE d.city = 'Rio de Janeiro';
```

Não existe uma regra dizendo que `JOIN` é sempre melhor que uma subquery.

De forma geral:

- `JOIN` → bom para combinar dados de várias tabelas.
- `Subquery` → boa para obter um valor ou conjunto intermediário.
- `EXISTS` → bom quando queremos verificar se determinada relação existe.
- `CTE` → útil para organizar queries maiores e melhorar a legibilidade.

---

## Resumo

```text
Nested Query
│
├── Retorna um único valor
│   └── =, >, <, >=, <=
│
├── Retorna vários valores
│   ├── IN
│   └── NOT IN
│
├── Verifica existência
│   ├── EXISTS
│   └── NOT EXISTS
│
├── Pode aparecer no
│   ├── WHERE
│   ├── SELECT
│   └── FROM
│
└── Correlated Subquery
    └── depende da linha da query externa
```

## Ideia principal

Uma **Nested Query** permite utilizar **o resultado de uma consulta dentro de outra consulta**.
