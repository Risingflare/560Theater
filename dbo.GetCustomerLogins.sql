USE cis560_team04;

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[GetCustomerLogins]
AS
SELECT U.EmailAddress as Email
	,U.[Password]
	,U.UserID 
FROM dbo.[User] U
	JOIN dbo.Customer C ON C.UserID = U.UserID;