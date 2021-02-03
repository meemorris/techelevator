package com.techelevator.exceptions;

public class Example1 {

	public static void main(String[] args) {
		
		/* By default, when an Exception is thrown, it will "bubble up" through the call stack until
		 * it reaches the main method and then will cause the program to exit and print a stacktrace
		 * to the standard output 
		 * 
		 * By using try/catch blocks, you can stop the Exception from exiting the method and provide
		 * code to handle it. */
		System.out.println("The following cities: ");
		String[] cities = new String[] { "Cleveland", "Columbus", "Cincinnati" };
		try {
			System.out.println(cities[0]);
			System.out.println(cities[1]);
			System.out.println(cities[2]);
			System.out.println(cities[3]);  // This statement will throw an ArrayIndexOutOfBoundsException
			System.out.println("are all in Ohio."); // This line won't execute because the previous statement throws an Exception
		} catch(ArrayIndexOutOfBoundsException e) {
			// Flow of control resumes here after the Exception is thrown
			System.out.println("XXX   Uh-oh, something went wrong...   XXX");
		}

	}
	
	

}
