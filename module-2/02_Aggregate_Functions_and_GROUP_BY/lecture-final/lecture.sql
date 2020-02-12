-- ORDERING RESULTS

-- Populations of all countries in descending order
SELECT *
FROM country
ORDER BY population DESC 

--Names of countries and continents in ascending order

SELECT name, continent
FROM country
ORDER BY name ASC, continent


-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT TOP 10  lifeexpectancy, name
FROM country
ORDER BY lifeexpectancy DESC

--(col + ' - ' + col)
-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city
SELECT (name + ', ' + district) as name_and_state
FROM city
WHERE district IN ('California', 'Oregon', 'Washington')
ORDER BY district ASC, name ASC

-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World
SELECT AVG(lifeexpectancy)
FROM country

-- Total population in Ohio
SELECT SUM(population)
FROM city
WHERE district = 'ohio'

-- The surface area of the smallest country in the world
SELECT * from country where surfacearea=
(SELECT MIN(surfacearea)
FROM country)

SELECT TOP 1 *
FROM country
ORDER BY surfacearea ASC

-- The 10 largest countries in the world
SELECT TOP 10 *
FROM country
ORDER BY surfacearea DESC
-- The number of countries who declared independence in 1991
SELECT COUNT(*) AS number_of_countries
FROM country
WHERE indepyear =1991

-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT language, COUNT(language) AS number_of_countries
FROM countrylanguage
GROUP BY language
ORDER BY number_of_countries DESC

-- Average life expectancy of each continent ordered from highest to lowest
SELECT AVG(lifeexpectancy) AS lifeexpectancy, continent
FROM country
GROUP BY continent
ORDER BY lifeexpectancy DESC

-- Exclude Antarctica from consideration for average life expectancy

SELECT AVG(lifeexpectancy) AS lifeexpectancy, continent
FROM country
WHERE continent <> 'Antarctica'
GROUP BY continent
ORDER BY lifeexpectancy DESC

-- Sum of the population of cities in each state in the USA ordered by state name
SELECT SUM(population) AS sum_pop, district
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district


-- The average population of cities in each state in the USA ordered by state name

SELECT AVG(population) AS sum_pop, district
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district

-- SUBQUERIES
-- Find the names of cities under a given government leader
SELECT * FROM city WHERE countrycode IN(
SELECT code from country where headofstate like '%bush%')

-- Find the names of cities whose country they belong to has not declared independence yet
SELECT * 
FROM city 
WHERE countrycode IN(
	SELECT code FROM 
	country
	WHERE indepyear IS NULL
	)

-- Additional samples


-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

SELECT * 
FROM city
WHERE countrycode = 'USA'
ORDER BY name, district

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)
SELECT name, population
FROM city
ORDER BY population DESC
OFFSET 10 ROWS FETCH NEXT 15 ROWS ONLY

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table

-- Also counts the number of rows in the city table

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. 
--For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
SELECT countrycode, MIN(population) AS min_pop, MAX(population) AS max_pop
FROM city
GROUP BY countrycode
