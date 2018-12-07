USE [cis560_team04]
GO
/****** Deactivates theater by updating IsActive property ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[AdminDeleteTheater]
	@id INT
AS

UPDATE dbo.Theater
SET IsActive = 0, UpdatedOn = SYSDATETIMEOFFSET()
WHERE TheaterID = @id;
