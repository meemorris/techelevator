-- INSERT

-- 1. Add Klingon as a spoken language in the USA
INSERT INTO countrylanguage(countrycode, language, isofficial, percentage) --if nullable you don't have to have it
VALUES ('USA', 'Klingon', false, 5);

SELECT * --just to check it
FROM countrylanguage
WHERE countrycode = 'USA';

-- 2. Add Klingon as a spoken language in Great Britain (GBR)
INSERT INTO countrylanguage(countrycode, language, isofficial, percentage) 
VALUES ('GBR', 'Klingon', false, 5);

SELECT * --just to check it
FROM countrylanguage
WHERE countrycode = 'GBR';


-- UPDATE
-- UPDATE table_name
-- SET column = value
-- WHERE column = value

-- 1. Update the capital of the USA to Houston
SELECT id
FROM city
WHERE name = 'Houston';

UPDATE country
SET capital = 3796
--SELECT * FROM country
WHERE code = 'USA';

--checking further to see it displayed nicely
SELECT country.code, city.name
FROM country
JOIN city ON country.capital = city.id
WHERE code = 'USA';

--also can use subqueries to accomplish the same thing
UPDATE country
SET capital = (SELECT id FROM city WHERE name = 'Houston')
WHERE code = 'USA';


-- 2. Update the capital of the USA to Washington DC and the head of state
-- you can update two items at the same time just use a comma to separate
UPDATE country
SET capital = (SELECT id FROM city WHERE name = 'Washington'),
    headofstate = 'Elon Musk'
WHERE code= 'USA';

-- DELETE
-- DELETE FROM table_name
--WHERE column = value


-- 1. Delete English as a spoken language in the USA
DELETE 
--SELECT *
FROM countrylanguage
WHERE language = 'English' AND countrycode = 'USA';


-- 2. Delete all occurrences of the Klingon language 
DELETE
--SELECT *
FROM countrylanguage
WHERE language = 'Klingon';

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
INSERT INTO countrylanguage(language)
VALUES ('Elvish'); --null value in countrycode violates not-null constraint

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
INSERT INTO countrylanguage(countrycode, language, isofficial, percentage)
VALUES ('ZZZ', 'English', false, 5); --violates foreign key constraint (you can't insert a language into a country that doesn't exist)

-- 3. Try deleting the country USA. What happens?
DELETE FROM country
WHERE code = 'USA'; --not allowed to delete from country if that's going to cause another table to have a foreign key issure


-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA
INSERT INTO countrylanguage(language, isOfficial, percentage, countrycode)
VALUES ('English', false, 90, 'USA');

-- 2. Try again. What happens?
INSERT INTO countrylanguage(language, isOfficial, percentage, countrycode)
VALUES ('English', false, 90, 'USA'); --you can't duplicate a primary key

-- 3. Let's relocate the USA to the continent - 'Outer Space'
UPDATE country
SET continent = 'Outer Space'
WHERE code = 'USA'; --this constraint checks to make sure that the value is acceptable to put in

-- How to view all of the constraints

SELECT pg_constraint.*
FROM pg_catalog.pg_constraint
INNER JOIN pg_catalog.pg_class ON pg_class.oid = pg_constraint.conrelid
INNER JOIN pg_catalog.pg_namespace ON pg_namespace.oid = connamespace;


--GET ALL FOREIGN KEYS
select kcu.table_schema || '.' ||kcu.table_name as foreign_table,
'>-' as rel,
rel_tco.table_schema || '.' || rel_tco.table_name as primary_table,
string_agg(kcu.column_name, ', ') as fk_columns,
kcu.constraint_name
from information_schema.table_constraints tco
join information_schema.key_column_usage kcu
on tco.constraint_schema = kcu.constraint_schema
and tco.constraint_name = kcu.constraint_name
join information_schema.referential_constraints rco
on tco.constraint_schema = rco.constraint_schema
and tco.constraint_name = rco.constraint_name
join information_schema.table_constraints rel_tco
on rco.unique_constraint_schema = rel_tco.constraint_schema
and rco.unique_constraint_name = rel_tco.constraint_name
where tco.constraint_type = 'FOREIGN KEY'
group by kcu.table_schema,
kcu.table_name,
rel_tco.table_name,
rel_tco.table_schema,
kcu.constraint_name
order by kcu.table_schema,
kcu.table_name;


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
START TRANSACTION;
SELECT *
FROM countrylanguage;

DELETE 
FROM countrylanguage;

SELECT *
FROM countrylanguage;

ROLLBACK;
--or normally you can commmit


-- 2. Try updating all of the cities to be in the USA and roll it back

START TRANSACTION;

UPDATE city
SET countrycode = 'USA';

SELECT * FROM city;

ROLLBACK;

-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.

START TRANSACTION;

UPDATE countrylanguage
SET percentage = 60
WHERE language = 'English' AND countrycode = 'USA';
--started it haven't finished it
--now have the file open in a diff window/program updating the same set
--running the first one, it hasn't finished
--you can't execute the query in the other file while the transactio is open
--keep your transactions small and atomic



