/* Write your T-SQL query statement below */
SELECT c.Name Customers
FROM Customers c
LEFT JOIN Orders o
ON c.id = o.customerId
WHERE o.id IS NULL