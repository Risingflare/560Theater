USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetTheaters]    Script Date: 12/6/2018 9:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Gets the theaters from our database.
*/
ALTER   PROCEDURE [dbo].[GetTheaters]
AS

SELECT Distinct T.TheaterName as TheaterName, T.Location as Location, T.IsActive as Active
FROM dbo.Showing S
JOIN dbo.Theater T ON T.TheaterName = S.TheaterName
