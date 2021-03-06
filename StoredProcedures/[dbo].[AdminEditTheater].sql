USE [cis560_team04]
GO
/****** Updates properties of a theater ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Allows the user to edit the location of the location of the given theater
*/
ALTER   PROCEDURE [dbo].[AdminEditTheater]
	@TheaterName NVARCHAR(100),
	@Location NVARCHAR(100),
	@TheaterID INT
AS

Update dbo.Theater
		SET Location = CASE WHEN Location IS NOT NULL THEN @Location END,
			UpdatedOn = SYSDATETIMEOFFSET()
			FROM dbo.Theater T
			WHERE T.TheaterID = @TheaterID;
