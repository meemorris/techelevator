-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT initcap(actor.first_name||' '||actor.last_name) AS actor_name, initcap(film.title) AS movie_title
FROM film_actor
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
WHERE actor.first_name ILIKE 'nick' AND actor.last_name ILIKE 'stallone';

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT initcap(actor.first_name||' '||actor.last_name) AS actor_name, initcap(film.title) AS movie_title
FROM film_actor
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
WHERE actor.first_name ILIKE 'rita' AND actor.last_name ILIKE 'reynolds';

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)

SELECT initcap(actor.first_name||' '||actor.last_name) AS actor_name, initcap(film.title) AS movie_title
FROM film_actor
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
WHERE actor.first_name ILIKE 'judy' OR actor.first_name ILIKE 'river' AND actor.last_name ILIKE 'dean';

-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT category.name AS genre, initcap(film.title) As movie_title
FROM film_category
JOIN category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.film_id
WHERE category.name = 'Documentary';

-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT category.name AS genre, initcap(film.title) As movie_title
FROM film_category
JOIN category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.film_id
WHERE category.name = 'Comedy';

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT category.name AS genre, initcap(film.title) As movie_title
FROM film_category
JOIN category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.film_id
WHERE category.name = 'Children' AND film.rating = 'G';

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)

SELECT category.name AS genre, initcap(film.title) As movie_title
FROM film_category
JOIN category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.film_id
WHERE category.name = 'Family' AND film.rating = 'G' AND film.length < 120;


-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT initcap(actor.first_name||' '||actor.last_name) AS actor_name, initcap(film.title) AS movie_title, film.rating AS rating
FROM film_actor
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
WHERE actor.first_name ILIKE 'matthew' AND actor.last_name ILIKE 'leigh' AND film.rating = 'G';

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT category.name AS genre, initcap(film.title), film.release_year
FROM film_category
JOIN category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.category_id
WHERE film.release_year = 2006 AND category.name = 'Sci-Fi';

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT category.name AS genre, initcap(film.title) AS movie, initcap(actor.first_name||' '||actor.last_name) AS lead_actor_name
FROM film_category
JOIN category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.film_id
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE category.name = 'Action' AND actor.first_name ILIKE 'nick' AND actor.last_name ILIKE 'stallone';

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT store.store_id, address.address||' '||address.address2 AS street_address, city.city, address.district AS state, country.country
FROM store
JOIN address ON address.address_id = store.address_id
JOIN city ON city.city_id = address.city_id
JOIN country ON country.country_id = city.country_id;


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT store.store_id, address.address||' '||address.address2 AS street_address, staff.first_name||' '||staff.last_name AS manager_name
FROM store
JOIN address ON address.address_id = store.address_id
JOIN staff ON staff.store_id = store.store_id
WHERE store.manager_staff_id = staff.staff_id;


-- 13. The first and last name of the top ten customers ranked by number of rentals
-- (#1 should be “ELEANOR HUNT�? with 46 rentals, #10 should have 39 rentals)

SELECT initcap(customer.first_name||' '||customer.last_name) AS customer_name, COUNT(*) AS num_of_rentals
FROM customer
JOIN rental ON rental.customer_id = customer.customer_id
GROUP BY customer_name
ORDER BY num_of_rentals DESC
LIMIT 10;

-- 14. The first and last name of the top ten customers ranked by dollars spent
-- (#1 should be “KARL SEAL�? with 221.55 spent, #10 should be “ANA BRADLEY�? with 174.66 spent)

SELECT initcap(customer.first_name||' '||customer.last_name) AS customer_name, SUM(payment.amount) AS dollars_spent
FROM customer
JOIN payment ON payment.customer_id = customer.customer_id
GROUP BY customer_name
ORDER BY dollars_spent DESC
LIMIT 10;


-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that while a customer has only one primary store, they may rent from either store.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

--customer - rental - inventory - store (customer store id - they can rent from any store, that's just where they got their id
--you need to go through inventory, one inventory has one store, it can't belong to multiple stores

SELECT store.store_id, address.address||' '||address.address2 AS street_address, COUNT(*) AS total_num_rentals, SUM(payment.amount) AS total_amount_of_sales, round(AVG(payment.amount),2) AS average_sale
FROM store
JOIN address ON address.address_id = store.address_id
JOIN inventory ON store.store_id = inventory.store_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
JOIN payment ON payment.rental_id = rental.rental_id
GROUP BY store.store_id, street_address


-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD�? with 34 rentals and #10 should have 31 rentals)
SELECT film.title AS movie, COUNT(*) AS num_of_rentals
FROM film
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY film.title
ORDER BY num_of_rentals DESC
LIMIT 10;

-- 17. The top five film categories by number of rentals
-- (#1 should be “Sports�? with 1179 rentals and #5 should be “Family�? with 1096 rentals)

SELECT category.name AS genre, COUNT(*) AS num_of_rentals
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY category.name
ORDER BY num_of_rentals DESC
LIMIT 5;

-- 18. The top five Action film titles by number of rentals
-- (#1 should have 30 rentals and #5 should have 28 rentals)

SELECT category.name AS genre, initcap(film.title) AS movie, COUNT(*) AS num_of_rentals
FROM film
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
WHERE category.name = 'Action'
GROUP BY category.name, film.title
ORDER BY num_of_rentals DESC
LIMIT 5;

-- 19. The top 10 actors ranked by number of rentals of films starring that actor
-- (#1 should be “GINA DEGENERES�? with 753 rentals and #10 should be “SEAN GUINESS�? with 599 rentals)

SELECT actor.actor_id, initcap(actor.first_name||' '||actor.last_name) AS actor_name, COUNT(*) AS num_of_rentals
FROM actor
JOIN film_actor ON film_actor.actor_id = actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY actor_name, actor.actor_id
ORDER BY num_of_rentals DESC
LIMIT 10;


-- 20. The top 5 “Comedy�? actors ranked by number of rentals of films in the “Comedy�? category starring that actor
-- (#1 should have 87 rentals and #5 should have 72 rentals)

SELECT actor.actor_id, initcap(actor.first_name||' '||actor.last_name) AS actor_name, COUNT(*) AS num_of_rentals
FROM actor
JOIN film_actor ON film_actor.actor_id = actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id 
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
WHERE category.name = 'Comedy'
GROUP BY actor_name, actor.actor_id --take every row that has matching values for these things and condense them down into one row
ORDER BY num_of_rentals DESC
LIMIT 5;

