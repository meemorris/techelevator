package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class MaxEnd3Tests {

    @Test
    public void makeArray_returns_array_with_all_values_equal_to_last_element_when_greater_than_first() {
        //Arrange
        MaxEnd3 sut = new MaxEnd3();
        int[] numArray = { 1, 2, 3 };
        //Act
        int[] thirdIsLarger = sut.makeArray(numArray);
        //Assert
        Assert.assertEquals(thirdIsLarger, numArray);
    }

    @Test
    public void makeArray_returns_array_with_all_values_equal_to_first_element_when_greater_than_last() {
        //Arrange
        MaxEnd3 sut = new MaxEnd3();
        int[] numArray = { 11, 5, 9 };
        //Act
        int[] firstIsLarger = sut.makeArray(numArray);
        //Assert
        Assert.assertEquals(firstIsLarger, numArray);
    }

    @Test
    public void makeArray_returns_array_with_all_values_equal_to_last_element_when_greater_than_first_and_middle() {
        //Arrange
        MaxEnd3 sut = new MaxEnd3();
        int[] numArray = { 2, 11, 3 };
        //Act
        int[] lastIsLarger = sut.makeArray(numArray);
        //Assert
        Assert.assertEquals(lastIsLarger, numArray);
    }
}
