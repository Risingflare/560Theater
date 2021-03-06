USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[AdminEditMovie]    Script Date: 12/6/2018 9:00:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Allows the user to edit the genre and release year of a given movie.
MovieName - the movie that is going to be edited
Genre - the new Genre that will be given to this movie
ReleaseYear - the new release year date.
*/
ALTER   PROCEDURE [dbo].[AdminEditMovie]
	@MovieName NVARCHAR(100),
	@Genre NVARCHAR(100),
	@ReleaseYear INT,
	@MovieID INT
AS

UPDATE dbo.Movie
	SET Genre = CASE WHEN Genre IS NOT NULL THEN @Genre END,
		ReleaseYear = CASE WHEN ReleaseYear IS NOT NULL THEN @ReleaseYear END,
		UpdatedOn = SYSDATETIMEOFFSET()
WHERE MovieID = @MovieID;
