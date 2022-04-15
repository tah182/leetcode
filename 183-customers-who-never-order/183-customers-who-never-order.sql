/* Write your T-SQL query statement below */
;WITH o AS (
    SELECT DISTINCT customerId customerId
    FROM Orders
)
SELECT c.Name Customers
FROM Customers c
LEFT JOIN o
ON c.id = o.customerId
WHERE o.customerId IS NULL