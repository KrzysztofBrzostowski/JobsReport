create database ReportDb

create table dbo.Jobs
(
	ID int primary key IDENTITY (1,1) NOT NULL,
	NazwaPrac nvarchar(200) NOT NULL,
	DataIGodzina datetime NOT NULL,
	NazwaUzytkownika nvarchar(100) NOT NULL,
	NazwaLokalu nvarchar(100) NOT NULL
)

insert into dbo.Jobs values
	('Kodowanie', getdate(), 'Krzysztof', 'home'),
	('Gotowanie', getdate(), 'Jan', 'office'),
	('Testowanie', getdate(), 'Anna', 'dom'),
	('Kodowanie', getdate(), 'Jan', 'office'),
	('Testowanie', getdate(), 'Krzysztof', 'home')



