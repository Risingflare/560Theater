USE [cis560_team04]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- evaluates validity of new account: maybe add parameter and make it a "CheckEmailAddress" one
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmails]
AS
SELECT U.EmailAddress
FROM cis560_team04.dbo.[User] U