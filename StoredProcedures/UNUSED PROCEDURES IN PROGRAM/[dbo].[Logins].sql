USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[Logins]    Script Date: 12/6/2018 9:10:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Gets logins for all users 
ALTER   PROCEDURE [dbo].[Logins]
AS
SELECT U.EmailAddress as Email
	,U.[Password]
FROM dbo.[User] U;