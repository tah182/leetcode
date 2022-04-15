/* Write your T-SQL query statement below */
SELECT w2.id FROM Weather w1
INNER JOIN Weather w2
ON w1.recordDate = DateAdd(day, -1, w2.recordDate)
WHERE w2.temperature > w1.temperature