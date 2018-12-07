USE cis560_team04
GO
/*
Gets the movie information from the database
*/
CREATE OR ALTER PROCEDURE dbo.GetMovies
AS

SELECT DISTINCT M.MovieName as MovieName, M.IsActive as Active
FROM dbo.Showing S
JOIN dbo.Movie M ON S.MovieName = M.MovieName
GO

/*
Gets the any showtimes already created for in a theater(the parameter). This is used for auto generating showtimes. This allows me to not recreate multiple showtimes
TheatName - the name of the theater we want the times from
*/
CREATE OR ALTER PROCEDURE dbo.GetTimes
	@TheaterName NVARCHAR(100)
AS

SELECT S.ShowTime as Times
FROM dbo.Showing S
	JOIN dbo.Theater T ON T.TheaterName = S.TheaterName
WHERE T.TheaterName = @TheaterName

GO
/*
Gets the theaters from our database.
*/
CREATE OR ALTER PROCEDURE dbo.GetTheaters
AS

SELECT Distinct T.TheaterName as TheaterName, T.Location as Location, T.IsActive as Active
FROM dbo.Showing S
JOIN dbo.Theater T ON T.TheaterName = S.TheaterName
GO

/*
This creates a showing in our database. The parameters needed are the values required to build a showtime.
TheaterName - the name of the theater
MovieName - the name of the movie
Room - in what room will this showtime be played in
ShowTime - the time of the movie showing
Location - In what city is this showing being played in
*/
CREATE OR ALTER PROCEDURE dbo.CreateShowing
	@TheaterName NVARCHAR(100),
	@MovieName NVARCHAR(100),
	@Room INT,
	@ShowTime TIME,
	@Location NVARCHAR(100)
AS

INSERT dbo.Showing(TheaterName, MovieName, Room, ShowTime, [Location], IsActive)
VALUES
(@TheaterName,@MovieName,@Room,@ShowTime,@Location,1);
GO
/*
Allows the user to edit the genre and release year of a given movie.
MovieName - the movie that is going to be edited
Genre - the new Genre that will be given to this movie
ReleaseYear - the new release year date.
*/
CREATE OR ALTER PROCEDURE dbo.AdminEditMovie
	@MovieName NVARCHAR(100),
	@Genre NVARCHAR(100),
	@ReleaseYear INT
AS

UPDATE dbo.Movie
	SET Genre = @Genre,
		ReleaseYear = @ReleaseYear,
		UpdatedOn = SYSDATETIMEOFFSET()
WHERE MovieName = @MovieName;
GO

/*
Adds the given movie to our database
MovieName - the name of the new movie
ReleaseYear -  when the movie was released
Genre - the movies' genre
*/
CREATE OR ALTER PROCEDURE dbo.AddMovie
@MovieName NVARCHAR(100),
@ReleaseYear INT,
@Genre NVARCHAR (100)
AS

INSERT dbo.Movie(MovieName, ReleaseYear, Genre, IsActive)
VALUES
(@MovieName, @ReleaseYear, @Genre, 1);
GO

/*
Allows the user to edit the location of the location of the given theater
*/
CREATE OR ALTER PROCEDURE dbo.AdminEditTheater
	@TheaterName NVARCHAR(100),
	@Location NVARCHAR(100)
AS

Update dbo.Theater
SET Location = @Location,
	UpdatedOn = SYSDATETIMEOFFSET()
	FROM dbo.Theater T
	WHERE T.TheaterName = @TheaterName;
GO
/*

*/
CREATE OR ALTER PROCEDURE dbo.AdminDeleteTheater
	@id INT
AS

UPDATE dbo.Theater
SET IsActive = 0, UpdatedOn = SYSDATETIMEOFFSET()
WHERE TheaterID = @id;
GO
/*

*/
CREATE OR ALTER TRIGGER dbo.UpdateShowingAfterTheaterDelete
ON dbo.Theater
FOR UPDATE
AS
	UPDATE dbo.Showing
	SET IsActive = i.IsActive
	FROM Showing S
	JOIN inserted i on i.TheaterName = S.TheaterName
GO
/*

*/
CREATE OR ALTER PROCEDURE dbo.AddTheater
@TheaterName NVARCHAR(100),
@Location NVARCHAR(100)
AS

INSERT dbo.Theater(TheaterName, [Location], IsActive)
VALUES
(@TheaterName, @Location, 1);
GO
/*

*/
CREATE OR ALTER PROCEDURE dbo.AdminDeleteShowing
@id INT
AS

UPDATE dbo.Showing
SET IsActive=0,UpdatedOn = SYSDATETIMEOFFSET()
WHERE ShowingID = @id;
GO

CREATE OR ALTER TRIGGER dbo.UpdateShowingAfterMovieDelete
ON dbo.Movie
FOR UPDATE
AS
	UPDATE dbo.Showing
	SET IsActive = i.IsActive
	FROM Showing S
	JOIN inserted i on i.MovieName = S.MovieName
GO
/*
This gets the showings from our database
MovieName - the name of the movie. Can be left blank
TheaterName - the name of the theater. Can be left blank
ShowTime - the time of the showing. Can also be left as 00:00:00
*/
CREATE OR ALTER PROCEDURE dbo.CustomerGetShowing
	@MovieName NVARCHAR(100),
	@TheaterName NVARCHAR(100),
	@ShowTime Time
AS
Select S.MovieName, S.TheaterName, S.ShowTime, S.Room, S.[Location], S.IsActive as Active
FROM dbo.Showing S
WHERE (S.MovieName = @MovieName or @MovieName = N'') and (S.TheaterName = @TheaterName or @TheaterName = N'') and (S.ShowTime = @ShowTime or @ShowTime = '00:00:00');
	  
GO
/*
Get the showingID for a specific showing
*/
CREATE OR ALTER PROCEDURE dbo.GetShowingID
	@MovieName NVARCHAR(100),
	@TheaterName NVARCHAR(100),
	@ShowTime Time
AS
Select S.ShowingID as ID
FROM dbo.Showing S
WHERE (S.MovieName = @MovieName) and (S.TheaterName = @TheaterName) and (S.ShowTime = @ShowTime);
GO

/*

*/
CREATE OR ALTER PROCEDURE dbo.CreateTicket
	@CustomerId INT,
	@ShowingId INT
AS
INSERT dbo.Ticket(CustomerID, ShowingID, IsActive)
VALUES(@CustomerId,@ShowingId,1);
GO
/*

*/
CREATE OR ALTER PROCEDURE dbo.GetTicket
	@CustomerId INT
AS
SELECT  S.MovieName, S.TheaterName, S.[Location], S.ShowTime, S.Room, S.CreatedOn, T.IsActive as Active, T.TicketID as ID
FROM dbo.Ticket T
	JOIN dbo.Showing S ON S.ShowingID = T.ShowingID
WHERE T.CustomerID = @CustomerId and T.IsActive = 1;
GO

CREATE OR ALTER PROCEDURE dbo.CustomerDeleteTicket
	@TicketId as INT
AS
UPDATE dbo.Ticket
SET IsActive = 0,
	UpdatedOn = SYSDATETIMEOFFSET()
WHERE TicketID = @TicketId;
GO 

EXEC dbo.GetTicket 1