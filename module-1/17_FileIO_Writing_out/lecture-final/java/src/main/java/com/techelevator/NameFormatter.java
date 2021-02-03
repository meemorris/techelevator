package com.techelevator;

public class NameFormatter {


    public String formatName(String firstName, String lastName) throws NameFormatException {
        if (firstName.length() == 0 || lastName.length() == 0) {
            throw new NameFormatException();
        }
        return lastName + ", " + firstName;
    }

}
