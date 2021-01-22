package com.techelevator;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Deck {

    public static final String[] ALL_SUITS = {"Spades", "Diamonds", "Hearts", "Clubs"}; //chose an array since our suits are fixed
    //only when you're initializing a variable with arrays, java will let you leave out new String[]
    public static final String[] ALL_RANKS = new String[] {"Ace", "Two", "Three", "Four", "Five", "Six",
                                                        "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
    //this is static because these are true for all decks and final because once we've set it, we don't
    //want to change it. So it's a constant. NAMING_CONVENTION
    List<Card> allCards = new ArrayList<>(); //making a list of Card class

    public Deck() { //constructor for deck, will call this method when I create it
        for (String suit : ALL_SUITS) {
            for (String rank : ALL_RANKS) {
                Card newCard = new Card(rank, suit);
                allCards.add(newCard);
            }
        }
    }

    public Card drawCard() {
        Card drawnCard = allCards.remove(0); //.remove() takes card from list and returns element removed from list
        return drawnCard;
    }

    public int getCardCount() {
        return allCards.size(); //this would tell me how many cards are in a deck while cards are being drawn
    }

    public void shuffle() {
        Collections.shuffle(allCards);
    }
}
