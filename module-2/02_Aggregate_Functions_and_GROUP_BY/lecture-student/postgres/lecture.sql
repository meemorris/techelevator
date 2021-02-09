-- ORDERING RESULTS

-- Populations of all countries in descending order
SELECT name, population
FROM country
ORDER BY population DESC;

--Names of countries and continents in ascending order
SELECT name, continent
FROM country
ORDER BY name ASC; --order by name of country in ASC order

SELECT name, continent
FROM country
ORDER BY continent ASC, name DESC; --order by name of continent ASC and country in DESC order

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT name, lifeexpectancy
FROM country
WHERE lifeexpectancy IS NOT NULL --it has to go in this order, select, from, where, order by, limit
ORDER BY lifeexpectancy DESC 
LIMIT 10;

-- The name and average life expectancy of the countries with the 10 - 20 highest life expectancies.
SELECT name, lifeexpectancy
FROM country
WHERE lifeexpectancy IS NOT NULL --it has to go in this order, select, from, where, order by, limit
ORDER BY lifeexpectancy DESC 
LIMIT 10
OFFSET 10; -- gives you the next ten, start at row 11 for results. 


--what is the biggest city by population
SELECT name, population
FROM city
ORDER BY population DESC
LIMIT 1;




-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city

SELECT name||', '||district AS city_state --concatenating. Don't concatenate the output unless you absolutley have to
--substring(district, 3) you can show the first 3 letters only 
FROM city
WHERE district IN ('California', 'Oregon', 'Washington')
ORDER BY district, name; --default is asc. You can sort by the alias as well (ORDER BY city_state)

-- AGGREGATE FUNCTIONS - COUNT, SUM, AVG, MIN, MAX
-- Average Life Expectancy in the World
SELECT AVG(lifeexpectancy) AS avg_life_expectancy -- you can only select what the countries have in common
FROM country
WHERE lifeexpectancy IS NOT NULL;

-- Total population in Ohio
SELECT SUM(population) AS sum_pop_ohio
FROM city
WHERE district = 'Ohio';

-- The surface area of the smallest country in the world
SELECT surfacearea
FROM country
ORDER BY surfacearea ASC
LIMIT 1;

SELECT MIN(surfacearea) -- gives you the same result -- if you also want to know the name of the country, the function above might be better (for now, we're going to learn how to do this with group by)
FROM country;

-- The 10 largest countries in the world
SELECT name, surfacearea
FROM country
ORDER BY surfacearea DESC
LIMIT 10;

-- The number of countries who declared independence in 1991
SELECT COUNT(*) AS num_of_countries_declared_indep_1991
FROM country
WHERE indepyear = 1991;

-- GROUP BY
-- select, from, where(optional), group by, order by
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT language, COUNT(*) AS count_countries 
FROM countrylanguage
GROUP BY language -- when you have a group by you can also select what you have grouped by
ORDER BY count_countries DESC;


--without a group by, but then you'd have to count them yourself manually. Group by groups by that language and then counts how many rows we got in each summary
SELECT *
FROM countrylanguage
ORDER BY language;


-- Average life expectancy of each continent ordered from highest to lowest
SELECT continent, AVG(lifeexpectancy)
FROM country
GROUP BY continent
ORDER BY AVG(lifeexpectancy) DESC;

-- Exclude Antarctica from consideration for average life expectancy
SELECT continent, AVG(lifeexpectancy)
FROM country
WHERE lifeexpectancy IS NOT NULL
GROUP BY continent
ORDER BY AVG(lifeexpectancy) DESC;

-- Sum of the population of cities in each state in the USA ordered by state name
SElECT district AS state, SUM(population) AS sum_pop_cities
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district;

-- The average population of cities in each state in the USA ordered by state name
SELECT district AS state, AVG(population) AS avg_pop_cities
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district;

-- The average population rounded to two decimal places of cities in each state that has an average population greater than one hundred thousand in the USA ordered by state name
SELECT district AS state, round(AVG(population), 2) AS avg_pop_cities
FROM city
WHERE countrycode = 'USA'
GROUP BY district
HAVING AVG(population) > 100000
ORDER BY district;

--how many unique districts

SELECT COUNT(DISTINCT district)
FROM city
WHERE countrycode = 'USA';


-- SUBQUERIES
-- Find the names of cities under a given government leader
SELECT name, countrycode
FROM city
WHERE countrycode IN (

        SELECT code -- name, headofstate 
        FROM country
        WHERE headofstate LIKE '%Bush%'
        ); --instead of doing two steps, the subquery provides the result the first query is searching

-- Find the names of cities whose country they belong to has not declared independence yet
SELECT name, countrycode
FROM city
WHERE countrycode IN (
                SELECT code 
                FROM country 
                WHERE indepyear IS NULL); --this is used as input for the first query


-- Additional samples
-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- Limiting results allows rows to be returned in 'limited' clusters,where LIMIT says how many, and OFFSET (optional) specifies the number of rows to skip

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.


-- Counts the number of rows in the city table
SELECT COUNT(*) FROM city;

-- Also counts the number of rows in the city table
SELECT COUNT(name) FROM city;
-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.
SELECT SUM(population AS sum_pop, AVG(population) AS avg_pop, COUNT(*)
FROM city;

--Let's round this!
SELECT SUM(population) AS sum_pop, round(AVG(population) AS avg_pop,2), COUNT(*) AS total_rows
FROM city;


-- Gets the MIN population and the MAX population from the city table.
SELECT MIN(population) AS min_pop, MAX(population) AS max_pop
FROM city;

-- Gets the MIN population and the MAX population from the city table for each state
SELECT district AS state, MIN(population) AS min_pop, MAX(population) AS max_pop
FROM city
WHERE countrycode = 'USA'
GROUP BY district;

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
SELECT countrycode, MIN(population) AS min_pop, MAX(population) AS max_pop
FROM city
GROUP BY countrycode;
--min and max are diff values - diff city names