USE cis560_team04
GO

CREATE OR ALTER PROCEDURE dbo.GetMovies
AS

SELECT M.MovieName
FROM cis560_team04.dbo.Movie M
GO

CREATE OR ALTER PROCEDURE dbo.GetTheaters
AS

SELECT T.TheaterName as TheaterName, T.Location as Location
FROM cis560_team04.dbo.Theater T
GO

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

SELECT *
FROM dbo.Showing

EXEC dbo.CreateShowing N'Regal Hollywood Stadium 14 - Topeka', N'Venom',6,'19:30:00',N'Topeka'