USE [cis560_team04]
GO
/****** Changes  isActive property of movie ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[AdminDeleteMovie]
	@id INT
AS

UPDATE dbo.Movie
SET IsActive = 0, UpdatedOn = SYSDATETIMEOFFSET()
WHERE MovieID = @id;