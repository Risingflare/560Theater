USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerID]    Script Date: 12/6/2018 9:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[GetCustomerID]
	@UserId INT
AS
SELECT C.CustomerID as CustomerId
FROM dbo.Customer C
WHERE C.UserID = @UserId
