USE MovieAppDb;
GO

-- =========================
-- Movies tablosu
-- =========================
CREATE TABLE dbo.Movies
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TMDBId INT NULL,                  -- API'den gelen movie id (null ise manuel)
    Title NVARCHAR(250) NOT NULL,
    Overview NVARCHAR(MAX) NULL,
    ReleaseDate DATE NULL,
    PosterPath NVARCHAR(500) NULL,
    IsManual BIT NOT NULL DEFAULT 0,  -- 0 = API, 1 = Manuel
    IsDeleted BIT NOT NULL DEFAULT 0, -- soft delete
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL
);

-- Indexler
CREATE INDEX IX_Movies_TMDBId ON dbo.Movies (TMDBId);
CREATE INDEX IX_Movies_IsDeleted ON dbo.Movies (IsDeleted);
CREATE INDEX IX_Movies_Title ON dbo.Movies (Title);

-- =========================
-- Ratings / Notes tablosu
-- =========================
CREATE TABLE dbo.Ratings
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MovieId INT NOT NULL,
    UserIdentifier NVARCHAR(100) NULL, -- opsiyonel, ileride kullanýcý için
    Rating TINYINT NOT NULL CHECK (Rating >= 1 AND Rating <= 10),
    Note NVARCHAR(MAX) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Ratings_Movies FOREIGN KEY (MovieId) REFERENCES dbo.Movies(Id)
);

-- Indexler
CREATE INDEX IX_Ratings_MovieId ON dbo.Ratings(MovieId);
GO
