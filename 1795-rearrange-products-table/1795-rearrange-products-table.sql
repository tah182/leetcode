/* Write your T-SQL query statement below */
SELECT product_id, 'store1' AS store, Store1 AS price
FROM Products
WHERE Store1 IS NOT NULL
UNION ALL
SELECT product_id, 'store2' AS store, Store2 AS price
FROM Products
WHERE Store2 IS NOT NULL
UNION ALL
SELECT product_id, 'store3' AS store, Store3 AS price
FROM Products
WHERE Store3 IS NOT NULL