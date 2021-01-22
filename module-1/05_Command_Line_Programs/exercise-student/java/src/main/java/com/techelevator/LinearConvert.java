package com.techelevator;

import java.util.Scanner;

public class LinearConvert {

	public static void main(String[] args) {

		//Greeting
		System.out.println("Good day to you! Welcome to the Meters & Feet Converter.");

		boolean finished = false;
		while (!finished) {

			//Prompt user to enter a length
			System.out.print("Please enter a length measurement: ");
			Scanner userInput = new Scanner(System.in);
			String initialLength = userInput.nextLine();
			double numericInitialLength = Double.parseDouble(initialLength);

			//Prompt user to indicate whether measurement is in (m)eters or (f)eet
			System.out.print("Please indicate whether measurement is in (m)eters or (f)eet. ");
			String indicatedMeasurement = userInput.nextLine();

			//Convert length to opposite measurement
			double feet = 0;
			double meters = 0;
			if (indicatedMeasurement.equals("m") || indicatedMeasurement.equals("M")) {
				feet = numericInitialLength * 3.2808399;
				System.out.format("%.2f meters is %.2f feet.\n", numericInitialLength, feet);
			} else if (indicatedMeasurement.equals("f") || indicatedMeasurement.equals("F")) {
				meters = numericInitialLength * 0.3048;
				System.out.format("%.2f feet is %.2f meters.\n", numericInitialLength, meters);
			}

			//Prompt user if they are finished
			System.out.print("Are you done making me do all these calculations (y/n)? ");
			String response = userInput.nextLine();
			if (response.equals("y")) {
				finished = true;
			}
		}
		//Farewell
		System.out.println("So long, farewell, we must bid you ado! Thank you for using the Meters & Feet Converter!");

	}

}
