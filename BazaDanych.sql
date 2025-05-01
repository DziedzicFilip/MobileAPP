
CREATE TABLE Uzytkownik (
    Id INT PRIMARY KEY IDENTITY,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Haslo NVARCHAR(100) NOT NULL,
    Nick NVARCHAR(50) NOT NULL
);


CREATE TABLE Rodzaj (
    Id INT PRIMARY KEY IDENTITY,
    Nazwa NVARCHAR(50) NOT NULL
);

CREATE TABLE Film (
    Id INT PRIMARY KEY IDENTITY,
    Tytul NVARCHAR(150) NOT NULL,
    Opis TEXT,
    DataPremiery DATE,
    RodzajId INT FOREIGN KEY REFERENCES Rodzaj(Id)
);


CREATE TABLE Serial (
    Id INT PRIMARY KEY IDENTITY,
    Tytul NVARCHAR(150) NOT NULL,
    Opis TEXT,
    DataStartu DATE,
    RodzajId INT FOREIGN KEY REFERENCES Rodzaj(Id)
);


CREATE TABLE Odcinek (
    Id INT PRIMARY KEY IDENTITY,
    Tytul NVARCHAR(150) NOT NULL,
    NumerSezonu INT,
    NumerOdcinka INT,
    DataPremiery DATE,
    SerialId INT FOREIGN KEY REFERENCES Serial(Id)
);


CREATE TABLE RecenzjaFilmu (
    Id INT PRIMARY KEY IDENTITY,
    Tresc TEXT NOT NULL,
    Ocena INT CHECK (Ocena BETWEEN 1 AND 10),
    Data DATE DEFAULT GETDATE(),
    UzytkownikId INT FOREIGN KEY REFERENCES Uzytkownik(Id),
    FilmId INT FOREIGN KEY REFERENCES Film(Id)
);


CREATE TABLE RecenzjaSerialu (
    Id INT PRIMARY KEY IDENTITY,
    Tresc TEXT NOT NULL,
    Ocena INT CHECK (Ocena BETWEEN 1 AND 10),
    Data DATE DEFAULT GETDATE(),
    UzytkownikId INT FOREIGN KEY REFERENCES Uzytkownik(Id),
    SerialId INT FOREIGN KEY REFERENCES Serial(Id)
);

CREATE TABLE RecenzjaOdcinka (
    Id INT PRIMARY KEY IDENTITY,
    Tresc TEXT NOT NULL,
    Ocena INT CHECK (Ocena BETWEEN 1 AND 10),
    Data DATE DEFAULT GETDATE(),
    UzytkownikId INT FOREIGN KEY REFERENCES Uzytkownik(Id),
    OdcinekId INT FOREIGN KEY REFERENCES Odcinek(Id)
);


CREATE TABLE ListaObejrzane (
    Id INT PRIMARY KEY IDENTITY,
    UzytkownikId INT FOREIGN KEY REFERENCES Uzytkownik(Id),
    FilmId INT NULL FOREIGN KEY REFERENCES Film(Id),
    SerialId INT NULL FOREIGN KEY REFERENCES Serial(Id),
    DataDodania DATE DEFAULT GETDATE()
);


CREATE TABLE ListaObserwowane (
    Id INT PRIMARY KEY IDENTITY,
    UzytkownikId INT FOREIGN KEY REFERENCES Uzytkownik(Id),
    FilmId INT NULL FOREIGN KEY REFERENCES Film(Id),
    SerialId INT NULL FOREIGN KEY REFERENCES Serial(Id),
    DataDodania DATE DEFAULT GETDATE()
);

-- wiele-do-wielu
CREATE TABLE Ulubione (
    Id INT PRIMARY KEY IDENTITY,
    UzytkownikId INT FOREIGN KEY REFERENCES Uzytkownik(Id),
    FilmId INT NULL FOREIGN KEY REFERENCES Film(Id),
    SerialId INT NULL FOREIGN KEY REFERENCES Serial(Id),
    DataDodania DATE DEFAULT GETDATE()
);
