package com.techelevator.exceptions;

import java.util.Scanner;

public class Example3 {

	static Scanner scan = new Scanner(System.in);
	
	public static void main(String[] args) {
		
		/* catch statements can take advantage of polymorphism. The catch block will handle any Exception that 
		 * matches the declared Exception type, including subclasses of the declared type */
		try {
			System.out.println("The standard work week is 40 hours.");
			System.out.print("How many hours did you work this week? >>> ");
			int hoursWorked = Integer.valueOf( scan.nextLine() ); 
			int overtimeHours = hoursWorked - 40;
			System.out.println("You worked "+overtimeHours+" hours of overtime.");
		} catch(Exception e) { // If a NumberFormatException is thrown by Integer.valueOf(...) it will be caught here since NumberFormatException "is-a" Exception
			System.out.println("You did it wrong...");
		}
		
	}

}
