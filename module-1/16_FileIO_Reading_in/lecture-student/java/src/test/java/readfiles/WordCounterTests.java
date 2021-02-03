package readfiles;

import com.techelevator.readfiles.WordCounter;
import org.junit.Assert;
import org.junit.Test;

public class WordCounterTests {

    @Test
    public void countWordsInLine_handles_the_obvious() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("This is a test");

        Assert.assertEquals(4, count);
    }

    @Test
    public void countWordsInLine_handles_empty_string() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("");

        Assert.assertEquals(0, count);
    }

    @Test
    public void countWordsInLine_handles_space_at_beginning() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("        this is a test");

        Assert.assertEquals(4, count);
    }

    @Test
    public void countWordsInLine_handles_space_at_end() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("this is a test        ");

        Assert.assertEquals(4, count);
    }

    @Test
    public void countWordsInLine_handles_space_in_middle() {
        WordCounter sut = new WordCounter();

        int count = sut.countWordsInLine("this   is   a   test");

        Assert.assertEquals(4, count);
    }



}
