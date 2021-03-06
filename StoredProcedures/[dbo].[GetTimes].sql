USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetTimes]    Script Date: 12/6/2018 9:10:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Gets the any showtimes already created for in a theater(the parameter). This is used for auto generating showtimes. This allows me to not recreate multiple showtimes
TheatName - the name of the theater we want the times from
*/
ALTER   PROCEDURE [dbo].[GetTimes]
	@TheaterName NVARCHAR(100)
AS

SELECT S.ShowTime as Times
FROM dbo.Showing S
	JOIN dbo.Theater T ON T.TheaterName = S.TheaterName
WHERE T.TheaterName = @TheaterName

