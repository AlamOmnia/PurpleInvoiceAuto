USE purple;
SELECT c.partnername AS `ANS`, SUM(callcount) AS `TotalCallCount`,
       SUM(actualduration) AS `Total Actual Duration`,
       SUM(billedduration) AS 'Total Billed Duration', '0.04' AS 'Rate',
	   (SUM(billedduration) * 0.04) AS 'Amount',
       (SUM(billedduration) * 0.04 * 0.15) AS 'Vat',
       ((SUM(billedduration) * 0.04 * 0.15) + (SUM(billedduration) * 0.04)) AS 'Invoice'
FROM
(
	SELECT customerid,supplierid,DATE_FORMAT(DATE(starttime), '%d/%m/%Y') 
		`Date`, COUNT(*) AS CallCount,
	  SUM(durationsec) / 60 ActualDuration,
	  SUM(
		CASE 
				WHEN (TRUNCATE(durationsec - TRUNCATE(durationsec , 0), 1)) >= 0 THEN CEILING (durationsec)
				ELSE FLOOR(durationsec)
			END
		) / 60 AS RoundedDuration,
	  SUM(RoundedDuration) / 60 AS BilledDuration
    
	FROM   purple.cdrloaded
	WHERE  calldirection = 1
		   AND starttime >= @starttime
		   AND starttime < @endtime
	GROUP  BY customerid,supplierid, DATE(starttime)
) x
LEFT JOIN partner c
	  ON x.customerid = c.idpartner
LEFT JOIN partner s
	  ON x.supplierid = s.idpartner
GROUP  BY c.partnername;