BEGIN TRANSACTION; --makes my commands all or nothing, if there is an error in my script, nothing is run


--CREATE DATABASE database_name

DROP DATABASE IF EXISTS artgallery; --doesn't give you an error, deletes it if it exists
CREATE DATABASE artgallery; --can run this command through here

--Create tables
/*
CREATE TABLE table_name
(
   column_name1 data_type(size),
   column_name2 data_type(size) NOT NULL --if not allowed to be null, can specify constraints as you're going
   CONSTRAINT pk_table_name PRIMARY KEY (column_name1) --adding a constraint that says the first column is the primary key
   CONSTRAINT fk_column2 FOREIGN KEY (column_name2) REFERENCES table_name2(columnD) --the name of a diff table, and the name of the column in that table
   --tables have to exist before you add a constraint to them
); --inside the parenthesis is where we want to add all of our columns
*/

--customers table that has a customer id, name, address, and phone, customer id is the pk
CREATE TABLE customers
(
  customerID SERIAL,
  name varchar(64) NOT NULL, --64 is the max size of characters
  address varchar (100) NOT NULL,
  phone_number varchar(11) NULL,
  
  CONSTRAINT pk_customers PRIMARY KEY(customerID)

);


-- TO DROP A TABLE
-- DROP TABLE table_name -- if added to the wrong table
-- safer to say DROP TABLE IF EXISTS table_name; --lookin wherever your database connection is

-- create a table to hold the artists - this has artistid, firstname, and lastname and id is the pk

CREATE TABLE artists --didn't run
(
  artist_id SERIAL,
  first_name varchar(30) NOT NULL,
  last_name varchar(30) NOT NULL,
  
  CONSTRAINT pk_artists_artist_id PRIMARY KEY(artist_id) --if you say its a primary key that makes it not able to be null
);

--create a table for the art that has the artcode_id, a title and the artist

CREATE TABLE art
(
   art_code_id SERIAL,
   title varchar(64) NOT NULL,
   artist_id int NOT NULL, --if artist_id is serial, my fk to it needs to be int. if the artist_id was a varchar, then this should be a varchar
   
   CONSTRAINT pk_art PRIMARY KEY (art_code_id),
   CONSTRAINT fk_artists_ref_artist_id FOREIGN KEY (artist_id) REFERENCES artists(artist_id) --column from art table goes after foreign key

);


/*
ALTER TABLE -- add primary keys and foreign keys later

ALTER TABLE table_name
ADD CONSTRAINT pk_constraint_name PRIMARY KEY (column);

ALTER TABLE table_name
ADD CONSTRAINT fk_constraint_name FOREIGN KEY (columnb) REFERENCES other_table_name(column_in_other_table);

ALTER TABLE table_name
ADD CONSTRAINT check_constraint_name CHECK (column = 'value' OR column_name IN (values)); 

i.e.ALTER TABLE table_name
ADD CONSTRAINT check_continents CHECK (continent IN ('North America', 'South America', 'Africa')); --this constraint is making sure it's ORs
--a continent can't be one and the other, and you only accept specific data as values

/*


