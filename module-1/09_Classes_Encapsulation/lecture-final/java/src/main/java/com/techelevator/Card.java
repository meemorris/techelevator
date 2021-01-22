package com.techelevator;

import java.util.HashMap;
import java.util.Map;

public class Card {

    private final String suit;
    private final String rank;
    private boolean faceUp;

    public static String shape = "Rectangle";

    public String getSuit() {
        return suit;
    }

    public String getRank() {
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
        Map<String,Integer> cardValues = new HashMap<>();
        cardValues.put("Two", 2);
        cardValues.put("Three", 3);
        cardValues.put("Four", 4);
        cardValues.put("Five", 5);
        cardValues.put("Six", 6);
        cardValues.put("Seven", 7);
        cardValues.put("Eight", 8);
        cardValues.put("Nine", 9);
        cardValues.put("Ten", 10);
        cardValues.put("Jack", 11);
        cardValues.put("Queen", 12);
        cardValues.put("King", 13);
        cardValues.put("Ace", 14);

        return cardValues.get(rank);
    }

    public Card() {
        suit = "Spades";
        rank = "Ace";
    }

    public Card(String rank, String suit) {
        this.rank = rank;
        this.suit = suit;
    }

    public void flip() {
        faceUp = !faceUp;
    }

    public boolean isHigherThan(Card otherCard) {
        return this.getValue() > otherCard.getValue();
    }




}
