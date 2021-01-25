package com.techelevator;

import java.math.BigDecimal;

public class BigDecimalDemo {

    public static void main(String[] args) {
        BigDecimal number = new BigDecimal("2.56");

        double d1 = 0.1;

        BigDecimal otherNumber = new BigDecimal("0"); //this will work but there is also a static constant for that:
        BigDecimal thirdNumber = BigDecimal.ZERO;

        BigDecimal fromDouble = BigDecimal.valueOf(d1); //you can use valueOf to make a big decimal from an int, a double, etc., putting it in a big decimal wrapper

        if (otherNumber.compareTo(thirdNumber) > 0) { //created to return a 1, -1, or 0. Always set equal to zero. i.e. this is saying is otherNumber > thirdNumber. If you think they are equal,
            //set otherNumber.compareTo(thirdNumber) == 0; compareTo returns an integer, you can make one function call and find out if it's greater than, less than, or equal to.
            System.out.println("Other number is greater than third number"); //won't print out because they are equal
        }
    }

}
