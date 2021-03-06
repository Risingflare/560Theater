USE [cis560_team04]
GO
/****** Returns all rows in dbo.Movie ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[AdminGetMovies]
AS

SELECT M.MovieID,
	M.MovieName,
	M.ReleaseYear,
	M.Genre,
	M.IsActive,
	M.CreatedOn,
	M.UpdatedOn
FROM cis560_team04.dbo.Movie M