/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 * 
 * @returns {number} 1
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

function multiplyNoUndefined(firstParameter=0, secondParameter=0) {
  return firstParameter * secondParameter;
}

 
/**
 * Functions can return earlier before the end of the function. This could be useful
 * in circumstances where you may not need to perform additional instructions or have to
 * handle a particular situation.
 * In this example, if the firstParameter is equal to 0, we return secondParameter times 2.
 * Observe what's printed to the console in both situations.
 * 
 * @param {number} firstParameter the first parameter
 * @param {number} secondParameter the second parameter
 */
function returnBeforeEnd(firstParameter, secondParameter) {
  console.log("This will always fire.");

  if (firstParameter == 0) {
    console.log("Returning secondParameter times two.");
    return secondParameter * 2; //if we return here we bail, the rest of the function won't run
  }

  //this only runs if firstParameter is NOT 0
  console.log("Returning firstParameter + secondParameter.");
  return firstParameter + secondParameter;
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
 * Takes some details about a person and returns a sentence to describe them
 * 
 * @param {string} name the name of the person we're describing 
 * @param {number} age the age of the person 
 * @param {string[]} listOfQuirks list of funny quirks 
 * @param {string} separator string to separate the quirks by (, is default) 
 * @returns {string} a funny sentence about the person
 */

function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  return description + listOfQuirks.join(separator);
}

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  return numbersToSum.reduce((acc, current) => acc + current);

  //if we need to set an initial value for the accumulator, that's a parameter to REDuCE after the anon function call
  /*
  return numbersToSum.reduce((acc, current) => acc + current, 0);

  */


}

/**
 * Takes an array and calling a named function generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbersUsingNamedFunction(numbersToSum) {
  return numbersToSum.reduce(addNumbers, 0); //what you would put in for the accumulator and current are going to get passed to addNumbers as parameters
}//0 has it start at index 0


function addNumbers(sum, number, index) {
  console.log(`Now adding index ${index} to the sum.`);
  return sum + number;
}

//if you don't give the accumulator an initial value, it starts out at the initial value in your array

function allDivisibleByThreeUsingNamedFunction(numbersToFilter) {
  return numbersToFilter.filter(isDivisibleByThree);
}

function isDivisibleByThree(number) {
  return number % 3 == 0;
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
  return numbersToFilter.filter( (element) => element % 3 == 0);
  
//if more than one line

numbersToFilter.filter( (element, index) => { return element % 3 == 0 /*I have access to index*/}); //def use curly braces if more than one line
}


/**
 * For each element in the array, print on a new line
 * 
 * @param {[] generic array} array 
 */
function demoForEach(array) {
  array.forEach( (item, index) => {
    console.log('Item at index ' + index + ' is ' + item);
  })
} //can do it with or without index


/**
 * Return a new array with all values doubled
 * 
 * @param {number[]} nums
 * @returns {number[]} a new array with all of the elements in nums doubled 
 */
function doubleAllArrayValues(nums) {
  nums.map( (element) => {
    return element * 2;
  })
}


/**
 * Return a new array with all values at even indexes doubled
 * 
 * @param {number[]} nums
 * @returns {number[]} a new array with elements at even indexes doubled, elements at odd indexes are not 
 */
function doubleAllArrayValuesAtEvenIndexes(nums) {
  nums.map((element, index) => {
    if (index % 2 == 0) {
      return element * 2;
    }
    return element;
  })
}

/**
 * Find a student named Dan and then returns his name
 * 
 * @param {string[]} students
 * @return {string} returns a string of the student's name 
 */

function findDan(students) {
  return students.find( (student) => student == 'Dan');
} //returns undefined if we don't find it


/* 
more complicated reduce 

take an array and return the sum of all even numbers at even indexes

*/

function sumDoubleEven(array) {
  return array.reduce((acc, current, index) => {
    
    if (index % 2 == 0 && current % 2 == 0) { //if index and current item are both even
      return acc + current;
    } else {
      return acc; //just return accumuluator unchanged
    }
  }, 0) //set the initial value to zero because we want to run the anon function on the first (0th) element instead of just setting the accumulator to it
}



/* 
more complicated reduce 

take an array and return the sum of all even numbers at even indexes using named function

*/

function sumDoubleEvenUsingNamed(array) {
  return array.reduce(AddIfBothEven, 0); //start value so it doesn't assume the first one is the start value
} 

function AddIfBothEven(sum, value, index) {
  if (isEven(value) && isEven(index)) {
    return sum+value;
  } else {
    return sum;
  }
}

function isEven(num) {
  return num % 2 == 0;
}
