package com.techelevator;

import java.util.Scanner;
import java.text.DecimalFormat;

public class DecimalToBinary {

	public static void main(String[] args) {

		//Greeting
		System.out.println("Welcome to the Decimal To Binary Calculator!");

		boolean finished = false;
		while (!finished) {

			//Prompt user for a series of decimal integer values separated by spaces
			System.out.print("Please provide us with a series of decimal integer values (separated by spaces): ");
			Scanner userInput = new Scanner(System.in);
			String decimals = userInput.nextLine();
			String[] integerArray = decimals.split(" ");

			for (int i = 0; i < integerArray.length; i++) {
				int decimal = Integer.parseInt(integerArray[i]); //convert to integer
				String binary = Integer.toBinaryString(decimal); //convert to binary string
				System.out.println(decimal + " in binary is " + binary);		// print
			}

			//Ask if they would like to enter any other integer values
			System.out.print("Would you like to enter any other integer values (y/n)? ");
			String response = userInput.nextLine();
			if (response.equals("n")) {
				finished = true;
			}
		}
		//Farewell
		System.out.println("Thank you for using the Decimal To Binary Calculator.");
	}
}
