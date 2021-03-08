Create Table Kategorie(
kategoriaID int identity(1,1) PRIMARY KEY,
NazwaKategorii varchar(40))

Create Table Filmy(
filmID int identity(1,1) PRIMARY KEY,
kategoriaID int FOREIGN KEY REFERENCES Kategorie(kategoriaID),
tytul varchar(40),
rezyser varchar(40),
RokProdukcji int)

Create Table Aktorzy(
aktorID int identity(1,1) PRIMARY KEY,
Imie varchar(40),
Nazwisko varchar(40))

Create Table FilmyAktorzy(
filmID int FOREIGN KEY REFERENCES Filmy(filmID),
aktorID int FOREIGN KEY REFERENCES Aktorzy(aktorID))

insert into Kategorie Values('Akcja')
insert into Kategorie Values('Animacja')
insert into Kategorie Values('Dokumentalny')
insert into Kategorie Values('Dramat')
insert into Kategorie Values('Fantasy')
insert into Kategorie Values('Horror')

insert into Filmy Values(1, 'Matrix', 'Lilly Wachowski', 1999)
insert into Filmy Values(1, 'Mroczny Rycerz', 'Christopher Nolan', 2008)
insert into Filmy Values(2, 'Shrek', 'Andrew Adamson', 2001)
insert into Filmy Values(2, 'Król Lew', 'Rob Minkoff', 1994)
insert into Filmy Values(3, 'SUGAR MAN', 'Malik Bendjelloul', 2012)
insert into Filmy Values(4, 'Zielona Mila', 'Frank Darabont', 1999)
insert into Filmy Values(4, 'SKAZANI NA SHAWSHANK', 'Frank Darabont', 1994)
insert into Filmy Values(5, 'LŒNIENIE', 'Stanley Kubrick', 1980)
insert into Filmy Values(5, 'JESTEM LEGEND¥', 'Francis Lawrence', 2007)



insert into Aktorzy Values('Keanu', 'Reeves');
insert into Aktorzy Values('Laurence', 'fishburne');
insert into Aktorzy Values('Carrie-Anne', 'Moss');

insert into Aktorzy Values('Christian', 'Bale');
insert into Aktorzy Values('Heath', 'Ledger');
insert into Aktorzy Values('Aaron', 'Eckhart');

insert into Aktorzy Values('Mike', 'Myers');
insert into Aktorzy Values('Eddie', 'Murphy');
insert into Aktorzy Values('Cameron', 'Diaz');

insert into Aktorzy Values('Matthew', 'Broderick');
insert into Aktorzy Values('Moira', 'Kelly');
insert into Aktorzy Values('James', 'Jones');

insert into Aktorzy Values('Stephen', 'Segerman');
insert into Aktorzy Values('Craig', 'Strydom');
insert into Aktorzy Values('Dennis', 'Coffey');

insert into Aktorzy Values('Tom', 'Hanks');
insert into Aktorzy Values('David', 'Morse');
insert into Aktorzy Values('Bonnie', 'Hunt');

insert into Aktorzy Values('Tim', 'Robbins');
insert into Aktorzy Values('Morgan', 'Freeman');
insert into Aktorzy Values('Bob', 'Gunton');

insert into Aktorzy Values('Jack', 'Nicholson');
insert into Aktorzy Values('Shelley', 'Duvall');
insert into Aktorzy Values('Danny', 'Lloyd');

insert into Aktorzy Values('Will', 'Smith');
insert into Aktorzy Values('Alice', 'Braga');
insert into Aktorzy Values('Charlie', 'Tahan');

insert into FilmyAktorzy Values(1,1)
insert into FilmyAktorzy Values(1,2)
insert into FilmyAktorzy Values(1,3)

insert into FilmyAktorzy Values(2,4)
insert into FilmyAktorzy Values(2,5)
insert into FilmyAktorzy Values(2,6)

insert into FilmyAktorzy Values(3,7)
insert into FilmyAktorzy Values(3,8)
insert into FilmyAktorzy Values(3,9)

insert into FilmyAktorzy Values(4,10)
insert into FilmyAktorzy Values(4,11)
insert into FilmyAktorzy Values(4,12)

insert into FilmyAktorzy Values(5,13)
insert into FilmyAktorzy Values(5,14)
insert into FilmyAktorzy Values(5,15)

insert into FilmyAktorzy Values(6,16)
insert into FilmyAktorzy Values(6,17)
insert into FilmyAktorzy Values(6,18)

insert into FilmyAktorzy Values(7,19)
insert into FilmyAktorzy Values(7,20)
insert into FilmyAktorzy Values(7,21)

insert into FilmyAktorzy Values(8,22)
insert into FilmyAktorzy Values(8,23)
insert into FilmyAktorzy Values(8,24)

insert into FilmyAktorzy Values(9,25)
insert into FilmyAktorzy Values(9,26)
insert into FilmyAktorzy Values(9,27)

--Procedury

Create Procedure dodajWieluFilmAktor @film varchar(40), @a1 int =NULL, @a2 int =NULL, @a3 int =NULL, @a4 int =NULL, @a5 int =NULL, @a6 int =NULL, @a7 int =NULL, @a8 int =NULL, @a9 int =NULL, @a10 int =NULL
AS
BEGIN
	BEGIN TRY


	BEGIN TRANSACTION;

	if @film is not null
		BEGIN
			Declare @filmid int;
			set @filmid = (select filmID from Filmy where tytul = @film)
			if @a1 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a1)
				END
			if @a2 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a2)
				END
			if @a3 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a3)
				END
			if @a4 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a4)
				END
			if @a5 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a5)
				END
			if @a6 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a6)
				END
			if @a7 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a7)
				END
			if @a8 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a8)
				END
			if @a9 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a9)
				END
			if @a10 is not null
				BEGIN
					insert into FilmyAktorzy Values(@filmid, @a10)
				END
		END

		COMMIT TRANSACTION;
		END TRY

		
		BEGIN CATCH
			IF @@TRANCOUNT > 0
			BEGIN
				ROLLBACK  TRANSACTION
			END;
		END CATCH

END
--Trigery
Create Trigger T_FilmyAktorzy_II
ON FilmyAktorzy
INSTEAD OF INSERT
AS
	IF @@ROWCOUNT=0 RETURN
	Set nocount ON

	if not exists (select * from Filmy, inserted where Filmy.filmID = inserted.filmID)
		BEGIN
			print 'nie dodano wiersza. Film nie istnieje'
			Return
		END

	if not exists (select * from Aktorzy, inserted where Aktorzy.aktorID = inserted.aktorID)
		BEGIN
			print 'nie dodano wiersza. Aktor nie istnieje'
			Return
		END

	if not exists(select * from FilmyAktorzy, inserted where FilmyAktorzy.filmID = inserted.filmID AND FilmyAktorzy.aktorID = inserted.aktorID)
		BEGIN
			insert into FilmyAktorzy
			select * from inserted
		END
	else
		print 'Wiersz ju¿ istnieje' 
GO

Create Trigger T_KATEGORIE_II
ON Kategorie
INSTEAD OF INSERT
AS
	if not exists(select * from Kategorie, inserted where Kategorie.NazwaKategorii = inserted.NazwaKategorii)
		BEGIN
			insert into Kategorie
			select NazwaKategorii from inserted
		END
	else
		print 'Taka kategoria ju¿ istnieje'
GO


Create Trigger T_FILM_II
ON FILMY
INSTEAD OF INSERT
AS
	if not exists(select * from Kategorie, inserted where Kategorie.kategoriaID = inserted.kategoriaID)
		BEGIN
			print 'nie dodano filmu. Kategoria nie istnieje'
			return
		END
	if not exists(select * from Filmy, inserted where Filmy.tytul = inserted.tytul)
		BEGIN
			insert into FILMY
			Select kategoriaID, tytul, rezyser, RokProdukcji from inserted
		END
	else
		print 'Film o podanym tytule ju¿ istnieje'

GO

Create TRIGGER T_AKTORZY_II
ON Aktorzy
INSTEAD OF INSERT
AS
	if not exists(select * from Aktorzy, inserted where Aktorzy.imie = inserted.Imie AND Aktorzy.Nazwisko = inserted.Nazwisko)
		BEGIN
			insert into Aktorzy
			select Imie, Nazwisko from inserted
		END
	else
		print 'podany aktor ju¿ istnieje'
GO

CREATE TRIGGER T_KATEGORIE_ID
ON Kategorie
Instead of Delete
AS
	if exists(select * from Kategorie , deleted where Kategorie.kategoriaID = deleted.kategoriaID)
		BEGIN
			if not exists(select * from Filmy, deleted where Filmy.kategoriaID = deleted.kategoriaID)
				BEGIN
					delete from Kategorie from deleted where Kategorie.kategoriaID = deleted.kategoriaID
				END
		END
GO

Create Trigger T_Aktorzy_ID
ON AKTORZY
INSTEAD OF DELETE
AS

	if exists (select * from Aktorzy, deleted where Aktorzy.aktorID = deleted.aktorID)
		BEGIN
			if not exists(select * from FilmyAktorzy, deleted where FilmyAktorzy.aktorID = deleted.aktorID)
				BEGIN
					DELETE
					FROM Aktorzy
					From deleted
					where Aktorzy.aktorID = deleted.aktorID
				END
		END
GO

Create Trigger T_FILM_ID
On Filmy
Instead of Delete
AS
	if exists(select * from Filmy, deleted where Filmy.filmID = deleted.filmID)
		BEGIN
			if not exists(select * From FilmyAktorzy, deleted where FilmyAktorzy.filmID = deleted.filmID)
				Begin
				DELETE
				FROM Filmy
				from deleted
				where Filmy.filmID = deleted.filmID
				End
		END

GO


Create Trigger T_FILMYAKTORZY_ID
ON FilmyAktorzy
Instead of Delete
AS
	if exists(select * from FilmyAktorzy, deleted where FilmyAktorzy.filmID = deleted.filmID AND FilmyAktorzy.aktorID = deleted.aktorID)
		BEGIN
		DELETE FROM FilmyAktorzy
		From deleted
		where FilmyAktorzy.filmID = deleted.filmID 
		AND FilmyAktorzy.aktorID = deleted.aktorID

		END
GO

