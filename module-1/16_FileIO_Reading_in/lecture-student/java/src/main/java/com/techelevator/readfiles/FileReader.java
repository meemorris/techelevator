package com.techelevator.readfiles;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.List;
import java.util.Scanner;

public class FileReader {

    public static void main(String[] args) {
        //Two ways to represent a file:
        File myFile = new File("input.txt"); //Older style, can convert to Path with .toPath()
        Path myPath = Path.of("input.txt");    //Newer style, can convert to File with .toFile()

        try(Scanner fileScanner = new Scanner(myPath)) { //declare Scanner as part of the try block, Java will automatically close the resource when try block ends
          while (fileScanner.hasNextLine()) {
                String s = fileScanner.nextLine();
                System.out.println(s);
            }
        } catch (IOException e) { //IOException catches if you're trying to create a Scanner on a file that you can't find/doesn't exist
            System.out.println("Can't read from that file!");
        }



//        try {
//            List<String> allLines = Files.readAllLines(myPath); //this would be reading in the whole file at one time
//        } catch (IOException e) {
//            System.out.println("Can't read from that file!");
//        }

    }

}
