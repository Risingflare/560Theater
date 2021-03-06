USE [cis560_team04]
GO
/****** Object:  StoredProcedure [dbo].[GetTicket]    Script Date: 12/6/2018 9:10:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
	Gets a ticket for a certain user
*/
ALTER   PROCEDURE [dbo].[GetTicket]
	@CustomerId INT
AS
SELECT  S.MovieName, S.TheaterName, S.[Location], S.ShowTime, S.Room, S.CreatedOn, T.IsActive as Active, T.TicketID as ID
FROM dbo.Ticket T
	JOIN dbo.Showing S ON S.ShowingID = T.ShowingID
WHERE T.CustomerID = @CustomerId and T.IsActive = 1;
