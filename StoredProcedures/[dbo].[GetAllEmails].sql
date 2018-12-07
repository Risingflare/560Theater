USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmails]    Script Date: 12/6/2018 9:09:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Used during Create Account process to determine originality

ALTER PROCEDURE [dbo].[GetAllEmails]
AS
SELECT U.EmailAddress as Email
FROM dbo.[User] U