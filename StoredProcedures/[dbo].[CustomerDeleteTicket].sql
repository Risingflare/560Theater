USE [cis560_team04]
GO
/****** Updates isActive property of ticket ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER   PROCEDURE [dbo].[CustomerDeleteTicket]
	@TicketId as INT
AS
UPDATE dbo.Ticket
SET IsActive = 0,
	UpdatedOn = SYSDATETIMEOFFSET()
WHERE TicketID = @TicketId;
