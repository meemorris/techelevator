package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class CigarPartyTests {

    @Test
    public void haveParty_returns_false_if_number_of_cigars_is_less_than_range() {
        //Arrange
        CigarParty sut = new CigarParty(); //creating an instance of the class
        //Act
        boolean isItPartyTime = sut.haveParty(30, false); //storing the action in a variable, call the method by class.method(parameters).
        //Assert
        Assert.assertFalse(isItPartyTime);
    }

    @Test
    public void haveParty_returns_true_if_number_of_cigars_is_in_range_and_not_the_weekend() {
        //Arrange
        CigarParty sut = new CigarParty(); //creating an instance of the class
        //Act
        boolean isItPartyTime = sut.haveParty(50, false); //storing the action in a variable, call the method by class.method(parameters).
        //Assert
        Assert.assertTrue(isItPartyTime);
    }

    @Test
    public void haveParty_returns_true_if_number_of_cigars_is_above_range_and_it_is_the_weekend() {
        //Arrange
        CigarParty sut = new CigarParty(); //creating an instance of the class
        //Act
        boolean isItPartyTime = sut.haveParty(70, true); //storing the action in a variable, call the method by class.method(parameters).
        //Assert
        Assert.assertTrue(isItPartyTime);
    }
}
