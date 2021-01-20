package com.techelevator;


import java.util.Scanner;

public class DiscountCalculator {

    public static void main(String[] args) {

        System.out.println("Welcome to the Discount Calculator!");

        boolean finished = false;
        while (finished == false) {
            //Prompt user to enter price
            System.out.print("Please enter a list of prices, separated by spaces: ");
            Scanner input = new Scanner(System.in);
            String prices = input.nextLine();
            String[] priceArray = prices.split(" ");

            //Prompt user to enter discount percentage
            System.out.print("Please enter a discount percentage (20 for a 20% discount, for example): ");
            String discount = input.nextLine();

            //Calculate the total price
            double total = 0;
            for (int i = 0; i < priceArray.length; i++) {
                double undiscountedPrice = Double.parseDouble(priceArray[i]);
                total += undiscountedPrice;
            }

            //Calculate the discounted total
            int discountPercent = Integer.parseInt(discount);
            double discountAmount = total * (discountPercent / 100.0);
            double discountedTotal = total - discountAmount;

            //Print out the discounted price
            System.out.format("The total price is: $%.2f.\n", total);
            System.out.format("The discounted total is: $%.2f.\n", discountedTotal);

            System.out.print("Are you finished (y/n)? ");
            String response = input.nextLine();
            if (response.equals("y")) {
                finished = true;
            }
        }

        System.out.println("Thank you for using the Discount Calculator.");

    }


}
