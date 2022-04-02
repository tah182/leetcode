/* Write your T-SQL query statement below */
SELECT
    firstName, 
    lastName, 
    City, 
    State
FROM Person P 
LEFT JOIN Address A
ON P.PersonId = A.PersonId