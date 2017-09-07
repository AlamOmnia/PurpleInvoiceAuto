USE purple;
Select P.PartnerName,P1.PartnerName AS 'IGW',CallCount,
 ROUND(ActualDuration,2) AS 'ActualDuration',
 ROUND(BilledDuration,2) AS 'BilledDuration',
 ROUND(X,2) AS 'SubscriberChargeXBDT',
 ROUND(Y,2) AS 'CarrierCostYUSD'
FROM
(
SELECT CustomerID,SupplierID, COUNT(*) AS CallCount ,SUM(durationsec)/60 AS ActualDuration,
SUM(roundedduration)/60 as BilledDuration,
SUM(SubscriberChargeXOut) AS 'X' ,SUM(CarrierCostYigwout) AS 'Y'

FROM cdrloaded 

WHERE calldirection = 2
AND starttime >= @StartDate
AND starttime < @EndDate
and AnswerTime>=@ans1Date
and AnswerTime<@ans2Date
AND customerid = @ClientID


GROUP BY SupplierID
)x
LEFT JOIN partner P
ON x.CustomerID = P.idpartner
LEFT JOIN partner P1
ON x.SupplierID = P1.idPartner
;
