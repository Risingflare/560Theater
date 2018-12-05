/*
Adds user to .User table
	(and maybe .Customer table -- later)
*/

USE cis560_team04;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[AddAccount]
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Email NVARCHAR(128), 
   @Password NVARCHAR(128)
   --isActive BIT NOT NULL DEFAULT(0), -- inactive by default
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT dbo.[User](FirstName,LastName,EmailAddress,[Password],isActive)
	VALUES(@FirstName, @LastName, @Email, @Password, 1); -- 1 is active
/*	INSERT dbo.[Customer](U.UserID)
	SELECT U.UserID
	FROM dbo.[User] U			
	WHERE U.EmailAddress = @EmailAddress;	*/
		-- CAN PROBABLY USE SCOPE IDENTITY FOR THIS
END
GO
