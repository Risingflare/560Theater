USE [cis560_team04]
GO
/****** Activates movie by updating isActive property ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ActivateMovie]
	@id INT
AS

UPDATE dbo.Movie
SET IsActive = 1, UpdatedOn = SYSDATETIMEOFFSET()
WHERE MovieID = @id;