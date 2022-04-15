/* Write your T-SQL query statement below */
;WITH Ranks AS (
    SELECT name, salary, departmentId, 
        DENSE_RANK() OVER (PARTITION BY departmentId ORDER BY salary DESC) rank
    FROM Employee
)
SELECT d.name Department, r.name Employee, salary
FROM Department d
INNER JOIN (
    SELECT name, salary, departmentId
    FROM Ranks
    WHERE rank <= 3
) r
ON d.id = r.departmentId