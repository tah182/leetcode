/* Write your T-SQL query statement below */

WITH Subq AS (
    SELECT TOP(2)
    RANK() OVER(ORDER BY Salary DESC) Row,
        Salary
    FROM Employee
    UNION Select 2, NULL
)
SELECT TOP(1) Salary AS SecondHighestSalary 
FROM Subq
WHERE Row = 2
ORDER BY Salary DESC