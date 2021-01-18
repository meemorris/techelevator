package com.techelevator;

import java.util.Scanner;

public class Greeter {

    public static void main(String[] args) {
        //1. Get user input
        System.out.print("Please enter your name: ");
        String name = new Scanner(System.in).nextLine();

        //2. Do something with that input
        String greeting = "Good morning " + name + "!";

        //3. Output result to user
        System.out.println(greeting);
    }
}
