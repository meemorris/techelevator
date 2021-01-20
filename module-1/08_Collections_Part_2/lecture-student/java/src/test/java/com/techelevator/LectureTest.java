package com.techelevator;

import org.junit.Test;
import static org.junit.Assert.*;

import java.util.*;

public class LectureTest {

    Lecture sut = new Lecture();

    @Test
    public void test1_removeDuplicates() {
        List<Integer> input = new ArrayList<>(Arrays.asList(1,2,2,3,3,1));
        Integer[] expected = new Integer[] {1,2,3};
        Integer[] actual = sut.removeDuplicates(input).toArray(new Integer[0]);
        assertArrayEquals(expected,actual);
    }

    @Test
    public void test2_musicalGroupNames() {
        Map<Integer,String> output = sut.musicalGroupNames();
        assertEquals("duo",output.get(2));
        assertEquals("trio",output.get(3));
        assertEquals("quartet",output.get(4));
    }

    @Test
    public void test3_coinValues() {
        Map<String,Integer> output = sut.coinValues();
        assertEquals(Integer.valueOf(1),output.get("penny"));
        assertEquals(Integer.valueOf(5),output.get("nickel"));
        assertEquals(Integer.valueOf(10),output.get("dime"));
        assertEquals(Integer.valueOf(25),output.get("quarter"));
    }

    @Test
    public void test4_describeGroup() {
        assertEquals("cello duo", sut.describeGroup(2, "cello"));
        assertEquals("banjo quartet", sut.describeGroup(4, "banjo"));
        assertEquals("drum group", sut.describeGroup(0, "drum"));
    }

    @Test
    public void test5_totalCents() {
        assertEquals(15, sut.totalCents(new String[] {"dime", "nickel"}));
        assertEquals(3, sut.totalCents(new String[] {"penny", "penny", "penny"}));
    }

    @Test
    public void test6_validCoin() {
        assertEquals("valid", sut.validCoin("quarter"));
        assertEquals("invalid", sut.validCoin("slug"));
    }

    @Test
    public void test7_stateNames() {
        Map<String,String> input = new HashMap<>();
        input.put("California","Sacramento");
        input.put("Oregon","Salem");
        List<String> output = sut.stateNames(input);
        assertTrue(output.contains("California"));
        assertTrue(output.contains("Oregon"));
        assertEquals(2, output.size());
    }

    @Test
    public void test8_availableColors() {
        Map<String,Boolean> input = new HashMap<>();
        input.put("purple", false);
        input.put("orange", true);
        input.put("silver", true);
        input.put("black", false);
        List<String> output = sut.availableColors(input);
        assertTrue(output.contains("orange"));
        assertTrue(output.contains("silver"));
        assertEquals(2, output.size());
    }

    @Test
    public void test9_addBonus() {
        Map<String,Integer> scores = new HashMap<>();
        scores.put("a", 100);
        scores.put("b", 200);
        scores.put("c", 300);
        scores.put("d", 1000);
        sut.addBonus(scores, 100);
        assertEquals(Integer.valueOf(200), scores.get("a"));
        assertEquals(Integer.valueOf(300), scores.get("b"));
        assertEquals(Integer.valueOf(400), scores.get("c"));
        assertEquals(Integer.valueOf(1100), scores.get("d"));
        assertEquals(4, scores.size());
    }

    @Test
    public void test10_mapAB() {
        assertEquals(Map.of("a","Hi", "ab","HiThere", "b","There"),
                     sut.mapAB(new HashMap<>(Map.of("a","Hi","b","There"))));
        assertEquals(Map.of("a","Hi"), sut.mapAB(Map.of("a","Hi")));
        assertEquals(Map.of("b","There"), sut.mapAB(Map.of("b","There")));
    }
}
