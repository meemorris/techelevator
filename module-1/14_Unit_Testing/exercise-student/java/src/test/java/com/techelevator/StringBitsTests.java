package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class StringBitsTests {

    @Test
    public void getBits_returns_3_letter_word_for_5_letter_word() {
        //Arrange
        StringBits sut = new StringBits();
        //Act
        String everyOtherChar = sut.getBits("Hello");
        //Assert
        Assert.assertEquals("Hlo", everyOtherChar);
    }

    @Test
    public void getBits_returns_1_letter_word_for_2_letter_word() {
        //Arrange
        StringBits sut = new StringBits();
        //Act
        String everyOtherChar = sut.getBits("Hi");
        //Assert
        Assert.assertEquals("H", everyOtherChar);
    }

    @Test
    public void getBits_returns_5_letter_word_for_9_letter_word() {
        //Arrange
        StringBits sut = new StringBits();
        //Act
        String everyOtherChar = sut.getBits("Heeololeo");
        //Assert
        Assert.assertEquals("Hello", everyOtherChar);
    }
}
