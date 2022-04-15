/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
; WITH Sub AS (
    SELECT Email, MIN(id) Id
    FROM Person
    GROUP BY Email
)
DELETE FROM Person
WHERE Id NOT IN (SELECT id FROM Sub);