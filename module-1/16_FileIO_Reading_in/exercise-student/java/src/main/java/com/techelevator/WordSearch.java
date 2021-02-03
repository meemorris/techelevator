package com.techelevator;

import java.io.IOException;
import java.nio.file.Path;
import java.util.Locale;
import java.util.Scanner;

public class WordSearch {

    public static void main(String[] args) {

        Scanner user = new Scanner(System.in);

        //Prompt user for filesystem path
        System.out.println("What is the fully qualified name of the file that should be searched?");
        String filePath = user.nextLine();
        Path path = Path.of(filePath);
        //Prompt user for word to search for in the file
        System.out.println("What is the search word you are looking for?");
        String searchWord = user.nextLine();
        //Prompt user if search should be case sensitive
        System.out.println("Should the search be case sensitive? (Y/N)");
        String response = user.nextLine();

        //Search through the file for occurrences of search word and output that to the console
        try(Scanner fileScanner = new Scanner(path)) {
            int count = 1;
            while (fileScanner.hasNextLine()) {
                String s = fileScanner.nextLine();
                if (response.equals("N") && s.toLowerCase().contains(searchWord.toLowerCase())) {
                        System.out.println(count + ") " + s);
                    } else if (s.contains(searchWord)) {
                    System.out.println(count + ") " + s);
                }
                count++;
            }
        } catch (IOException e) {
            System.out.println("Can't find that file!");
        }

    }

}
