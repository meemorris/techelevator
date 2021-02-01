package com.techelevator.playingcards;

import org.junit.Assert;
import org.junit.Test;

public class CardTest {

    @Test
    public void no_arg_constructor_makes_ace_of_spades() {
        //Arrange & Act
        Card sut = new Card();

        //Assert
        Assert.assertEquals(Rank.ACE, sut.getRank());
        Assert.assertEquals(Suit.SPADES, sut.getSuit());
    }

    @Test
    public void constructor_makes_specified_card() {
        //Arrange & Act
        Card sut = new Card(Rank.JACK, Suit.DIAMONDS);

        //Assert
        Assert.assertEquals(Rank.JACK, sut.getRank());
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
    public void flip_changes_faceUp_to_faceDown() {
        Card sut = new Card();
        sut.setFaceUp(true);

        sut.flip();

        Assert.assertFalse(sut.isFaceUp());
    }

    @Test
    public void flip_changes_faceDown_to_faceUp() {
        Card sut = new Card();
        sut.setFaceUp(false);

        sut.flip();

        Assert.assertTrue(sut.isFaceUp());
    }

    @Test
    public void isHigherThan_returns_true_if_value_higher() {
        Card sut = new Card(); //Ace of Spades
        Card otherCard = new Card(Rank.JACK, Suit.DIAMONDS);

        Assert.assertTrue(sut.isHigherThan(otherCard));
    }

    @Test
    public void getHalfValue_returns_two_and_a_half_for_five() {
        Card sut = new Card(Rank.FIVE, Suit.CLUBS);

        double value = sut.getHalfValue();

        Assert.assertEquals(2.5, value, .0001);
    }

    @Test
    public void getValue_returns_expected_value_for_rank() {
        Rank[] orderedRanks = {Rank.TWO, Rank.THREE, Rank.FOUR, Rank.FIVE, Rank.SIX, Rank.SEVEN,
                               Rank.EIGHT, Rank.NINE, Rank.TEN, Rank.JACK, Rank.QUEEN, Rank.KING,
                               Rank.ACE};
        for (int i = 0; i < orderedRanks.length; i++) {
            Card sut = new Card(orderedRanks[i], Suit.HEARTS);

            Assert.assertEquals(i + 2, sut.getValue());
        }
    }



}
