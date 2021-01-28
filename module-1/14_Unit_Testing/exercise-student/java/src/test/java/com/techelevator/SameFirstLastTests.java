package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class SameFirstLastTests {

    @Test
    public void isItTheSame_returns_false_if_array_is_length_1_or_more_and_first_element_and_last_element_are_not_equal() {
        //Arrange
        SameFirstLast sut = new SameFirstLast();
        int[] testArray = { 1, 2, 3 };
        //Act
        boolean isSame = sut.isItTheSame(testArray);
        //Assert
        Assert.assertFalse(isSame);
    }

    @Test
    public void isItTheSame_returns_true_if_array_is_length_1_or_more_and_first_element_and_last_element_are_equal() {
        //Arrange
        SameFirstLast sut = new SameFirstLast();
        int[] testArray = { 1, 2, 3, 1 };
        //Act
        boolean isSame = sut.isItTheSame(testArray);
        //Assert
        Assert.assertTrue(isSame);
    }

    @Test
    public void isItTheSame_returns_false_if_array_is_length_0() {
        //Arrange
        SameFirstLast sut = new SameFirstLast();
        int[] testArray = new int[0];
        //Act
        boolean isSame = sut.isItTheSame(testArray);
        //Assert
        Assert.assertFalse(isSame);
    }
}
