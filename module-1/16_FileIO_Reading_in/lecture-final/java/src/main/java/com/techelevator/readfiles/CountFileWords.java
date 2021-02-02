package com.techelevator.readfiles;

import java.io.IOException;
import java.nio.file.Path;
import java.util.Scanner;

public class CountFileWords {

    public static void main(String[] args) {

        Path path = Path.of("alice.txt");
        WordCounter wc = new WordCounter();

        int sum = 0;
        try (Scanner fileScanner = new Scanner(path)) {
            while (fileScanner.hasNextLine()) {
                String line = fileScanner.nextLine();
                int count = wc.countWordsInLine(line);
                sum += count;
            }
        } catch (IOException e) {
            System.out.println("Couldn't find file.");
        }

        System.out.println("Total words: " + sum);

    }

}
