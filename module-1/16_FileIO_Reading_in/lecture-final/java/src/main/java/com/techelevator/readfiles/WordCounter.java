package com.techelevator.readfiles;

public class WordCounter {

    public int countWordsInLine(String line) {
        int result = 0;
        if (line.length() > 0) {
            line = line.trim();
            String[] words = line.split(" +");
            result = words.length;
        }
        return result;
    }


}
