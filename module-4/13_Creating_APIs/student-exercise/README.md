# Creating APIs Exercise

## Building your own API

In this exercise you are going to be responsible for building an API that can retrieve and update a list of groceries.

In this directory you will find the starting code for both Java & .NET

* Java: `/shopping-api-java`
* .NET: `/shopping-api-dotnet`

Everything you need to build your API is in these projects. There is a data access layer that uses an in memory representation of a shopping list item. This is very similar to what you did during lecture today. What you will need to do is build out the controller and that controller can use the data access layer to perform CRUD operations on the list of groceries.

You will use Postman to test your API. Included in the same directory as this file is a set of Postman tests you can import.

### Requirements

* The endpoint for your API should be /api/groceries
* You should have at least 10 items in your list of groceries when the application loads
* All 4 CRUD operations should be supported by your API
* All of the provided Postman tests should be passing
