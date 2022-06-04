/* Write your T-SQL query statement below */
SELECT * 
FROM Patients
WHERE conditions LIKE 'Diab1%'
    OR conditions LIKE '% Diab1%'