USE [cis560_team04]
GO
/****** Adds theater with attributes ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*

*/
ALTER   PROCEDURE [dbo].[AddTheater]
@TheaterName NVARCHAR(100),
@Location NVARCHAR(100)
AS

INSERT dbo.Theater(TheaterName, [Location], IsActive)
VALUES
(@TheaterName, @Location, 1);
