USE [Movie_Database]
GO

/****** Object:  Table [dbo].[movies]    Script Date: 3/21/2023 11:36:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[movies](
	[id] [int] NOT NULL,
	[title] [varchar](255) NOT NULL,
	[director] [varchar](255) NOT NULL,
	[year_of_release] [int] NOT NULL,
	[genre] [varchar](255) NOT NULL,
	[summary] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];

INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (1, 'The Godfather', 'Francis Ford Coppola', '1972', 'Crime, Drama', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son. However, a series of events ensue that threaten to destroy the Corleone family and their grip on the underworld.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (2, 'The Shawshank Redemption', 'Frank Darabont', '1994', 'Drama', 'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (3, 'The Dark Knight', 'Christopher Nolan', '2008', 'Action, Crime, Drama', 'When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (4, 'Pulp Fiction', 'Quentin Tarantino', '1994', 'Crime, Drama', 'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (5, 'The Lord of the Rings: The Fellowship of the Ring', 'Peter Jackson', '2001', 'Adventure, Drama, Fantasy', 'A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (6, 'Forrest Gump', 'Robert Zemeckis', '1994', 'Drama, Romance', 'The presidencies of Kennedy and Johnson, the Vietnam War, and the Watergate scandal are seen through the eyes of a simple-minded but kind-hearted and athletically-talented man.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (7, 'Fight Club', 'David Fincher', '1999', 'Drama', 'An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (8, 'Star Wars: Episode IV - A New Hope', 'George Lucas', '1977', 'Action, Adventure, Fantasy', 'Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empires world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (9, 'Inception', 'Christopher Nolan', '2010', 'Action, Adventure, Sci-Fi', 'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (10, 'The Matrix', 'Lana Wachowski, Lilly Wachowski', '1999', 'Action, Sci-Fi', 'A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (11, 'The Silence of the Lambs', 'Jonathan Demme', '1991', 'Crime, Drama, Thriller', 'A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (12, 'The Departed', 'Martin Scorsese', '2006', 'Crime, Drama, Thriller', 'An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (13, 'The Social Network', 'David Fincher', '2010', 'Biography, Drama', 'Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, but is later sued by two brothers who claimed he stole their idea, and the co-founder who was later squeezed out of the business.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (14, 'Interstellar', 'Christopher Nolan', '2014', 'Adventure, Drama, Sci-Fi', 'A team of explorers travel through a wormhole in space in an attempt to ensure humanitys survival.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (15, 'The Lion King', 'Roger Allers, Rob Minkoff', '1994', 'Animation, Adventure, Drama', 'Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (16, 'Jurassic Park', 'Steven Spielberg', '1993', 'Adventure, Sci-Fi, Thriller', 'A pragmatic paleontologist visiting an almost complete theme park is tasked with protecting a couple of kids after a power failure causes the parks cloned dinosaurs to run loose.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (17, 'The Exorcist', 'William Friedkin', '1973', 'Horror', 'When a teenage girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her daughter.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (18, 'Gone with the Wind', 'Victor Fleming', '1939', 'Drama, History, Romance', 'A manipulative woman and a roguish man conduct a turbulent romance during the American Civil War and Reconstruction periods.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (19, 'The Godfather: Part II', 'Francis Ford Coppola', '1974', 'Crime, Drama', 'The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.');
INSERT INTO movies (id, title, director, year_of_release, genre, summary)
VALUES (20, 'The Green Mile', 'Frank Darabont', '1999', 'Crime, Drama, Fantasy', 'The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.');
