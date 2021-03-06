USE [cis560_team04]
GO
/****** Queries all showings from dbo.Showing table ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[AdminGetShowing]
AS

SELECT S.ShowingID,
	S.TheaterName,
	S.MovieName,
	S.Room,
	S.ShowTime,
	S.[Location],
	S.IsActive,
	S.CreatedOn,
	S.UpdatedOn
FROM cis560_team04.dbo.Showing S