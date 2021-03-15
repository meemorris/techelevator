/*
1. **iqTest** Bob is preparing to pass an IQ test. The most frequent task in this test 
    is to find out which one of the given numbers differs from the others. Bob observed
    that one number usually differs from the others in evenness. Help Bob — to check his 
    answers, he needs a program that among the given numbers finds one that is different in 
    evenness, and return the position of this number. _Keep in mind that your task is to help 
    Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)_

		iqTest("2 4 7 8 10") → 3 //third number is odd, while the rest are even
		iqTest("1 2 1 1") → 2 // second number is even, while the rest are odd
		iqTest("") → 0 // there are no numbers in the given set
        iqTest("2 2 4 6") → 0 // all numbers are even, therefore there is no position of an odd number
*/

        function iqTest(string) {
            const array = string.split(' ');
            
            for (let i = 0; i < array.length; i++) { //look at converting to foreach
                array[i] = parseInt(array[i]);
            }

            let count = 0;
            let result = 0;
            for (let i = 0; i < array.length; i++) {
                if (array[i] % 2 == 0) {
                    count++;
                }
            }


            for (let i = 0; i < array.length; i++) {
                if (count > 1) {
                    if (array[i] % 2 == 1) {
                        result = i + 1;
                    }
                } else if (array[i] % 2 == 0) {
                    result = i + 1;
                }
            }

            return result;

        }

/*
2. **titleCase** Write a function that will convert a string into title case, given an optional 
    list of exceptions (minor words). The list of minor words will be given as a string with each 
    word separated by a space. Your function should ignore the case of the minor words string -- 
    it should behave in the same way even if the case of the minor word string is changed.


* First argument (required): the original string to be converted.
* Second argument (optional): space-delimited list of minor words that must always be lowercase
except for the first word in the string. The JavaScript tests will pass undefined when this 
argument is unused.

		titleCase('a clash of KINGS', 'a an the of') // should return: 'A Clash of Kings'
		titleCase('THE WIND IN THE WILLOWS', 'The In') // should return: 'The Wind in the Willows'
        titleCase('the quick brown fox') // should return: 'The Quick Brown Fox'
*/

        function titleCase(string, optionalList) {
            let optionalArray = [];
            if (optionalList) {
                 optionalArray = optionalList.split(' ');
            }
            
            for (let i = 0; i < optionalArray.length; i++) {
                optionalArray[i] = optionalArray[i].toLowerCase();
            }

            const inputArray = string.split(' ');

            for (let i = 0; i < inputArray.length; i++) {
                if (!optionalArray.includes(inputArray[i].toLowerCase()) || i == 0) {
                    inputArray[i] = inputArray[i].charAt(0).toUpperCase() + inputArray[i].slice(1).toLowerCase();
                } else {
                    inputArray[i] = inputArray[i].toLowerCase();
                }
        }
        return inputArray.join(' ');
    }