SELECT cr.partnername AS ANS,
SUM(callcount) AS `SumofNoOfCalls`,
SUM(ROUND(ActualDuration,2)) AS `SumofActualDuration`,
SUM(ROUND(RoundedDuration,2)) AS `SumofBilledDurationMinutes`,
SUM(ROUND(X,2)) AS 'SumofX',
SUM(ROUND(Y,6)) AS 'SumofY',
(SELECT 79.0) AS 'USDRate', 
SUM(ROUND(Y*79.0,2)) AS 'SumofY',
SUM(ROUND(x-79.0*y,2)) AS 'SumofZ',
SUM(ROUND(0.15*(x-79.0*y),2)) AS 'SumofICXRevenue'

FROM
(
	SELECT DATE(starttime) AS 'Date',
	customerid,
	COUNT(*) AS CallCount,
	matchedprefixy,
	SUM(durationsec) / 60 AS ActualDuration,
	SUM((15 * (TRUNCATE(c.durationsec / 15, 0)+ 
				CASE
					WHEN ((c.durationsec / 15 - TRUNCATE(c.durationsec / 15, 0))) > 0 THEN 1
					ELSE 0
				END)
			) / 60) AS RoundedDuration,
	SUM(SubscriberChargeXOut) AS X,
	SUM(CarrierCostYigwout) AS Y,
	supplierid
	
	FROM purple.cdrloaded AS c
	WHERE calldirection = 2 AND starttime >= @startTime AND starttime < @endTime
	GROUP BY customerid, matchedprefixy, supplierid, DATE(starttime)
) AS x
LEFT JOIN partner AS cr
	ON x.customerid = cr.idpartner
LEFT JOIN xyzprefix AS ic
	ON x.matchedprefixy = ic.Prefix
LEFT JOIN CountryCode AS cc
	ON ic.CountryCode = cc.Code
LEFT JOIN partner AS cricx
	ON x.supplierid = cricx.idpartner
GROUP BY cr.partnername;