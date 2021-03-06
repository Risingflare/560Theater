USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetShowingID]    Script Date: 12/6/2018 9:10:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Get the showingID for a specific showing
*/
ALTER   PROCEDURE [dbo].[GetShowingID]
	@MovieName NVARCHAR(100),
	@TheaterName NVARCHAR(100),
	@ShowTime Time
AS
Select S.ShowingID as ID
FROM dbo.Showing S
WHERE (S.MovieName = @MovieName) and (S.TheaterName = @TheaterName) and (S.ShowTime = @ShowTime);
