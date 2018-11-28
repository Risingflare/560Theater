USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[AdminGetTheater]    Script Date: 11/27/2018 9:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[AdminGetTheater]
AS

SELECT T.TheaterID,
	T.TheaterName,
	T.[Location],
	T.IsActive,
	T.CreatedOn,
	T.UpdatedOn
FROM cis560_team04.dbo.Theater T