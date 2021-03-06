USE [cis560_team04]
GO
/****** Deactivates theater by updating IsActive property ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[AdminDeleteTheater]
	@id INT
AS

UPDATE dbo.Theater
SET IsActive = 0, UpdatedOn = SYSDATETIMEOFFSET()
WHERE TheaterID = @id;
GO
/*
Whenever we update the theater table. We will make sure that all showings that are dependent have the same activity as their parent theater.
*/
CREATE OR ALTER TRIGGER dbo.UpdateShowingAfterTheaterDelete
ON dbo.Theater
 FOR UPDATE
 AS
 	UPDATE dbo.Showing
 	SET IsActive = i.IsActive
 	FROM Showing S
	JOIN inserted i on i.TheaterName = S.TheaterName
GO
