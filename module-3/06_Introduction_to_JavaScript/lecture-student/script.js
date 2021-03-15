/*
    Example of a multi-line comment just like in C#/Java
*/

// Single line comment
let daysInMonth = 31; //not inside a function
console.log(daysInMonth); //don't need to have everything in a function, stuff outside a function will just automatically load in the browser, normally you'd want things
//to only run when you have an event, etc. so keep them in functions

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // Declares a variable where the value cannot be changed
  const daysInWeek = 7;
  console.log(daysInWeek);

  // Declares a variable those value can be changed
  let daysInMonth = 31;
  console.log(`Number of days this month ${daysInMonth}`);

  // Declares a variable that will always be an array
  const daysOfTheWeek = ['Monday','Tuesday','Wednesday','Thursday','Friday'];
  console.table(daysOfTheWeek);
  daysOfTheWeek.push('Saturday');
  console.table(daysOfTheWeek);
  const myArray = []; /*
  this always points to myArray but I am allowed to add and remove items from the array 
  (unlike Java) (push, pop, shift) (arrays are not fixed in size in javascript)
  */
}

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  console.log(`The value of param1 is ${param1}`);
  console.log(`The value of param2 is ${param2}`);
}

/**
 * Compares two values x and y.
 * == is loose equality
 * === is strict equality
 * @param {Object} x
 * @param {Object} y
 */
function equality(x, y) {
  console.log(`x is ${typeof x}`);
  console.log(`y is ${typeof y}`);

  console.log(`x == y : ${x == y}`); // true
  console.log(`x === y : ${x === y}`); // false
}

/**
 * Each value is inherently truthy or falsy.
 * false, 0, '', null, undefined, and NaN are always falsy
 * everything else is always truthy
 * @param {Object} x The object to check for truthy or falsy,
 */
function falsy(x) {
  if (x) { //if this thing, if its null, undefined or NaN it will be false //if x is just one variable it is checking truthy falsy, vs. if (x==7), boolean thing. 
    console.log(`${x} is truthy`);
  } else {
    console.log(`${x} is falsy`);
  }
} //a use case to make sure that what you get back from an API is not undefined

/**
 *  Objects are simple key-value pairs
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
*/
function objects() {
  const person = {
    firstName: "Bill",
    lastName: "Lumbergh",
    age: 42,
    employees: [
      "Peter Gibbons",
      "Milton Waddams",
      "Samir Nagheenanajar",
      "Michael Bolton"
    ],
    toString: function() {
      return `${this.lastName}, ${this.firstName}, ${(this.age)}`;
    }
  };

  // Log the object
  console.log(person.toString());
  console.table(person);

  // Log the first and last name
  console.log('First name is ' + person.firstName);
  console.log('Last name is: ' + person.lastName);

  // Log each employee
  for (let i = 0; i < person.employees.length; i++) {
    console.log(`Employee number ${i} is ${person.employees[i]}`);
  }

  //using a foreach loop (foreah doesn't give you access to the index just like in java, in javascript you see foreach loops more than traditional for loops)
  console.log('with a foreach loop');
  person.employees.forEach(element=> console.log(element));



}

/*
########################
Function Overloading
########################

Function Overloading is not available in Javascript. If you declare a
function with the same name, more than one time in a script file, the
earlier ones are overriden and the most recent one will be used.
*/

function Add(num1, num2) {
  return num1 + num2;
}

function Add(num1, num2, num3) {
  return num1 + num2 + num3;
}

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
}

/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);
  console.log(value.toLowerCase()); //just like in java, returning a string, not changing the value
  console.log(value);

  /*
    Other Methods
        - split(string)
        - substr(number, number) //these two are different from each other
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}


//arrays
function testArray() {
  const myArray = [1, 2, 3];
  console.table(myArray);
  console.log('push 8');
  myArray.push(8); //adds 8 on to the end
  console.table(myArray);
  console.log('popping');
  console.log(myArray.pop()); //returns the value that it pops off

  console.log('after pop');
  console.table(myArray);

  //concat merges two or more arrays and returns a new one. your array can have different kinds of values. it doesn't change either original array, it creates a whole new one.
  const array2 = ['one','two'];
  const arrayConcat = myArray.concat(array2);
  console.log('The concatenated array');
  console.table(arrayConcat);
}
