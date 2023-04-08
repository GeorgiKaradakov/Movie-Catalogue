CREATE TABLE actors_info (
  id INT PRIMARY KEY,
  name VARCHAR(255),
  birthdate DATE,
  nationality VARCHAR(50),
  bio TEXT,
  CONSTRAINT fk_actor_id
    FOREIGN KEY (id)
    REFERENCES actors(id)
);

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (1, 'Tom Hanks', '1956-07-09', 'American', 'Tom Hanks is an American actor and filmmaker who has had a long and successful career in Hollywood. He is known for his roles in movies such as Forrest Gump, Cast Away, and Saving Private Ryan, among many others.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (2, 'Robin Wright', '1966-04-08', 'American', 'Robin Wright is an American actress and director. She is best known for her roles in the TV series House of Cards and the movie Forrest Gump.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (3, 'Gary Sinise', '1955-03-17', 'American', 'Gary Sinise is an American actor and director. He is best known for his role as Lieutenant Dan in the movie Forrest Gump, as well as for his work on the TV series CSI: NY.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (4, 'Marlon Brando', '1924-04-03', 'American', 'Marlon Brando was an American actor and director who is widely considered to be one of the greatest actors of all time. He is known for his roles in movies such as The Godfather, A Streetcar Named Desire, and On the Waterfront.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (5, 'Al Pacino', '1940-04-25', 'American', 'Al Pacino is an American actor and filmmaker who has had a long and successful career in Hollywood. He is known for his roles in movies such as The Godfather, Scarface, and Scent of a Woman, among many others.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (6, 'James Caan', '1940-03-26', 'American', 'James Caan is an American actor who is best known for his roles in movies such as The Godfather, Misery, and Elf.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (7, 'Tim Robbins', '1958-10-16', 'American', 'Tim Robbins is an American actor, director, and screenwriter. He is best known for his roles in movies such as The Shawshank Redemption, Mystic River, and Top Gun.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (8, 'Morgan Freeman', '1937-06-01', 'American', 'Morgan Freeman is an American actor, director, and narrator who has had a long and successful career in Hollywood. He is known for his roles in movies such as The Shawshank Redemption, Million Dollar Baby, and Driving Miss Daisy, among many others.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (9, 'Bob Gunton', '1945-11-15', 'American', 'Bob Gunton is an American actor who is best known for his role as Warden Norton in the movie The Shawshank Redemption.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (10, 'Christian Bale', '1974-01-30', 'British', 'Christian Bale is a British actor who has had a successful career in Hollywood.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (11, 'Heath Ledger', '1979-04-04', 'Australian', 'Heath Ledger was an Australian actor and director best known for his portrayal of the Joker in "The Dark Knight" (2008).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (12, 'Aaron Eckhart', '1968-03-12', 'American', 'Aaron Eckhart is an American actor known for his roles in "The Dark Knight" (2008), "Sully" (2016), and "Olympus Has Fallen" (2013).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (13, 'John Travolta', '1954-02-18', 'American', 'John Travolta is an American actor and singer known for his roles in "Saturday Night Fever" (1977), "Grease" (1978), and "Pulp Fiction" (1994).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (14, 'Samuel L. Jackson', '1948-12-21', 'American', 'Samuel L. Jackson is an American actor and producer known for his roles in "Pulp Fiction" (1994), "The Avengers" (2012), and "Django Unchained" (2012).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (15, 'Uma Thurman', '1970-04-29', 'American', 'Uma Thurman is an American actress and model known for her roles in "Pulp Fiction" (1994), "Kill Bill" (2003), and "Gattaca" (1997).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (16, 'Elijah Wood', '1981-01-28', 'American', 'Elijah Wood is an American actor and producer known for his role as Frodo Baggins in "The Lord of the Rings" trilogy (2001-2003).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (17, 'Ian McKellen', '1939-05-25', 'British', 'Ian McKellen is a British actor known for his roles in "The Lord of the Rings" trilogy (2001-2003), "X-Men" (2000-2014), and "The Hobbit" trilogy (2012-2014). Best known with his phrase "You shaw not PASSS!".');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (18, 'Viggo Mortensen', '1958-10-20', 'American', 'Viggo Mortensen is a Danish-American actor known for his roles in "The Lord of the Rings" trilogy (2001-2003), "Eastern Promises" (2007), and "Green Book" (2018).');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES 
(19, 'Brad Pitt', 'December 18, 1963', 'American', 'William Bradley Pitt is an American actor and film producer. He has received multiple awards, including two Golden Globe Awards and an Academy Award for his acting, in addition to another Academy Award and a Primetime Emmy Award as producer under his production company, Plan B Entertainment.'),

(20, 'Edward Norton', 'August 18, 1969', 'American', 'Edward Harrison Norton is an American actor and filmmaker. He has received numerous awards and nominations, including a Golden Globe Award and three Academy Award nominations.'),

(21, 'Helena Bonham Carter', 'May 26, 1966', 'British', 'Helena Bonham Carter is an English actress. Known for her roles in both low-budget independent art films and large-scale blockbusters, she has received nominations for two Academy Awards, five BAFTA Awards, and five Screen Actors Guild Awards.'),

(22, 'Mark Hamill', 'September 25, 1951', 'American', 'Mark Richard Hamill is an American actor, voice actor, and writer. He is best known for playing Luke Skywalker in the original Star Wars trilogy, a role for which he received widespread acclaim.'),

(23, 'Harrison Ford', 'July 13, 1942', 'American', 'Harrison Ford is an American actor. He gained worldwide fame for his starring roles as Han Solo in the Star Wars film series and as the title character of the Indiana Jones film series. Ford is also known for his roles in Blade Runner, Witness, The Fugitive, and many other successful films.'),

(24, 'Carrie Fisher', 'October 21, 1956', 'American', 'Carrie Fisher was an American actress, writer, and comedian. She is best known for playing Princess Leia in the Star Wars films, a role for which she was nominated for four Saturn Awards. Fisher was also an accomplished writer, publishing several novels and memoirs.'),

(25, 'Leonardo DiCaprio', 'November 11, 1974', 'American', 'Leonardo Wilhelm DiCaprio is an American actor, film producer, and environmentalist. He has been nominated for numerous awards, including seven Academy Awards, winning one for his role in The Revenant, and six BAFTA Awards, winning three. DiCaprio has also been named to Time magazine list of the 100 most influential people in the world multiple times.'),

(26, 'Joseph Gordon-Levitt', 'February 17, 1981', 'American', 'Joseph Leonard Gordon-Levitt is an American actor, filmmaker, singer, and entrepreneur. He has received several awards for his acting, including a Primetime Emmy Award, and has also directed and produced films. Gordon-Levitt is also the founder of the online production company hitRECord.'),

(27, 'Ellen Page', 'February 21, 1987', 'Canadian', 'Ellen Page is a Canadian actress and producer. She is best known for her role as the title character in the film Juno, for which she received numerous nominations, including an Academy Award nomination for Best Actress.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES
  (28, 'Keanu Reeves', 'September 2, 1964', 'Canadian', 'Keanu Reeves is a Canadian actor, director, producer, and musician. He gained fame for his starring role performances in several blockbuster films, including comedies from the Bill and Ted franchise (1989–2020), action thrillers Point Break (1991), Speed (1994), and the John Wick franchise (2014–present).'),
  (29, 'Carrie-Anne Moss', 'August 21, 1967', 'Canadian', 'Carrie-Anne Moss is a Canadian actress. Following early roles in television, she rose to international prominence for her role of Trinity in The Matrix trilogy (1999–2003).'),
  (30, 'Laurence Fishburne', 'July 30, 1961', 'American', 'Laurence Fishburne is an American actor, playwright, producer, screenwriter, and film director. He is known for playing Morpheus in The Matrix trilogy (1999–2003), Jason "Furious" Styles in the drama film Boyz n the Hood (1991), Tyrone "Mr. Clean" Miller in the war film Apocalypse Now (1979), and Cowboy Curtis on the television show Pee-wee''s Playhouse (1986–1990).');
INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES
  (31, 'Jodie Foster', 'November 19, 1962', 'American', 'Jodie Foster is an American actress, director, and producer. She has received two Academy Awards, three British Academy Film Awards, two Golden Globe Awards, and the Cecil B. DeMille Award. She began her career as a child actress and starred in films such as Taxi Driver (1976) and The Silence of the Lambs (1991).'),
  (32, 'Anthony Hopkins', 'December 31, 1937', 'Welsh', 'Anthony Hopkins is a Welsh actor, director, and producer. He is best known for his portrayal of Hannibal Lecter in The Silence of the Lambs (1991), for which he won the Academy Award for Best Actor. He has also appeared in films such as The Elephant Man (1980), Legends of the Fall (1994), and Thor (2011).'),
  (33, 'Ted Levine', 'May 29, 1957', 'American', 'Ted Levine is an American actor. He is best known for his role as Buffalo Bill in the thriller film The Silence of the Lambs (1991). He has also appeared in films such as Heat (1995), Wild Wild West (1999), and American Gangster (2007).');
INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES
  (34, 'Leonardo DiCaprio', 'November 11, 1974', 'American', 'Leonardo DiCaprio is an American actor, film producer, and environmental activist. He has won numerous awards, including an Academy Award for Best Actor for his role in The Revenant (2015). He has also appeared in films such as Titanic (1997), The Departed (2006), and The Wolf of Wall Street (2013).'),
  (35, 'Matt Damon', 'October 8, 1970', 'American', 'Matt Damon is an American actor, film producer, and screenwriter. He is best known for his roles in films such as Good Will Hunting (1997), The Bourne Identity (2002), and The Martian (2015). He has received several awards, including an Academy Award for Best Original Screenplay for Good Will Hunting.'),
  (36, 'Jack Nicholson', 'April 22, 1937', 'American', 'Jack Nicholson is an American actor and filmmaker. He is known for his roles in films such as One Flew Over the Cuckoo Nest (1975), Batman (1989), and As Good as It Gets (1997). He has received several awards, including three Academy Awards, and is one of the most nominated male actors in the history of the Academy Awards.'),
  (37, 'Jesse Eisenberg', 'October 5, 1983', 'American', 'Jesse Eisenberg is an American actor, author, and playwright. He is best known for his role as Mark Zuckerberg in The Social Network (2010), for which he received an Academy Award nomination for Best Actor. He has also appeared in films such as Zombieland (2009), Now You See Me (2013), and Batman v Superman: Dawn of Justice (2016).'),
  (38, 'Andrew Garfield', 'August 20, 1983', 'American-British', 'Andrew Garfield is an American-British actor. He is best known for his roles in films such as The Social Network (2010), The Amazing Spider-Man (2012), and Hacksaw Ridge (2016). He has received several awards, including a Tony Award for Best Actor in a Play for his role in Angels in America.'),
  (39, 'Armie Hammer', 'August 28, 1986', 'American', 'Armie Hammer is an American actor. He is best known for his roles in films such as The Social Network (2010), Call Me by Your Name (2017), and On the Basis of Sex (2018). He has received several awards, including a Golden Globe nomination for Best Supporting Actor for his role in Call Me by Your Name.');
INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (40, 'Matthew McConaughey', 'November 4, 1969', 'American', 'Matthew McConaughey is an American actor known for his roles in films such as Dazed and Confused, Dallas Buyers Club, and Interstellar.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (41, 'Anne Hathaway', 'November 12, 1982', 'American', 'Anne Hathaway is an American actress known for her roles in films such as The Devil Wears Prada, Les Misérables, and The Dark Knight Rises.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (42, 'Jessica Chastain', 'March 24, 1977', 'American', 'Jessica Chastain is an American actress known for her roles in films such as Zero Dark Thirty, The Help, and Interstellar.');
INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (43, 'Sam Neill', 'September 14, 1947', 'New Zealand', 'Sam Neill is a New Zealand actor known for his roles in films such as Jurassic Park, The Piano, and Hunt for the Wilderpeople.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (44, 'Laura Dern', 'February 10, 1967', 'American', 'Laura Dern is an American actress known for her roles in films such as Jurassic Park, Wild, and Marriage Story.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (45, 'Jeff Goldblum', 'October 22, 1952', 'American', 'Jeff Goldblum is an American actor known for his roles in films such as Jurassic Park, The Grand Budapest Hotel, and Thor: Ragnarok.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (46, 'Ellen Burstyn', 'December 7, 1932', 'American', 'Ellen Burstyn is an American actress known for her roles in films such as The Exorcist, Alice Doesnt Live Here Anymore, and Requiem for a Dream.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (47, 'Max von Sydow', 'April 10, 1929', 'Swedish', 'Max von Sydow was a Swedish actor known for his roles in films such as The Seventh Seal, The Exorcist, and Star Wars: The Force Awakens.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (48, 'Jason Miller', 'April 22, 1939', 'American', 'Jason Miller was an American actor known for his role in the film The Exorcist.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (49, 'Vivien Leigh', 'November 5, 1913', 'British', 'Vivien Leigh was a British actress known for her roles in films such as Gone with the Wind and A Streetcar Named Desire.');

INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES (50, 'Clark Gable', 'February 1, 1901', 'American', 'Clark Gable was an American actor known for his roles in films such as Gone with the Wind, It Happened One Night, and The Misfits.');
INSERT INTO actors_info (id, name, birthdate, nationality, bio)
VALUES 
    (51, 'Olivia de Havilland', 'July 1, 1916', 'British-American', 'Olivia de Havilland was a British-American actress. She is best known for her roles in films such as "Gone with the Wind" and "The Adventures of Robin Hood".'),
    (52, 'Tom Hanks', 'July 9, 1956', 'American', 'Tom Hanks is an American actor and filmmaker. He is one of the most famous and successful actors of his generation, with a career spanning over four decades.'),
    (53, 'Michael Clarke Duncan', 'December 10, 1957', 'American', 'Michael Clarke Duncan was an American actor, best known for his role as John Coffey in the film "The Green Mile". He was also known for his deep voice and imposing stature.'),
    (54, 'David Morse', 'October 11, 1953', 'American', 'David Morse is an American actor, singer, director, and writer. He is known for his roles in films such as "The Green Mile" and "The Hurt Locker", as well as his work in television.'),
    (55, 'Matthew Broderick', 'March 21, 1962', 'American', 'Matthew Broderick is an American actor and singer. He is best known for his roles in films such as "Ferris Bueller''s Day Off" and "Glory".'),
    (56, 'Jeremy Irons', 'September 19, 1948', 'British', 'Jeremy Irons is a British actor. He is best known for his roles in films such as "The Lion King" and "Die Hard with a Vengeance".'),
    (57, 'James Earl Jones', 'January 17, 1931', 'American', 'James Earl Jones is an American actor. He is best known for his roles in films such as "Star Wars" and "The Lion King", as well as his distinctive deep voice.');
