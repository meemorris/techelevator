package com.techelevator.playingcards;

public class Hand {

    private int numberOfCards;

    public void addCard(Card card) {
        numberOfCards++;
    }

    public void addCards(Card[] cards) {
        for (Card card : cards) {
            addCard(card);
        }
    }

    public int getNumberOfCards() {
        return numberOfCards;
    }

}
