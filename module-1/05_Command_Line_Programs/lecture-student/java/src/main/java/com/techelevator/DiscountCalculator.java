package com.techelevator;

import java.util.Scanner;

public class DiscountCalculator {

    public static void main(String[] args) {

        System.out.println("Welcome to the Discount Calculator!");

        boolean finished = false;
        while (!finished) {

            //prompt the user to enter a price
            System.out.print("Please enter a list of prices, separated by spaces: ");
            Scanner userInput = new Scanner(System.in);
            String prices = userInput.nextLine();
            String[] priceArray = prices.split(" ");

            //prompt user to enter discount percentage
            System.out.print("Please enter a discount percentage (20 for a 20% discount, for example): ");
            String discount = userInput.nextLine();

            //calculate the total price
            double total = 0;
            for (int i = 0; i < priceArray.length; i++) {
                double fullPrice = Double.parseDouble(priceArray[i]);
                total += fullPrice;
            }

            //calculate the discounted total
            int discountPercent = Integer.parseInt(discount);
            double discountAmount = total * (discountPercent / 100.0);
            double discountedTotal = total - discountAmount;


            //Print out the discounted price
            System.out.format("The total price is: $%.2f\n", total);
            System.out.format("The discounted price is: $%.2f\n", discountedTotal);

            System.out.print("Are you finished (y/n)? ");
            String response = userInput.nextLine();
            if (response.equals("y")) {
                finished = true;
            }

        }

        System.out.println("Thank you for using the Discount Calculator.");

    }


}
