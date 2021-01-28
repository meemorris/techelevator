package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class DateFashionTests {

    @Test
    public void getATable_returns_2_if_one_style_is_below_8_and_the_other_style_is_above_8() {
        //Arrange
        DateFashion sut = new DateFashion();
        //Act
        int oneIsStylin = sut.getATable(5, 10);
        //Assert
        Assert.assertEquals(2, oneIsStylin);
    }

    @Test
    public void getATable_returns_0_if_either_style_is_2_or_less() {
        //Arrange
        DateFashion sut = new DateFashion();
        //Act
        int styleLacking = sut.getATable(5, 2);
        //Assert
        Assert.assertEquals(0, styleLacking);
    }

    @Test
    public void getATable_returns_1_if_both_are_more_than_2_and_less_than_8() {
        //Arrange
        DateFashion sut = new DateFashion();
        //Act
        int meh = sut.getATable(5, 5);
        //Assert
        Assert.assertEquals(1, meh);
    }

}
