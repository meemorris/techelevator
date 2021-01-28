package com.techelevator.playingcards;

import org.junit.Assert;
import org.junit.Test;

public class CardTest {

    //Simple tests as examples:
    @Test
    public void no_arg_constructor_makes_ace_of_spades() {
        //Arrange & Act
        Card sut = new Card(); //system under testing: sut
        //Assert
        Assert.assertEquals("Ace", sut.getRank());
        Assert.assertEquals(Suit.SPADES, sut.getSuit());
    }

    @Test
    public void constructor_makes_specified_card() {
        //Arrange & Act
        Card sut = new Card("Jack", Suit.DIAMONDS);

        //Assert
        Assert.assertEquals("Jack", sut.getRank());
        Assert.assertEquals(Suit.DIAMONDS, sut.getSuit());
    }

    @Test
    public void getDescription_returns_back_of_card_when_face_down() {
        //Arrange
        Card sut = new Card();
        sut.setFaceUp(false);
        //Act
        String description = sut.getDescription();
        //Assert
        Assert.assertEquals("Back of Card", description);
    }

    @Test
    public void getDescription_returns_rank_of_suit_when_face_up() {
        //Arrange
        Card sut = new Card();
        sut.setFaceUp(true);
        //Act
        String description = sut.getDescription();
        //Assert
        Assert.assertEquals("Ace of Spades", description);
    }

    @Test
    public void getValue_returns_correct_string() {
        //Arrange
        String rank = "Ace"; //you can check all of them with a for loop
        //Act
        int value = Card.getValueForRank(rank);
        //Assert
        Assert.assertEquals(14, value);
    }

    @Test
    public void getValueForRank_returns_zero_for_invalid_ranks() {
        Assert.assertEquals(0, Card.getValueForRank("")); //empty string
        Assert.assertEquals(0, Card.getValueForRank(null)); //null
        Assert.assertEquals(0, Card.getValueForRank("blah")); //nonsense
    }

    @Test
    public void flip_changes_faceUp_to_faceDown() {
        Card sut = new Card();
        sut.setFaceUp(true);

        sut.flip();

        Assert.assertFalse(sut.isFaceUp()); //card should not be face up anymore
    }

    @Test
    public void flip_changes_faceDown_to_faceUp() {
        Card sut = new Card();
        sut.setFaceUp(false);

        sut.flip();

        Assert.assertTrue(sut.isFaceUp()); //card should be face up
    }

    @Test
    public void isHigherThan_when_otherCard_is_greater_returns_false() {
        Card sut = new Card("2", Suit.SPADES);
        Card otherCard = new Card("10", Suit.DIAMONDS);

        Assert.assertFalse(sut.isHigherThan(otherCard));
    }

    @Test
    public void getHalfValue_returns_two_and_a_half_for_five() {
        Card sut = new Card("Five", Suit.CLUBS);

        double value = sut.getHalfValue();

        Assert.assertEquals(2.5, value, .0001); //doubles are imprecise so these two things may not match because of that imprecision
    //specify a third value, called delta of how much variability is okay
    }






}
