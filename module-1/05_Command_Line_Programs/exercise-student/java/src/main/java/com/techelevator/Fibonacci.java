package com.techelevator;

import java.util.Scanner;

public class Fibonacci {

	public static void main(String[] args) {

		//Greeting
		System.out.println("Greetings from the Fibonacci Sequence Program!");

		boolean finished = false;
		while (!finished) {

			//Prompt user for an integer value
			System.out.print("Let's get started! Please provide us with an integer value: ");
			Scanner userInput = new Scanner(System.in);
			String providedInteger = userInput.nextLine();
			Integer numericInteger = Integer.parseInt(providedInteger);

			//Create variables for fibonacci sequence
			int fibonacciTwo = 1;
			int fibonacci = 0;

			//Calculate and Display fibonacci sequence leading up to that number

			if (numericInteger > 1) {
				System.out.println("The Fibonacci numbers less than " + numericInteger + " are: ");
				System.out.print("0, 1, 1, ");
				for (int i = 1; i + fibonacciTwo < numericInteger;) {
					fibonacci = i + fibonacciTwo;
					i = fibonacciTwo;
					fibonacciTwo = fibonacci;
					System.out.print(fibonacci + ", ");
				}
			} else {
				System.out.println("There are no numbers less than " + numericInteger + " in the Fibonacci series.");
			}

			//Ask user if they have any other numbers they'd like to try
			System.out.print("\nAny other numbers you'd like to try (y/n)? ");
			String response = userInput.nextLine();
			if (response.equals("n")) {
				finished = true;
			}
		}

		//Adios
		System.out.println("Goodbye friend! Thanks for using the Fibonacci Sequence Program.");

	}

}
