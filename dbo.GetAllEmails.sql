USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmails]    Script Date: 12/4/2018 7:27:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetAllEmails]
AS
SELECT U.EmailAddress as Email
FROM dbo.[User] U