USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[AdminGetShowing]    Script Date: 11/27/2018 9:16:19 PM ******/
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