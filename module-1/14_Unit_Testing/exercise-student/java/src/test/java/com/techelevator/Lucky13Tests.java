package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

import java.lang.reflect.Array;

public class Lucky13Tests {

    @Test
    public void getLucky_returns_true_if_no_1_or_3_in_array() {
        //Arrange
        Lucky13 sut = new Lucky13();
        int[] arr = { 0, 2, 4 };
        //Act
        boolean isLucky = sut.getLucky(arr);
        //Assert
        Assert.assertTrue(isLucky);
    }

    @Test
    public void getLucky_returns_false_if_1_and_3_in_array() {
        //Arrange
        Lucky13 sut = new Lucky13();
        int[] arr = { 1, 2, 3 };
        //Act
        boolean isLucky = sut.getLucky(arr);
        //Assert
        Assert.assertFalse(isLucky);
    }

    @Test
    public void getLucky_returns_false_if_1_is_in_array() {
        //Arrange
        Lucky13 sut = new Lucky13();
        int[] arr = { 1, 2, 7 };
        //Act
        boolean isLucky = sut.getLucky(arr);
        //Assert
        Assert.assertFalse(isLucky);
    }
}
