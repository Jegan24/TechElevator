
-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**
USE [dvdstore]
-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor(first_name, last_name)
VALUES ('Hampton', 'Avenue'), ('Lisa', 'Byway')

SELECT * FROM actor WHERE last_name = 'Avenue' OR last_name = 'Byway'

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT INTO film(title,description,release_year,language_id,original_language_id,length)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 1, 198)

SELECT * FROM film WHERE title = 'Euclidean PI'
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor (actor_id, film_id)
VALUES	((SELECT actor_id FROM actor WHERE first_name = 'Hampton'	AND last_name = 'Avenue'),	(SELECT film_id FROM film WHERE title = 'Euclidean PI')),
		((SELECT actor_id FROM actor WHERE first_name = 'Lisa'		AND last_name = 'Byway'),	(SELECT film_id FROM film WHERE title = 'Euclidean PI'))
-- 4. Add Mathmagical to the category table.
INSERT INTO category(name) VALUES ('Mathmagical')
-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category(film_id,category_id)
VALUES((SELECT film_id FROM film WHERE title = 'Euclidean PI'),(SELECT category.category_id FROM category WHERE name ='Mathmagical'))

UPDATE film_category
SET film_category.category_id = (SELECT category.category_id FROM category WHERE name ='Mathmagical')
FROM
	film
	JOIN film_category
	ON film.film_id = film_category.film_id
WHERE
	film.title	=	('Euclidean PI')
OR	film.title	=	('EGG IGBY')
OR	film.title	=	('KARATE MOON')
OR	film.title	=	('RANDOM GO')
OR	film.title	=	('YOUNG LANGUAGE')

--SELECT
--	*
--FROM
--	film
--	JOIN film_category
--		JOIN category
--		ON film_category.category_id = category.category_id
--	ON film.film_id = film_category.film_id
--WHERE
--	category.name = 'Mathmagical'
-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
FROM
	film
	JOIN film_category
		JOIN category
		ON film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name = 'Mathmagical'

-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory
SELECT
	(SELECT film_id FROM film WHERE title = 'Euclidean PI') AS film_id,
	1 AS store_id

INSERT INTO inventory
SELECT
	(SELECT film_id FROM film WHERE title = 'Euclidean PI') AS film_id,
	2 AS store_id

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE FROM film
WHERE film.title = 'Euclidean PI'
-- No because other tables/records are dependent on this record. (foreign key integrity checks)

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE FROM category
WHERE category.name = 'Mathmagical'
-- No because other tables/records are dependent on this record. (foreign key integrity checks)

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
DELETE FROM film_category
WHERE category_id = (SELECT category_id FROM category WHERE name = 'Mathmagical')
-- <YOUR ANSWER HERE>
-- yes because it didn't have any dependent records

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
DELETE FROM film_category
WHERE category_id = (SELECT category_id FROM category WHERE name = 'Mathmagical')

DELETE FROM film_category
WHERE film_id = (SELECT film_id FROM film WHERE title = 'Euclidean PI')
-- <YOUR ANSWER HERE>
-- yes but no. it doesn't fail, it just doesn't change any records since there are no matches

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
-- The film_actors records containing the id of euclidean pi need to be removed before removing the film titled euclidean pi