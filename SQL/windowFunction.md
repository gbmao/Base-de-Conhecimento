# ROW_NUMBER()

## O que é?

`ROW_NUMBER()` é uma **Window Function** que atribui um número sequencial para cada linha do resultado.

```sql
SELECT  country,
        year,
        ROW_NUMBER() OVER (ORDER BY country, year) AS row_num
FROM happiness_scores;
```

## Importante

O `ORDER BY` dentro do `OVER()` **não ordena o resultado da consulta**.

Ele apenas define **a ordem em que as linhas serão numeradas**.

Já o `ORDER BY` no final da consulta define **como o resultado será exibido**.

## Usos mais comuns

- Numerar linhas.
- Pegar o primeiro ou último registro de cada grupo (`PARTITION BY`).
- Remover duplicidades.
- Paginação de resultados.

## Exemplo com PARTITION BY

```sql
SELECT *,
       ROW_NUMBER() OVER (
           PARTITION BY country
           ORDER BY year DESC
       ) AS rn
FROM happiness_scores;
```

Nesse exemplo, a numeração recomeça para cada país.

## Resumo

> `ROW_NUMBER()` cria uma numeração temporária para as linhas. Essa numeração pode ser usada para filtrar, ordenar ou identificar registros, mas **não altera os dados da tabela**.
