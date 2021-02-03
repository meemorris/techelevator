package com.techelevator.playingcards;

public class Hand {

    private int numberOfCards; //each time add a card make cardCount go up by 1
    //add another test that checks what the cards are
    //replace counter with a list
    //test that doesn't pass demonstrates what the code doesn't do right yet
    //if you can't come up with any other tests that are failing, then you know you've covered everything


    public void addCard(Card card){
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
