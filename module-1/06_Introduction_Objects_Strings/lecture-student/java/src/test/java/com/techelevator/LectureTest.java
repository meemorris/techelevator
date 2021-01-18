package com.techelevator;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

public class LectureTest {

    Lecture sut = new Lecture();


    @Test
    public void test0_returnsAString() {
        assertNotNull(sut.returnsAString());
    }

    @Test
    public void test1_makeStringFromChars() {
        assertEquals("XyZ", sut.makeStringFromChars('X', 'y', 'Z'));
    }

    @Test
    public void test2_getInputLength() {
        assertEquals(3, sut.getInputLength("abc"));
    }

    @Test
    public void test3_getFirst3Letters() {
        assertEquals("abc", sut.getFirst3Letters("abcdef"));
    }

    @Test
    public void test4_getLast3Letters() {
        assertEquals("def", sut.getLast3Letters("abcdef"));
    }

    @Test
    public void test5_removeFirstLetter() {
        assertEquals("bcdef", sut.removeFirstLetter("abcdef"));
    }

    @Test
    public void test6_locationOfFirstCat() {
        assertEquals(9, sut.locationOfFirstCat("I have a catalog of cats."));
    }

    @Test
    public void test7_locationOfLastCat() {
        assertEquals(20, sut.locationOfLastCat("I have a catalog of cats."));
    }

    @Test
    public void test8_getFifthCharacter() {
        assertEquals('e', sut.getFifthCharacter("abcdef"));
    }

    @Test
    public void test9_isCareful() {
        assertEquals("No", sut.isCareful("I don't think Voldemort is real."));
        assertEquals("Yes", sut.isCareful("Beware of He Who Must Not Be Named."));

    }

    @Test
    public void test10_roundOnBothEnds() {
        assertTrue(sut.roundOnBothEnds("Ohio"));
        assertFalse(sut.roundOnBothEnds("Oklahoma"));
    }

    @Test
    public void test11_sayItLouder() {
        assertEquals("LOOK OUT!", sut.sayItLouder("Look out!"));
    }

    @Test
    public void test12_princeToFrog() {
        assertEquals("The frog sat by the pond.", sut.princeToFrog("The prince sat by the pond."));
    }

    @Test
    public void test13_isDarthVader() {
        assertTrue(sut.isDarthVader("Anakin", "Skywalker"));
    }

    @Test
    public void test14_conCat() {
        assertEquals("abcat", sut.conCat("abc", "cat"));
        assertEquals("dogcat", sut.conCat("dog", "cat"));
        assertEquals("abc", sut.conCat("abc", ""));
        assertEquals("testing", sut.conCat("test", "ting"));
    }









}
