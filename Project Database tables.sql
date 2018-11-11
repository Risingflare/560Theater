

CREATE TABLE Projcet."User"
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

CREATE TABLE Projcet."Admin"
(
   AdminID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
   UserID INT NOT NULL FOREIGN KEY,
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

CREATE TABLE Projcet.Customer
(
   CustomerID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
   UserID INT NOT NULL FOREIGN KEY,
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);

CREATE TABLE Project.Ticket
(
   CustomerID INT NOT NULL FOREIGN KEY ,
   ShowingID INT NOT NULL FOREIGN KEY ,
   IsActive BIT NOT NULL,
   CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
   PRIMARY KEY(CustomerID, ShowingID)
);
