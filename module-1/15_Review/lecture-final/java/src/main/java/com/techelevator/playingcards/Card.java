package com.techelevator.playingcards;

import java.util.HashMap;
import java.util.Map;

public class Card {

    private final Suit suit;
    private final Rank rank;
    private boolean faceUp;

    public Card() {
        suit = Suit.SPADES;
        rank = Rank.ACE;
    }

    public Card(Rank rank, Suit suit) {
        this.rank = rank;
        this.suit = suit;
    }

    public Suit getSuit() {
        return suit;
    }

    public Rank getRank() {
        return rank;
    }

    public boolean isFaceUp() {
        return faceUp;
    }

    public void setFaceUp(boolean faceUp) {
        this.faceUp = faceUp;
    }

    public String getDescription() {
        String description = "Back of Card";
        if (faceUp) {
            description = rank + " of " + suit;
        }
        return description;
    }


    public int getValue() {
        return rank.getValue();
    }

    public double getHalfValue() {
        return getValue() / 2.0;
    }

    public void flip() {
        faceUp = !faceUp;
    }

    public boolean isHigherThan(Card otherCard) {
        return this.getValue() > otherCard.getValue();
    }




}
