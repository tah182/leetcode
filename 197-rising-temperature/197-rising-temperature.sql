/* Write your T-SQL query statement below */
;WITH w2 AS (
    SELECT id, temperature, DateAdd(day, -1, recordDate) recordDate
    FROM Weather
)
SELECT w2.id FROM Weather w1
INNER JOIN w2
ON w1.recordDate = w2.recordDate
WHERE w2.temperature > w1.temperature