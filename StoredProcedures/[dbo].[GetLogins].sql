USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetLogins]    Script Date: 12/6/2018 9:10:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Gets login for all users
ALTER   PROCEDURE [dbo].[GetLogins]
AS
SELECT U.EmailAddress as Email
	,U.[Password]
FROM dbo.[User] U;