package com.techelevator.exceptions;

public class Example2 {

	public static void main(String[] args) {
		
		/* try/catch blocks will also catch Exceptions that are thrown from method calls further down the stack */
		try {
			System.out.println("Hey ya'll, watch this!");
			doSomethingDangerous();  // throws an ArrayIndexOutOfBoundsException
			System.out.println("See, I told you nothing would go wrong!");
		} catch(ArrayIndexOutOfBoundsException e) {  
			System.out.println("Call the Darwin Awards...");
		}
		
		
		/* every Exception contains a "stacktrace" that can be extremely useful in debugging.
		 * The stacktrace contains a record of where the Exception was thrown and all of the 
		 * method calls that lead up to the Exception being thrown. */
		try {
			doSomethingDangerous(); // throws an ArrayIndexOutOfBoundsException
		} catch (ArrayIndexOutOfBoundsException e) {
			System.out.println("AN EXAMPLE OF A STACKTRACE:");
			e.printStackTrace(); // will print the Exception stacktrace to the terminal
		}

	}
	
	private static void doSomethingDangerous() {
		int[] numbers = new int[5];
		for(int i = 0; i < 10; i++) {
			numbers[i] = i;  // this line will throw an Exception once i reaches 5
		}
		System.out.println("Look Ma, no Exceptions!");  // This line will not execute because an Exception will be thrown inside the for loop
	}

}
