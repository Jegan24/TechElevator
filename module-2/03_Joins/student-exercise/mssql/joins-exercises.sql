USE dvdstore;
GO
-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT
	*
FROM
		film
		JOIN	film_actor
			JOIN actor 
			ON film_actor.actor_id	= actor.actor_id
		ON	film.film_id			= film_actor.film_id
WHERE
	actor.first_name	= 'Nick'
AND	actor.last_name		= 'Stallone'
-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT
	*
FROM
		film
		JOIN	film_actor
			JOIN actor 
			ON film_actor.actor_id	= actor.actor_id
		ON	film.film_id			= film_actor.film_id
WHERE
	actor.first_name	= 'Rita'
AND	actor.last_name		= 'Reynolds'
-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT
	*
FROM
		film
		JOIN	film_actor
			JOIN actor 
			ON film_actor.actor_id	= actor.actor_id
		ON	film.film_id			= film_actor.film_id
WHERE
(
	actor.first_name	= 'Judy'
OR	actor.first_name	= 'River'
)
AND	actor.last_name		= 'Dean'
	

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT
	*
FROM
	film JOIN film_category
			JOIN	category
			ON	film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name = 'Documentary'
-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT
	*
FROM
	film JOIN film_category
			JOIN	category
			ON	film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name = 'Comedy'
-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT
	*
FROM
	film JOIN film_category
			JOIN	category
			ON	film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name = 'Children'
AND	rating = 'G'
-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT
	*
FROM
	film JOIN film_category
			JOIN	category
			ON	film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name = 'Family'
AND	rating = 'G'
AND length < 120
-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT
	*
FROM
	film JOIN film_actor
		JOIN actor
		ON	film_actor.actor_id = actor.actor_id
	ON film.film_id = film_actor.film_id
WHERE
	rating = 'G'
AND	first_name = 'Matthew'
AND last_name = 'Leigh'
-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT
	*
FROM
	film JOIN film_category
			JOIN	category
			ON	film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name = 'Sci-Fi'
AND	release_year = 2006
-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT
	*
FROM
	film JOIN film_actor
		JOIN actor
		ON	film_actor.actor_id = actor.actor_id
	ON film.film_id = film_actor.film_id
	JOIN film_category 
		JOIN category 
		ON film_category.category_id = category.category_id
	ON film.film_id = film_category.film_id
WHERE
	category.name	= 'Action'
AND	first_name		= 'Nick'
AND last_name		= 'Stallone'
-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT
	*
FROM
	address
	JOIN store
	ON store.address_id = address.address_id
	JOIN city
	ON address.city_id = city.city_id
-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT
	store.store_id,
	address.address,
	staff.first_name + ' ' + staff.last_name AS managerName

FROM
	store JOIN address
	ON store.address_id = address.address_id
	JOIN staff
	ON store.manager_staff_id = staff.staff_id
-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP 10
	customer.first_name + ' ' +customer.last_name AS customerName,
	customerRentalCounts.num_rentals
FROM
(
	SELECT 
		COUNT(customer_id) AS num_rentals,
		customer_id
	FROM
		rental
	GROUP BY
		customer_id
) AS customerRentalCounts
JOIN customer
ON customerRentalCounts.customer_id = customer.customer_id
ORDER BY
	num_rentals DESC
-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP 10
	customer.first_name + ' ' + customer.last_name,
	customer_spendings.total_spent
FROM
(
	SELECT
		SUM(amount) AS total_spent,
		customer.customer_id
	FROM
		payment JOIN customer
		on payment.customer_id = customer.customer_id
	GROUP BY
		customer.customer_id
) AS customer_spendings
JOIN customer on customer_spendings.customer_id = customer.customer_id
ORDER BY
	total_spent DESC
-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT
	store.store_id,
	address.address,
	COUNT(*)			AS total_rentals,
	SUM(payment.amount)	AS total_sales,
	AVG(payment.amount) AS avg_sales	
FROM
	store 
	JOIN inventory
		JOIN rental
			JOIN payment
			ON	rental.rental_id	= payment.rental_id
		ON inventory.inventory_id = rental.inventory_id
	ON store.store_id = inventory.store_id
	JOIN address
	ON store.address_id = address.address_id
GROUP BY
	store.store_id, address.address

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10
	film.title,
	COUNT(rental.rental_id) AS rental_count
FROM
	rental
	JOIN inventory
		JOIN film
		ON inventory.film_id = film.film_id
	ON rental.inventory_id = inventory.inventory_id
GROUP BY
	film.title

ORDER BY
	rental_count DESC

-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP 5
	category.name,
	COUNT(rental.rental_id) AS rental_count
FROM
	rental
	JOIN inventory
		JOIN film
			JOIN film_category
				JOIN category
				ON film_category.category_id = category.category_id
			ON film.film_id = film_category.film_id
		ON inventory.film_id = film.film_id
	ON rental.inventory_id = inventory.inventory_id
GROUP BY
	category.name
ORDER BY
	rental_count DESC

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP 5
	film.title,
	COUNT(rental.rental_id) AS rental_count
FROM
	rental
	JOIN inventory
		JOIN film
			JOIN film_category
				JOIN category
				ON film_category.category_id = category.category_id
			ON film.film_id = film_category.film_id
		ON inventory.film_id = film.film_id
	ON rental.inventory_id = inventory.inventory_id
WHERE
	category.name = 'Action'
GROUP BY
	film.title
ORDER BY
	rental_count DESC

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP 10
	actor.actor_id,
	actor.first_name + ' ' + actor.last_name AS actor_name,
	COUNT(rental.rental_id) AS rental_count
FROM
	rental
	JOIN inventory
		JOIN film
			JOIN film_actor
				JOIN actor
				ON film_actor.actor_id = actor.actor_id
			ON film.film_id = film_actor.film_id
		ON inventory.film_id = film.film_id
	ON rental.inventory_id = inventory.inventory_id
GROUP BY
	actor.actor_id, actor.first_name + ' ' + actor.last_name
ORDER BY
	rental_count DESC
-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP 5
	actor.first_name + ' ' + actor.last_name AS actor_name,
	COUNT(rental.rental_id) AS rental_count
FROM
	rental
	JOIN inventory
		JOIN film
			JOIN film_actor
				JOIN actor
				ON film_actor.actor_id = actor.actor_id
			ON film.film_id = film_actor.film_id
			JOIN film_category
				JOIN category
				ON film_category.category_id = category.category_id
			ON film.film_id = film_category.film_id
		ON inventory.film_id = film.film_id
	ON rental.inventory_id = inventory.inventory_id
WHERE
	category.name = 'Comedy'
GROUP BY
	actor.first_name + ' ' + actor.last_name
ORDER BY
	rental_count DESC