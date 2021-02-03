package com.techelevator;

public class NameFormatException extends Exception {

    @Override
    public String getMessage() {
        return "Didn't have sufficient info to create a formatted name.";
    }
}
