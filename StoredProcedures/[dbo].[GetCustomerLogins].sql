USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerLogins]    Script Date: 12/6/2018 9:10:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- This is used to accept or reject a user's authentication attempt
ALTER   PROCEDURE [dbo].[GetCustomerLogins]
AS
SELECT U.EmailAddress as Email
	,U.[Password]
	,U.UserID 
FROM dbo.[User] U
	JOIN dbo.Customer C ON C.UserID = U.UserID;