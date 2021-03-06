USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetAdminLogins]    Script Date: 12/6/2018 9:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Used to authenticate admins
ALTER   PROCEDURE [dbo].[GetAdminLogins]
AS
SELECT U.EmailAddress as Email
	,U.[Password]
	,U.UserID
FROM dbo.[User] U
	JOIN dbo.[Admin] A ON A.UserID = U.UserID;