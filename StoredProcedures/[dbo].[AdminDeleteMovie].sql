USE [cis560_team04]
GO
/****** Changes  isActive property of movie ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[AdminDeleteMovie]
	@id INT
AS

UPDATE dbo.Movie
SET IsActive = 0, UpdatedOn = SYSDATETIMEOFFSET()
WHERE MovieID = @id;
GO
/*
Creates a trigger that updates the showtimes whenever its parent movie is changed.
*/
CREATE OR ALTER TRIGGER dbo.UpdateShowingAfterMovieDelete
ON dbo.Movie
FOR UPDATE
 AS
 	UPDATE dbo.Showing
 	SET IsActive = i.IsActive
 	FROM Showing S
 	JOIN inserted i on i.MovieName = S.MovieName
 GO