#EXISTS

##O que é

Ele vai devolver a consulta se ela existir


### exemplo

```sql
SELECT *
FROM Clientes c
WHERE EXISTS (
    SELECT 1
    FROM Pedidos p
    WHERE p.cliente_id = c.id
);
```

Também existe o `NOT EXIST`
