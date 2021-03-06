USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[CustomerGetShowing]    Script Date: 12/6/2018 9:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
This gets the showings from our database
MovieName - the name of the movie. Can be left blank
TheaterName - the name of the theater. Can be left blank
ShowTime - the time of the showing. Can also be left as 00:00:00
*/
ALTER   PROCEDURE [dbo].[CustomerGetShowing]
	@MovieName NVARCHAR(100),
	@TheaterName NVARCHAR(100),
	@ShowTime Time
AS
Select S.MovieName, S.TheaterName, S.ShowTime, S.Room, S.[Location], S.IsActive as Active
FROM dbo.Showing S
WHERE (S.MovieName = @MovieName or @MovieName = N'') and (S.TheaterName = @TheaterName or @TheaterName = N'') and (S.ShowTime = @ShowTime or @ShowTime = '00:00:00');
	  
