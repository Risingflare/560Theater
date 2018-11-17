DROP TABLE IF EXISTS dbo.[Admin]
DROP TABLE IF EXISTS dbo.Customer
DROP TABLE IF EXISTS dbo.[User]
DROP TABLE IF EXISTS dbo.Ticket
DROP TABLE IF EXISTS dbo.Showtime
DROP TABLE IF EXISTS dbo.Theater
DROP TABLE IF EXISTS dbo.Movie




CREATE TABLE dbo.[User]
(
   UserID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
   FirstName NVARCHAR(32) NOT NULL,
   LastName NVARCHAR(32) NOT NULL ,
   EmailAdress NVARCHAR(128) NOT NULL ,
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   "Password" NVARCHAR(128) NOT NULL,
   UNIQUE(FirstName, LastName, EmailAdress)
);

CREATE TABLE dbo.[Admin]
(
   AdminID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
   UserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

CREATE TABLE dbo.Customer
(
   CustomerID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
   UserID INT NOT NULL FOREIGN KEY REFERENCES [User](UserID),
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

CREATE TABLE dbo.Theater
(
	TheaterID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	TheaterName NVARCHAR(32) NOT NULL,
	[Location] NVARCHAR(32) NOT NULL,
	IsActive BIT NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UNIQUE(TheaterName, [Location])
);

--Documentation says Release Year should be Unique, but that doesn't make sense?

CREATE TABLE dbo.Movie
(
	MovieID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MovieName NVARCHAR(32) NOT NULL,
	ReleaseYear INT NOT NULL,
	Genre NVARCHAR(32) NOT NULL,
	IsActive BIT NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UNIQUE(MovieName)
);

CREATE TABLE dbo.Showing
(
	ShowingID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TheaterName NVARCHAR(32) NOT NULL ,
	MovieName NVARCHAR(32) NOT NULL FOREIGN KEY REFERENCES dbo.Movie(MovieName),
	Room INT NOT NULL,
	ShowTime TIME NOT NULL,
	[Location] NVARCHAR(32) NOT NULL,
	IsActive BIT NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UNIQUE(Room, ShowTime),
	FOREIGN KEY(TheaterName, [Location]) REFERENCES dbo.Theater(TheaterName,[Location])
);

CREATE TABLE dbo.Ticket
(
   CustomerID INT NOT NULL FOREIGN KEY REFERENCES [Customer](CustomerID),
   ShowingID INT NOT NULL FOREIGN KEY REFERENCES [Showing](ShowingID),
   IsActive BIT NOT NULL,
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   PRIMARY KEY(CustomerID, ShowingID)
);
						  
INSERT dbo.Movie(MovieName, ReleaseYear, Genre, IsActive)
VALUES
	('Pulp Fiction',1994,'Crime, Drama', 1 ),
	('The Lord of the Rings: The Return of the King',2003,'Action, Adventure, Drama',1 ),
	('The Dark Knight',2008,'Action, Crime, Drama',1 ),
	('Shrek',2001,'Animation, Adventure, Comedy',1),
	('Les Misérables',2012,'Drama, History, Musical',1),
	('Avatar',2009,'Action, Adventure, Fantasy',1 ),
	('Avengers: Infinity War',2018,'Action, Adventure, Fantasy',1),
	('A Quiet Place',2018,'Drama, Horror, Mystery',1),
	('Star Wars: The Last Jedi',2017,'Action, Adventure, Fantasy',1 ),
	('Star Wars: Episode IV - A New Hope',1977,'Action, Adventure, Fantasy',1),
	('Finding Dory',2016,'Animation, Adventure, Comedy',1),
	('The Wizard of Oz',1939,'Adventure, Family, Fantasy',1 ),
	('Get Out',2017,'Horror, Mystery, Thriller',1),
	('Inside Out',2015,'Animation, Adventure, Comedy',1),
	('Tropic Thunder',2008,'Action, Adventure, Comedy',1 ),
	('Ready Player One',2018,'Action, Adventure, Sci-Fi',1),
	('Incredibles 2',2018,'Animation, Action, Adventure',1),
	('Robin Hood',2018,'Action,Adventure',1),
	('Bohemian Rhapsody',2018,'Biography, Drama, Music',1),
	('Venom',2018,'Action, Sci-Fi',1);	
						  
INSERT dbo.Theater(TheaterName, [Location],IsActive)
VALUES
	('AMC Dine-IN Manhattan 13','Manthattan',1),
	('Regal Hollywood Stadium 14 - Topeka','Topeka',1),
	('B & B Shawnee 18','Shawnee',1),
	('Cinetopia Overland Park 18','Overland Park',1),
	('AMC Town Center 20','Leadwood',1);