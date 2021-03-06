USE [cis560_team04]
GO
/****** Inserts created account into User and Customer Database -- ADMINS ARE STATIC ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[AddAccount]
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Email NVARCHAR(128), 
   @Password NVARCHAR(128)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    INSERT dbo.[User](FirstName,LastName,EmailAddress,[Password],isActive)
	VALUES(@FirstName, @LastName, @Email, @Password, 1); -- 0 => 1, indicating that the user is active
	INSERT dbo.[Customer](U.UserID)
	SELECT U.UserID -- User is also added to the Customer database with the same UserID
	FROM dbo.[User] U			
	WHERE U.EmailAddress = @Email;
END