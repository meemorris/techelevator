package com.techelevator;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.Path;
import java.util.Scanner;

public class SimpleCopier {

    public static void main(String[] args) {

        Scanner userInput = new Scanner(System.in);

        System.out.print("Please enter a filename to copy: ");
        String sourceFilename = userInput.nextLine();

        System.out.print("Please enter a new name to copy to: ");
        String destFilename = userInput.nextLine();

        Path source = Path.of(sourceFilename);
        try (Scanner sourceScanner = new Scanner(source)) {
            try (PrintWriter destWriter = new PrintWriter(destFilename)) {

                while (sourceScanner.hasNextLine()) {
                    String line = sourceScanner.nextLine(); //read a line
                    //Any changes to the line would happen here.
                    destWriter.println(line); //write a line
                }
            } catch (FileNotFoundException e) {
                System.out.println("Output file couldn't be written to.");
            }
        } catch (IOException e) {
            System.out.println("Couldn't read from input file.");
        }

    }
}
