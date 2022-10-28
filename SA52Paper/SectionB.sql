SELECT ItemName 
FROM Item
GROUP BY ItemName
HAVING COUNT(*) > 1;

SELECT o.Name
FROM [Owner] o, Item i
WHERE o.OwnerId = i.OwnerId
GROUP BY o.Name
HAVING (SUM(RentalCost) > 1000);

SELECT i.RentalCost * 7
FROM Item i 
WHERE i.ItemId = 'S007';

CREATE VIEW BudgetItemView 
AS
SELECT ItemId,ItemName,RentalCost
FROM Item
WHERE RentalCost < 100
ORDER BY RentalCost;










