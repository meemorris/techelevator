package com.techelevator;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

import static org.junit.Assert.*;

public class LectureTest {

    Lecture sut = new Lecture();

    @Test
    public void test1_returnsAnArray() {
        assertArrayEquals(new int[] {1,2,3,4,5,6}, sut.returnsAnArray(6));
    }

    @Test
    public void test2_returnsAList() {
        Integer[] result = sut.returnsAList(6).toArray(new Integer[0]);
        assertArrayEquals(new Integer[] {1,2,3,4,5,6}, result);
    }

    @Test
    public void test3_returnThirdName() {
        List<String> names = new ArrayList<>(Arrays.asList("Larry","Moe","Curly","Joe"));
        assertEquals("Curly", sut.returnThirdName(names));
    }

    @Test
    public void test4_insertAfterFirst() {
        List<String> names = new ArrayList<>(Arrays.asList("Larry","Moe","Curly","Joe"));
        List<String> result = sut.insertAfterFirst(names, "Schemp");
        assertEquals("Schemp", result.get(1));
        assertEquals("Input array was changed!", 4, names.size());
    }

    @Test
    public void test5_onlyOneAnswer() {
        assertFalse(sut.onlyOneAnswer(new ArrayList<>(Arrays.asList("a", "b"))));
        assertTrue(sut.onlyOneAnswer(new ArrayList<>(Arrays.asList("a"))));
    }

    @Test
    public void test6_removeLastNumber() {
        List<Double> input = new ArrayList<>(Arrays.asList(.1,.2,.3));
        Double[] result = sut.removeLastNumber(input).toArray(new Double[0]);
        assertArrayEquals(new Double[] {.1,.2}, result);
    }

    @Test
    public void test7_hasACow() {
        assertTrue(sut.hasACow(new ArrayList<>(Arrays.asList("dog", "cat", "cow"))));
        assertFalse(sut.hasACow(new ArrayList<>(Arrays.asList("bird", "moose"))));
    }

    @Test
    public void test8_yourPlaceInLine() {
        assertEquals(1, sut.yourPlaceInLine(new ArrayList<>(Arrays.asList("you"))));
        assertEquals(2, sut.yourPlaceInLine(new ArrayList<>(Arrays.asList("","you"))));
        assertEquals(3, sut.yourPlaceInLine(new ArrayList<>(Arrays.asList("","","you"))));
    }

    @Test
    public void test9_trimArray() {
        String[] expected = new String[] {"2","3","4"};
        String[] actual = sut.trimArray(new String[] {"1","2","3","4","5"});
        assertArrayEquals(expected, actual);
    }

    @Test
    public void test10_descendingOrder() {
        Integer[] expected = new Integer[] {300,200,100};
        List<Integer> numbers = new ArrayList<>(Arrays.asList(200,100,300));
        Integer[] actual = sut.descendingOrder(numbers).toArray(new Integer[0]);
        assertArrayEquals(expected, actual);
    }

    @Test
    public void test11_countTrues() {
        List<Boolean> answers = new ArrayList<>(Arrays.asList(false, true, false, true));
        assertEquals(2, sut.countTrues(answers));
    }

    @Test
    public void test12_incrementAll() {
        Integer[] expected = new Integer[] {300,200,100};
        List<Integer> numbers = new ArrayList<>(Arrays.asList(299,199,99));
        Integer[] actual = sut.incrementAll(numbers).toArray(new Integer[0]);
        assertArrayEquals(expected, actual);
    }

    @Test
    public void test13_echo() {
        String[] expected = new String[] {"a","a","b","b","c","c"};
        List<String> words = new ArrayList<>(Arrays.asList("a","b","c"));
        String[] actual = sut.echo(words).toArray(new String[0]);
        assertArrayEquals(expected, actual);
    }
}
