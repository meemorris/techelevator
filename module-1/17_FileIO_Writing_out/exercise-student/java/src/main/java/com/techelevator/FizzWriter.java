package com.techelevator;

import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class FizzWriter {

	public static void main(String[] args) {

		Scanner user = new Scanner(System.in);

		System.out.println("What is the destination file?");
		String destFile = user.nextLine();

		try(PrintWriter destWriter = new PrintWriter(destFile)) {

			for (int i = 1; i < 301; i++) {
				if (i % 3 == 0 && i % 5 == 0) {
					destWriter.println("FizzBuzz");
				} else if (i % 3 == 0 || String.valueOf(i).contains("3")) {
					destWriter.println("Fizz");
				} else if (i % 5 == 0 || String.valueOf(i).contains("5")) {
					destWriter.println("Buzz");
				} else {
					destWriter.println(i);
				}
			}


		} catch (FileNotFoundException e) {
			System.out.println("Output file couldn't be written to.");
		}

	}

}
