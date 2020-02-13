USE World
-- INSERT

-- 1. Add Klingon as a spoken language in the USA
INSERT INTO countrylanguage(countrycode, language, isofficial, percentage)
VALUES ('USA', 'Klingon', 1, 2.04)
SELECT * FROM countrylanguage WHERE isofficial = 1 AND countrycode = 'USA'
-- 2. Add Klingon as a spoken language in Great Britain
--INSERT INTO countrylanguage(countrycode, language, isofficial, percentage)


-- UPDATE

-- 1. Update the capital of the USA to Houston
UPDATE country
SET
	capital = c.id
FROM
(
SELECT
	id
FROM
	city
WHERE
	city.name = 'Houston') AS c
WHERE 
	code = 'USA'

SELECT * FROM country JOIN city ON country.capital = city.id WHERE code = 'USA'
-- 2. Update the capital of the USA to Washington DC and the head of state


-- DELETE

-- 1. Delete English as a spoken language in the USA
-- 2. Delete all occurrences of the Klingon language 


-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?

-- 3. Try deleting the country USA. What happens?


-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'


-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.

-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table
-- where one happens to be inside of a transaction but hasn't committed yet.