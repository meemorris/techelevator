package com.techelevator;

import java.util.Arrays;
import java.util.Scanner;

public class DecimalToBinaryManual {

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

            StringBuilder binary = new StringBuilder();
            for (int i = 0; i < integerArray.length; i++) {
                int providedDecimal = Integer.parseInt(integerArray[i]);
                int decimal = providedDecimal;
                if (integerArray.length > 1) {
                    binary = new StringBuilder();
                }
                while (decimal > 0) {
                    if (decimal % 2 == 0) {
                        binary.append("0");
                    } else {
                        binary.append("1");
                    }
                    decimal = decimal / 2;
                }
                System.out.println(providedDecimal + " in binary is " + binary.reverse());
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
