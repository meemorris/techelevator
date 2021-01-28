package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

public class FrontTimesTests {

    @Test
    public void generateString_returns_the_first_3_chars_of_String_twice_if_int_is_2() {
        //Arrange
        FrontTimes sut = new FrontTimes();
        //Act
        String fronting = sut.generateString("Chocolate", 2);
        //Assert
        Assert.assertEquals("ChoCho", fronting);
    }

    @Test
    public void generateString_returns_the_first_3_chars_of_String_three_times_if_int_is_3() {
        //Arrange
        FrontTimes sut = new FrontTimes();
        //Act
        String fronting = sut.generateString("Chocolate", 3);
        //Assert
        Assert.assertEquals("ChoChoCho", fronting);
    }

    @Test
    public void generateString_returns_the_first_3_chars_of_String_length_3_three_times_if_int_is_3() {
        //Arrange
        FrontTimes sut = new FrontTimes();
        //Act
        String fronting = sut.generateString("Abc", 3);
        //Assert
        Assert.assertEquals("AbcAbcAbc", fronting);
    }
}
