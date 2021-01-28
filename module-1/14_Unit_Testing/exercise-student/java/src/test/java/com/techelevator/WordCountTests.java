package com.techelevator;

import org.junit.Assert;
import org.junit.Test;

import java.util.HashMap;
import java.util.Map;

public class WordCountTests {

    @Test
    public void getCount_returns_Map_with_3_keys_and_3_values_from_length_4_array() {
        //Arrange
        WordCount sut = new WordCount();
        String[] testArray = { "ba", "ba", "black", "sheep" };
        Map<String,Integer> expected = new HashMap<>();
        expected.put("ba", 2);
        expected.put("black", 1);
        expected.put("sheep", 1);
        //Act
        Map<String,Integer> duplicateStrings = sut.getCount(testArray);
        //Assert
        Assert.assertEquals(expected, duplicateStrings);
    }

    @Test
    public void getCount_returns_Map_with_3_keys_and_3_values_from_length_5_array() {
        //Arrange
        WordCount sut = new WordCount();
        String[] testArray = { "a", "b", "a", "c", "b" };
        Map<String,Integer> expected = new HashMap<>();
        expected.put("a", 2);
        expected.put("b", 2);
        expected.put("c", 1);
        //Act
        Map<String,Integer> duplicateStrings = sut.getCount(testArray);
        //Assert
        Assert.assertEquals(expected, duplicateStrings);
    }

    @Test
    public void getCount_returns_empty_Map_from_empty_Array() {
        //Arrange
        WordCount sut = new WordCount();
        String[] testArray = new String[0];
        Map<String,Integer> expected = new HashMap<>();
        //Act
        Map<String,Integer> duplicateStrings = sut.getCount(testArray);
        //Assert
        Assert.assertEquals(expected, duplicateStrings);
    }
}
