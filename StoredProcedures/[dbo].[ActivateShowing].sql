USE [cis560_team04]
GO
/****** Activates Showing by Updating property ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ActivateShowing]
	@id INT
AS

UPDATE dbo.Showing
SET IsActive = 1, UpdatedOn = SYSDATETIMEOFFSET()
WHERE ShowingID = @id;