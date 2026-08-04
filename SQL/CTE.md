#CTE

- Basicamente **cte** é uma forma de dar legibilidade as consultas do `SQL`


***Ex.***

```sql
WITH	fac as (	SELECT	p.factory,
				COUNT(*)  as num_products
				FROM	products p 
				group by p.factory ),
		fn as (SELECT a.factory, a.product_name   from products a )
				
SELECT fn.factory, fn.product_name, fac.num_products 
from fn left JOIN fac on fn.factory = fac.factory 
order by fac.num_products desc

```


```sql
SELECT
    p.factory,
    p.product_name,
    f.num_products
FROM products p
LEFT JOIN (
    SELECT
        factory,
        COUNT(*) AS num_products
    FROM products
    GROUP BY factory
) AS f
    ON p.factory = f.factory
ORDER BY f.num_products DESC;

```

- Acredito que é bem útil no caso de uma proc ou query. trazendo visibilidade e facilidade em leitura
