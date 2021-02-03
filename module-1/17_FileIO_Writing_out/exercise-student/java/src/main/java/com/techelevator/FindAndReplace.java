package com.techelevator;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.Path;
import java.util.Scanner;

public class FindAndReplace {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.println("What is the search word?");
        String searchWord = input.nextLine();

        System.out.println("What is the replacement word?");
        String replacementWord = input.nextLine();

        System.out.println("What is the source file?");
        String sourceFile = input.nextLine();
        Path path = Path.of(sourceFile);

        System.out.println("What is the destination file?");
        String destFile = input.nextLine();

        try(Scanner sourceScanner = new Scanner(path)) {
            try (PrintWriter destWriter = new PrintWriter(destFile)) {

                while (sourceScanner.hasNextLine()) {
                    String line = sourceScanner.nextLine();
                    String newLine = line;
                    if (line.contains(searchWord)) {
                        newLine = line.replaceAll(searchWord, replacementWord);
                    }
                    destWriter.println(newLine);

                }

            } catch (FileNotFoundException e) {
                System.out.println("Output file couldn't be written to.");
            }
        } catch (IOException e) {
            System.out.println("Couldn't read from source file.");
        }

    }

}
