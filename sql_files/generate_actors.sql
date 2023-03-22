USE [Movie_Database]
GO

/****** Object:  Table [dbo].[actors]    Script Date: 3/21/2023 11:35:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[actors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[place_of_birth] [varchar](100) NOT NULL,
	[movie_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[actors]  WITH CHECK ADD FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id]);

INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Tom', 'Hanks', '1956-07-09', 'Concord, California, USA', 6);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Robin', 'Wright', '1966-04-08', 'Dallas, Texas, USA', 6);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Gary', 'Sinise', '1955-03-17', 'Blue Island, Illinois, USA', 6);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Marlon', 'Brando', '1924-04-03', 'Omaha, Nebraska, USA', 1);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Al', 'Pacino', '1940-04-25', 'New York City, New York, USA', 1);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('James', 'Caan', '1940-03-26', 'The Bronx, New York, USA', 1);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Tim', 'Robbins', '1958-10-16', 'West Covina, California, USA', 2);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Morgan', 'Freeman', '1937-06-01', 'Memphis, Tennessee, USA', 2);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Bob', 'Gunton', '1945-11-15', 'Santa Monica, California, USA', 2);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Christian', 'Bale', '1974-01-30', 'Haverfordwest, Pembrokeshire, Wales, UK', 3);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Heath', 'Ledger', '1979-04-04', 'Perth, Western Australia, Australia', 3);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Aaron', 'Eckhart', '1968-03-12', 'Cupertino, California, USA', 3);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('John', 'Travolta', '1954-02-18', 'Englewood, New Jersey, USA', 4);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Samuel L.', 'Jackson', '1948-12-21', 'Washington, D.C., USA', 4);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Uma', 'Thurman', '1970-04-29', 'Boston, Massachusetts, USA', 4);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Elijah', 'Wood', '1981-01-28', 'Cedar Rapids, Iowa, USA', 5);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Ian', 'McKellen', '1939-05-25', 'Burnley, Lancashire, England, UK', 5);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Viggo', 'Mortensen', '1958-10-20', 'Manhattan, New York City, New York, USA', 5);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Brad', 'Pitt', '1963-12-18', 'Shawnee, Oklahoma, USA', 7);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Edward', 'Norton', '1969-08-18', 'Boston, Massachusetts, USA', 7);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Helena', 'Bonham Carter', '1966-05-26', 'Golders Green, London, England, UK', 7);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Mark', 'Hamill', '1951-09-25', 'Concord, California, USA', 8);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Harrison', 'Ford', '1942-07-13', 'Chicago, Illinois, USA', 8);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Carrie', 'Fisher', '1956-10-21', 'Beverly Hills, California, USA', 8);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Leonardo', 'DiCaprio', '1974-11-11', 'Los Angeles, California, USA', 9);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Joseph', 'Gordon-Levitt', '1981-02-17', 'Los Angeles, California, USA', 9);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Ellen', 'Page', '1987-02-21', 'Halifax, Nova Scotia, Canada', 9);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Keanu', 'Reeves', '1964-09-02', 'Beirut, Lebanon', 10);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Carrie-Anne', 'Moss', '1967-08-21', 'Vancouver, British Columbia, Canada', 10);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Laurence', 'Fishburne', '1961-07-30', 'Augusta, Georgia, USA', 10);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jodie', 'Foster', '1962-11-19', 'Los Angeles, California, USA', 11);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Anthony', 'Hopkins', '1937-12-31', 'Port Talbot, West Glamorgan, Wales, UK', 11);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Ted', 'Levine', '1957-05-29', 'Bellaire, Ohio, USA', 11);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Leonardo', 'DiCaprio', '1974-11-11', 'Los Angeles, California, USA', 12);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Matt', 'Damon', '1970-10-08', 'Boston, Massachusetts, USA', 12);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jack', 'Nicholson', '1937-04-22', 'Neptune City, New Jersey, USA', 12);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jesse', 'Eisenberg', '1983-10-05', 'Queens, New York City, New York, USA', 13);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Andrew', 'Garfield', '1983-08-20', 'Los Angeles, California, USA', 13);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Armie', 'Hammer', '1986-08-28', 'Los Angeles, California, USA', 13);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Matthew', 'McConaughey', '1969-11-04', 'Uvalde, Texas, USA', 14);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Anne', 'Hathaway', '1982-11-12', 'Brooklyn, New York City, New York, USA', 14);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jessica', 'Chastain', '1977-03-24', 'Sacramento, California, USA', 14);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Sam', 'Neill', '1947-09-14', 'Omagh, County Tyrone, Northern Ireland, UK', 16);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Laura', 'Dern', '1967-02-10', 'Los Angeles, California, USA', 16);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jeff', 'Goldblum', '1952-10-22', 'Pittsburgh, Pennsylvania, USA', 16);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Ellen', 'Burstyn', '1932-12-07', 'Detroit, Michigan, USA', 17);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Max', 'von Sydow', '1929-04-10', 'Lund, Skane lan, Sweden', 17);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jason', 'Miller', '1939-04-22', 'Long Island City, Queens, New York City, New York, USA', 17);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Vivien', 'Leigh', '1913-11-05', 'Darjeeling, India', 18);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Clark', 'Gable', '1901-02-01', 'Cadiz, Ohio, USA', 18);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Olivia', 'de Havilland', '1916-07-01', 'Tokyo, Japan', 18);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Tom', 'Hanks', '1956-07-09', 'Concord, California, USA', 20);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Michael', 'Clarke Duncan', '1957-12-10', 'Chicago, Illinois, USA', 20);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('David', 'Morse', '1953-10-11', 'Beverly, Massachusetts, USA', 20);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Matthew', 'Broderick', '1962-03-21', 'New York City, New York, USA', 15);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('Jeremy', 'Irons', '1948-09-19', 'Cowes, Isle of Wight, England, UK', 15);
INSERT INTO actors(first_name, last_name, date_of_birth, place_of_birth, movie_id)
VALUES('James', 'Earl Jones', '1931-01-17', 'Arkabutla, Mississippi, USA', 15);
