package com.techelevator.readfiles;

import org.junit.Assert;
import org.junit.Test;

public class WordCounterTests {

    @Test
    public void countWordsInLineHandlesTheObvious() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("this is a test");

        Assert.assertEquals(4, count);
    }

    @Test
    public void countWordsInLineHandlesEmptyString() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("");

        Assert.assertEquals(0, count);
    }

    @Test
    public void countWordsInLineHandlesSpaceAtBeginning() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("    this is a test");

        Assert.assertEquals(4, count);
    }

    @Test
    public void countWordsInLineHandlesSpaceAtEnd() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("this is a test       ");

        Assert.assertEquals(4, count);
    }

    @Test
    public void countWordsInLineHandlesSpaceInMiddle() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("this    is  a     test");

        Assert.assertEquals(4, count);
    }

}
