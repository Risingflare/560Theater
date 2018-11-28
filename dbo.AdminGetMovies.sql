USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[AdminGetMovies]    Script Date: 11/27/2018 9:16:19 PM ******/
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