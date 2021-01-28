package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class NonStartTests {

    @Test
    public void getPartialString_returns_ellohere_when_given_Hello_and_There() {
        //Arrange
        NonStart sut = new NonStart();
        String expected = "ellohere";
        //Act
        String isRightString = sut.getPartialString("Hello", "There");
        //Assert
        Assert.assertEquals(expected, isRightString);
    }

    @Test
    public void getPartialString_returns_avaode_when_given_java_and_code() {
        //Arrange
        NonStart sut = new NonStart();
        String expected = "avaode";
        //Act
        String isRightString = sut.getPartialString("java", "code");
        //Assert
        Assert.assertEquals(expected, isRightString);
    }

    @Test
    public void getPartialString_returns_hotlava_when_given_shotl_and_java() {
        //Arrange
        NonStart sut = new NonStart();
        String expected = "hotlava";
        //Act
        String isRightString = sut.getPartialString("shotl", "java");
        //Assert
        Assert.assertEquals(expected, isRightString);
    }

    @Test
    public void getPartialString_returns_b_substring_if_a_is_length_0() {
        //Arrange
        NonStart sut = new NonStart();
        String expected = "here";
        //Act
        String isRightString = sut.getPartialString("", "There");
        //Assert
        Assert.assertEquals(expected, isRightString);
    }

    @Test
    public void getPartialString_returns_a_substring_if_b_is_length_0() {
        //Arrange
        NonStart sut = new NonStart();
        String expected = "here";
        //Act
        String isRightString = sut.getPartialString("There", "");
        //Assert
        Assert.assertEquals(expected, isRightString);
    }

}
