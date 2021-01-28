package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class Less20Tests {

    @Test
    public void isLessThanMultipleOf20_returns_true_if_positive_number_is_2_less_than_multiple_of_20() {
        //Arrange
        Less20 sut = new Less20();
        //Act
        boolean isLessBy2 = sut.isLessThanMultipleOf20(38);
        //Assert
        Assert.assertTrue(isLessBy2);
    }

    @Test
    public void isLessThanMultipleOf20_returns_true_if_positive_number_is_1_less_than_multiple_of_20() {
        //Arrange
        Less20 sut = new Less20();
        //Act
        boolean isLessBy1 = sut.isLessThanMultipleOf20(39);
        //Assert
        Assert.assertTrue(isLessBy1);
    }

    @Test
    public void isLessThanMultipleOf20_returns_false_if_positive_number_is_multiple_of_20() {
        //Arrange
        Less20 sut = new Less20();
        //Act
        boolean isMultipleOf20 = sut.isLessThanMultipleOf20(60);
        //Assert
        Assert.assertFalse(isMultipleOf20);
    }
}
