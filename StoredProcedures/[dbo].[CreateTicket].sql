USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[CreateTicket]    Script Date: 12/6/2018 9:07:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
	Accepts a customer and showing as parameters to create a ticket
*/
ALTER   PROCEDURE [dbo].[CreateTicket]
	@CustomerId INT,
	@ShowingId INT
AS
INSERT dbo.Ticket(CustomerID, ShowingID, IsActive)
VALUES(@CustomerId,@ShowingId,1);
