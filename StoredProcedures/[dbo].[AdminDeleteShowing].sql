USE [cis560_team04]
GO
/****** Deletes showing by modifying property ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[AdminDeleteShowing]
@id INT
AS

UPDATE dbo.Showing
SET IsActive=0,UpdatedOn = SYSDATETIMEOFFSET()
WHERE ShowingID = @id;
