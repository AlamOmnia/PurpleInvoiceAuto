USE purple;

SELECT DATE_FORMAT(DATE(AnswerTime),'%d/%m/%Y') AS `DATE`,
COUNT(*) AS CallCount,
ROUND(SUM(durationsec)/60, 2) AS ActualDuration,
ROUND(SUM(RoundedDuration)/60, 2) as BilledDuration

FROM cdrloaded
WHERE calldirection = 1
	AND starttime >= @StartDate
	AND starttime < @EndDate
	and AnswerTime>=@ans1Date
	and AnswerTime<@ans2Date
	AND customerid = @ClientID

GROUP BY  DATE(AnswerTime);