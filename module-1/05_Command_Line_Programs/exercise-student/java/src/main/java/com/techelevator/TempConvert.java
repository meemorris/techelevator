package com.techelevator;

import java.util.Scanner;

public class TempConvert {

    public static void main(String[] args) {
        //Greeting
        System.out.println("Welcome to the Temperature Conversion Calculator!");

        boolean finished = false;

        while (!finished) {

            //Prompt user to enter temperature
            System.out.print("Please enter the temperature amount: ");
            Scanner userInput = new Scanner(System.in);
            String tempAmount = userInput.nextLine();
            double numericTempAmount = Double.parseDouble(tempAmount);

            //Prompt user to clarify if F or C
            System.out.print("Is the temperature in (C)elsius or (F)arenheit? ");
            String tempType = userInput.nextLine();

            //Convert the temperatures to the opposite degrees
            if (tempType.equals("C") || tempType.equals("c")) {
                double celcToFarhen = (numericTempAmount * 1.8) + 32;
                System.out.format("You entered %.2f°C. The converted temperature is %.2f°F.\n", numericTempAmount, celcToFarhen);
            } else if (tempType.equals("F") || tempType.equals("f")) {
                double farhenToCelc = (numericTempAmount - 32) / 1.8;
                System.out.format("You entered %.2f°F. The converted temperature is %.2f°C.\n", numericTempAmount, farhenToCelc);
            }

            //Ask user if they are finished?
            System.out.print("Do you have other temperature values you'd like to enter (y/n)? ");
            String response = userInput.nextLine();
            if (response.equals("n")) {
                finished = true;
            }
        }
        //Farewell
        System.out.println("Thank you for using the Temperature Conversion Calculator.");
    }

}

