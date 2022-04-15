/* Write your T-SQL query statement below */
;WITH w2 AS (
    SELECT id, temperature, DateAdd(day, -1, recordDate) recordDate
    FROM Weather
)
SELECT w2.id FROM w2
INNER JOIN Weather w1
ON w1.recordDate = w2.recordDate
WHERE w2.temperature > w1.temperature