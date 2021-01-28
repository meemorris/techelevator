package com.techelevator.playingcards;


import java.util.HashMap;
import java.util.Map;

public class Demo {

    public static void main(String[] args) {

        Card myCard = new Card("Jack", Suit.CLUBS);

        myCard.flip();

        int v = myCard.getValue();
        System.out.println(v);

        System.out.println(Card.getValueForRank("Ace"));

        char c = 'X';
        String s = String.valueOf(c); // or "" + c
        s = String.valueOf(v);

        System.out.println("This is a test".replace("test", "review"));


        Map<String,Card> dealtCards = new HashMap<>();
        Deck deck = new Deck();
        deck.shuffle();
        dealtCards.put("Vera", deck.drawCard());
        dealtCards.put("Max", deck.drawCard());
        dealtCards.put("Jason", deck.drawCard());

        for (Map.Entry<String,Card> entry : dealtCards.entrySet()) {
            Card currentCard = entry.getValue();
            currentCard.flip();
            System.out.println(entry.getKey() + " has the card " + currentCard.getDescription());

            String rank = currentCard.getRank();
            boolean hasFaceCard = rank.equals("Jack") || rank.equals("Queen") || rank.equals("King");
            if (hasFaceCard) {
                System.out.println(entry.getKey() + " has a face card!");
            }
        }


        Card newCard = new Card("Jeck", Suit.SPADES);




    }
}
