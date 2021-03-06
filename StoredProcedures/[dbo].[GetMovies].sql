USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetMovies]    Script Date: 12/6/2018 9:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Gets the movie information from the database
*/
ALTER   PROCEDURE [dbo].[GetMovies]
AS

SELECT DISTINCT M.MovieName as MovieName, M.IsActive as Active
FROM dbo.Showing S
JOIN dbo.Movie M ON S.MovieName = M.MovieName
