USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[CreateShowing]    Script Date: 12/6/2018 9:07:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
This creates a showing in our database. The parameters needed are the values required to build a showtime.
TheaterName - the name of the theater
MovieName - the name of the movie
Room - in what room will this showtime be played in
ShowTime - the time of the movie showing
Location - In what city is this showing being played in
*/
ALTER   PROCEDURE [dbo].[CreateShowing]
	@TheaterName NVARCHAR(100),
	@MovieName NVARCHAR(100),
	@Room INT,
	@ShowTime TIME,
	@Location NVARCHAR(100)
AS

INSERT dbo.Showing(TheaterName, MovieName, Room, ShowTime, [Location], IsActive)
VALUES
(@TheaterName,@MovieName,@Room,@ShowTime,@Location,1);
