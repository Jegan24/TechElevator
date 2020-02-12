USE World
-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in millions of US Dollars
--   The value immediately after the problem statement is the expected number of rows that should be returned by the query.

--SELECT 'The name and population of all cities in Ontario, Canada (27 rows)' AS 'Problem 1'
SELECT 
	city.name,
	city.population
FROM 
	city
WHERE
	district = 'Ontario'
	
--SELECT 'The name and population of all cities in Montana (1 row)' AS 'Problem 2'
SELECT 
	city.name,
	city.population
FROM 
	city
WHERE
	district = 'Montana'

--SELECT 'The name, form of government, and head of state of all countries in Europe (46 rows)' AS 'Problem 3'
SELECT
	name,
	governmentform
FROM
	country
WHERE
	continent = 'Europe'

--SELECT 'The name, population, surface area, and average life expectancy of all countries in Asia (51 rows)' AS 'Problem 4'
SELECT
	name,
	population,
	surfacearea,
	lifeexpectancy
FROM	
	country
WHERE
	continent = 'Asia'

--SELECT 'The name, country code, and population of all cities with a population greater than 8 million people (10 rows)' AS 'Problem 5'
SELECT
	name,
	countrycode,
	population
FROM
	city
WHERE
	population > 8000000

--SELECT 'The name, country code, and population of all cities with a population less than one thousand people (11 rows)' AS 'Problem 6'
SELECT
	name,
	countrycode,
	population
FROM
	city
WHERE
	population <= 1000

--SELECT 'The name, continent, and GNP of all countries with a GNP greater than one trillion dollars (6 rows)' AS 'Problem 7'
SELECT
	name,
	continent,
	gnp
FROM
	country
WHERE
	gnp > 1000000

--SELECT 'The name, continent, population, GNP, and average life expectancy of all countries with an average life expectancy greater than 80 years (5 rows)' AS 'Problem 8'
SELECT
	name,
	continent,
	population,
	gnp,
	lifeexpectancy
FROM
	country
WHERE
	lifeexpectancy > 80

--SELECT 'The name and population of all cities in the USA with a population of greater than 1 million people (9 rows)' AS 'Problem 9'
SELECT
	name,
	population
FROM
	city
WHERE
	countrycode = 'USA'
AND population > 1000000

--SELECT 'The name and population of all cities in China with a population of greater than 1 million people (35 rows)' AS 'Problem 10'
SELECT
	name,
	population
FROM
	city
WHERE
	countrycode = 'CHN'
AND population > 1000000

--SELECT 'The name and region of all countries in North or South America (51 rows)' AS 'Problem 11'
SELECT
	name,
	region
FROM
	country
WHERE
	continent LIKE '% America'

--SELECT 'The name, continent, and head of state of all countries whose form of government is a monarchy (43 rows)' AS 'Problem 12'
SELECT
	name,
	continent,
	headofstate
FROM
	country
WHERE
	governmentform LIKE '%Monarchy%'

--SELECT 'The name of all cities in the USA with a population between 1 million and 2 million people (6 rows)' AS 'Problem 13'
SELECT
	name
FROM
	city
WHERE
	countrycode = 'USA'
AND	population > 1000000
AND population < 2000000

--SELECT 'The name and region of all countries in North or South America except for countries in the Caribbean (27 rows)' AS 'Problem 14'
SELECT
	name,
	region
FROM
	country
WHERE
	region LIKE '% America'

--SELECT 'The name, population, and GNP of all countries with a GNP greater than $1 trillion dollars and a population of less than 100 million people (4 rows)' AS 'Problem 15'
SELECT
	name,
	population,
	gnp
FROM
	country
WHERE
	population < 100000000
AND gnp > 1000000

--SELECT 'The name and population of all cities in Texas that have a population of greater than 1 million people (3 rows)' AS 'Problem 16'
SELECT
	name,
	population
FROM
	city
WHERE
	district = 'Texas'
AND	population > 1000000

--SELECT 'The name and average life expectancy of all countries on the continent of Oceania (28 rows)' AS 'Problem 17'
SELECT
	name,
	lifeexpectancy
FROM
	country
WHERE
	continent = 'Oceania'

--SELECT 'The name and average life expectancy of all countries on the continent of Oceania for which an average life expectancy has been provided (i.e. not equal to null) (20 rows)' AS 'Problem 18'
SELECT
	name,
	lifeexpectancy
FROM
	country
WHERE
	continent = 'Oceania'
AND	lifeexpectancy IS NOT NULL

--SELECT 'The name of all countries on the continent of Oceania for which an average life expectancy has not been provided (i.e. equal to null) (8 rows)' AS 'Problem 19'
SELECT
	name,
	lifeexpectancy
FROM
	country
WHERE
	continent = 'Oceania'
AND	lifeexpectancy IS NULL

--SELECT 'The name, continent, GNP, and average life expectancy of all countries that have an average life expectancy of at least 70 years and a GNP between $1 million and $100 million dollars (3 rows)' AS 'Problem 20'
SELECT
	name,
	continent,
	gnp,
	lifeexpectancy
FROM
	country
WHERE
	lifeexpectancy >= 70
AND gnp >= 1
AND gnp <= 100

--SELECT 'The per capita GNP (i.e. GNP divided by population) in US Dollars of all countries in Europe (46 rows)' AS 'Problem 21'
SELECT
	name,
	(gnp / population) * 1000000 AS 'gnpPerCapita'
FROM
	country
WHERE
	continent = 'Europe'

--SELECT 'The number of years since independence for all countries that have a year of independence (192 rows)' AS 'Problem 22'
SELECT
	name,
	DATEPART(YYYY, GETDATE()) - indepyear AS 'yearsOfIndependence'
FROM
	country
WHERE
	indepyear IS NOT NULL