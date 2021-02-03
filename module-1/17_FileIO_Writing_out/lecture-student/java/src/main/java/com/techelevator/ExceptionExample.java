package com.techelevator;


import java.util.Scanner;

public class ExceptionExample {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        boolean finished = false;
        while (!finished) {
            System.out.print("Please enter your first name: ");
            String firstName = input.nextLine();
            System.out.print("Please enter your last name: ");
            String lastName = input.nextLine();

            NameFormatter nameFormatter = new NameFormatter();
            //A
            try {
                //B
                String formattedName = nameFormatter.formatName(firstName, lastName);
                //C
                System.out.println("Your properly formatted name is: " + formattedName);
                finished = true;
            } catch (NameFormatException e) {
                //D
                System.out.println(e.getMessage());
            }
        }
            //E

        //if it runs without an exception the following lines run: A, B, C, E
        //if it runs and throws an exception the following lines run: A, B, D


    }



}
