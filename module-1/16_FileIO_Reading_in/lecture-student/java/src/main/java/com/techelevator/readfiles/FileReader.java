package com.techelevator.readfiles;

import java.io.File;
import java.nio.file.Path;

public class FileReader {

    public static void main(String[] args) {
        //Two ways to represent a file:
        File myFile = new File("input.txt"); //Older style, can convert to Path with .toPath()
        Path myPath = Path.of("input.txt");    //Newer style, can convert to File with .toFile()


    }

}
