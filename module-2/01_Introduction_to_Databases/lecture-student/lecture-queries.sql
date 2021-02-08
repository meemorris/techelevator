-- SELECT ... FROM
-- Selecting the names for all countries
SELECT name 
FROM country;

-- Selecting the name and population of all countries
SELECT name, population
FROM country;
-- Selecting all columns from the city table
SELECT *
FROM city;

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
SELECT name, district
FROM city
WHERE district = 'Ohio';

SELECT name, district
FROM city
WHERE district ILIKE 'OHIO'; --case insensitive search, will return the same search as 15 - 17. Similar to Java contains()

--all the cities in a district that starts with O
SELECT name, district
FROM city
WHERE district LIKE 'O%'; --case sensitive starts with a capital O

--all the cities in a district that contains an X
SELECT name, district
FROM city
WHERE district LIKE '%x%' --Case sensitive contains the letter x, any number of x

--all the cities in a district that contains an X
SELECT name, district
FROM city
WHERE district LIKE '%_x%' --Case sensitive contains the letter x, but only one x

-- Selecting countries that gained independence in the year 1776
SELECT name, indepyear
FROM country
WHERE indepyear = 1776; --indepyear is an integer, not a string. Can use other comparisons <=, != etc

-- Selecting countries that gained independence in the year 1776 OR the year 1901
SELECT name, indepyear
FROM country
WHERE indepyear = 1776 OR indepyear = 1901;

SELECT name, indepyear
FROM country
WHERE indepyear IN (1776, 1901); --functionally equivalent with 44-46. Can also say NOT IN

-- Selecting countries that gained independence between 1776 and 1901
SELECT name, indepyear
FROM country
WHERE indepyear BETWEEN 1776 AND 1901; --between and AND are keywords that have to go together. This is an inclusive searh. Exclusive you have to spell out greater than and less than.


-- Selecting countries not in Asia
SELECT name, continent
FROM country
WHERE continent != 'Asia';


-- Selecting countries that do not have an independence year
SELECT name, indepyear
FROM country
WHERE indepyear IS NULL;

-- Selecting countries that DO have an independence year
SELECT name, indepyear
FROM country
WHERE indepyear IS NOT NULL;

-- Selecting countries that have a population greater than 5 million
SELECT name, population
FROM country
WHERE population > 5000000;


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
SELECT name, district, population
FROM city
WHERE district = 'Ohio' AND population > 400000;

-- Selecting country names on the continent North America or South America
SELECT name, continent
FROM country
WHERE continent = 'North America' OR continent = 'South America';

--IN
SELECT name, continent
FROM country
WHERE continent IN ('North America', 'South America');

--LIKE

SELECT name, continent
FROM country
WHERE continent ILIKE '%america'; --(case insensitive) or LIKE '%America%'; (case sensitive)

-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword

SELECT name, population, lifeexpectancy, surfacearea, population/surfacearea AS pop_per_area
FROM country;

--how many different districts are in my stuff
SELECT DISTINCT district --only gives you unique values and removes the duplicates
FROM city;

