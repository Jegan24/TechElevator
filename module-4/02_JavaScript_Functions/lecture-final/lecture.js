/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 */
function returnOne() {
  return 1;
}

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function.
 *
 * @param {any} value the value to print to the console
 */
function printToConsole(value) {
  console.log(value);
}

/**
 * Write a function called multiplyTogether that multiplies two numbers together. But 
 * what happens if we don't pass a value in? What happens if the value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */
function multiplyTogether(firstParameter, secondParameter) {
  return firstParameter * secondParameter;
}

/**
 * This version makes sure that no parameters are ever missing. If
 * someone calls this function without parameters, we default the
 * values to 0. However, it is impossible in JavaScript to prevent
 * someone from calling this function with data that is not a number.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply
 * @param {number} [secondParameter=0] the second parameter to multiply
 */
function multiplyNoUndefined(firstParameter = 0, secondParameter = 0) {
  return firstParameter * secondParameter;
}

/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    let scopedToBlock = inScopeInScopeTest;
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }

}

/**
 * Take the details of a person and create a sententence to describe them
 * Quirks are joined by a seperator parameter or , by default
 * 
 * @param {string} name name of the person we're describing
 * @param {number} age age of the person
 * @param {string[]} [listOfQuirks] is list of funny quirks that we'll list out 
 * @param {string} separator=', ' the string to seperate quirks by
 * @returns {string} the full descriptive string describing the person 
 */
function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  return description + listOfQuirks.join(separator);
}

/**
 * 
 */
function test() {
  return "abc";
}

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  return numbersToSum.reduce(
    /* add each number to the previous sum*/
    (sum, number) => {
      return sum + number;
    }
  );

  //if numbersToSum = [1,2,3,4]
  // first we'll have accumlator/sum set to 1 because we didn't have initial value
  // then we'll have sum is 1 and currentvalue/number is set to 2 -> this will return 3 so accumulator/sum will be set to 3
  // then we'll have sum is 3 and currentValue/number is set to 3 -> this will return 6 so sum will be set to 6
  // then we'll have sum is 6 and the number is 4 -> this will return 10 and then we're done
  // so the reduce will return 10 for [1,2,3,4]
}

/**
 * This will convert an array of strings into one $ seprated string
 * @param {string[]} strArray  the array
 */
function makeArrayOfStringsIntOne(strArray) {
  return strArray.reduce(
    (accumulator, current) => {
      return accumulator + "$" + current;
    }
  )
}

function demo() {
  let array = [4, 6, 8, 9, 12, 53, -17, 2, 5, 7, 31, 97, -1, 17];

  //let ar2 = array.filter(); error if you don't pass a function into filter
  console.log("filter using a named function: \n"+array.filter(isPrime)); //filter using a named function

  //filter using an anonymous function
  let newArray = array.filter(
    (num) => {
      if (num <= 1)
        return false;
      else if (num === 2)
        return true;
      else {
        for (let i = 2; i < num; i++)
          if (num % i === 0)
            return false;
        return true;
      }
    }
  );

  console.log("Filter using an anon function: "+newArray);

  //passing the filter method into another method
  let evenFilter = (num)=> {
    return (num%2 == 0);  

  }
  let evenArray = filterOn(array,evenFilter);

  let oddFilter = (num)=> {
    return (num%2 == 1);  

  }
  let oddArray = filterOn(array,oddFilter);

  console.log("Evens:" +evenArray);
  console.log("Odds" + oddArray);
}

function filterOn(array,filter){
  return array.filter(filter);
}

function isPrime(num) {
  if (num <= 1)
    return false;
  else if (num === 2)
    return true;
  else {
    for (let i = 2; i < num; i++)
      if (num % i === 0)
        return false;
    return true;
  }
}


/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function allDivisibleByThree(numbersToFilter) { 
  return numbersToFilter.filter(
    (number) => {
      //return whether or not the element named number should stay in the array 
      return (number%3==0);
    }

  );

}

//will passing a non-primitive to a function change it
function passArrayTest()
{
  let array=[1,2,3];
  console.log("Before "+ array);

  changeArray(array);
  console.log("after "+ array);
}

function changeArray(array)
{
  array.push(9);
}