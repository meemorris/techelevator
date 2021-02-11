-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
SELECT *
FROM actor
WHERE first_name = 'Lisa' AND last_name = 'Byway' OR first_name = 'Hampton' AND last_name = 'Avenue';

INSERT INTO actor(first_name, last_name)
VALUES ('Hampton', 'Avenue');

INSERT INTO actor(first_name, last_name)
VALUES ('Lisa', 'Byway');


-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO film(title, description, release_year, language_id, rental_duration, rental_rate, length, replacement_cost, rating)
VALUES('EUCLIDEAN PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 6, 7.99, 198, 25.99, 'PG-13');

SELECT *
FROM film
WHERE title = 'EUCLIDEAN PI';


-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor(actor_id, film_id)
VALUES (209,1001);

INSERT INTO film_actor(actor_id, film_id)
VALUES (210,1001);

SELECT *
FROM film_actor
WHERE film_id = 1001;


-- 4. Add Mathmagical to the category table.

INSERT INTO category(name)
VALUES('Mathmagical');

SELECT *
FROM category
WHERE name = 'Mathmagical';

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

SELECT film_id FROM film WHERE film.title ILIKE 'Young Language';

INSERT INTO film_category(film_id, category_id) VALUES
        (1001, 17),
        (274, 17),
        (494, 17),
        (714, 17),
        (996, 17);

SELECT *
FROM film_category
WHERE category_id = 17;


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film
SET rating = 'G'
FROM film_category
WHERE film_category.film_id = film.film_id AND film_category.category_id = 17; 

SELECT *
FROM film
JOIN film_category ON film_category.film_id = film.film_id
WHERE film_category.category_id = 17;

-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory(film_id, store_id) VALUES
        (1001, 1),
        (1001, 2);
        
SELECT *
FROM inventory
WHERE film_id = 1001;

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

DELETE FROM film
WHERE title = 'EUCLIDEAN PI';

--It did not succeed because this would violate the foreign key constraint - that helps us ensure our data is consisent throughout all of our tables
--This film is still referenced from table film_actor.

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

DELETE FROM category
WHERE name = 'Mathmagical';

--This did not succeed for the same reason as above! This category id 17 is still referenced from the table film_category

-- 10. Delete all links to Mathmagical in the film_category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE FROM film_category
WHERE category_id = 17;

--This succeeded because it was the end of the line, there are no tables that draw that info directly from film_category, the info is being drawn from the film table

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>

--Deleting Mathmagical from the category table was successful. This could now be deleted because film_category no longer references it as a foreign key.
--Euclidean PI - deleting that from film table was NOT successful. Not sucessful because there are still other tables that reference this as a foreign key.

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--Constraints of film_id:
--1) film_actor_film_id_fkey
--2) film_category_film_id_fkey
--3) inventory_film_id_fkey

--Euclidean PI can be removed from the database AFTER the following takes place:
        --1) All tables with foreign keys referencing this primary key have that foreign key deleted
                --film_id is currently still on: film_actor, category_film, and inventory tables.
                -- After deleting those foreign keys on tables mentioned above, then Euclidean PI can be removed from the film table



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

