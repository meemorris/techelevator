package com.techelevator;

import java.util.HashMap;
import java.util.Map;

public class Card {

    private final String suit; //declaring a variable of a card that is a string called suit
    private final String rank;
    private boolean faceUp;

    public static String shape = "Rectangle"; //static variable that is true for all instances of a class
    //real world this would be private and we would make getters and setters to access it


    public String getSuit() {
        return suit;
    }

   /* public void setSuit(String suit) {
        this.suit = suit; //this.suit refers to private suit defined up top, this class' property suit, set it equal to suit which refers to this suit being passed
        //in which is the closer one. "This" refers to this class that it is a part of, this keyword is a way to differentiate it from the parameter of the method.
        //only use this keyword if which one you are using is ambiguous
    }

    */

    public String getRank() {
        return rank;
    }


    public boolean isFaceUp() {
        return faceUp;
    }

    public void setFaceUp(boolean faceUp) {
        this.faceUp = faceUp;
    }

    public String getDescription() { //derived property. Making a new property by combining ones that you already have
        String description = "Back of Card"; //defaults to false
        if (faceUp) {
            return rank + " of " + suit;
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

    public Card() { //no return type because it is making a Card instance //this is a no argument constructor (no parameters)
        suit = "Spades"; //this gives it a default value so that you eliminate the possibility of null suits and null ranks
        rank = "Ace"; //this makes it so that every card is an ace of spades until it gets set to something else
    }

    public Card(String rank, String suit) { //second constructor called card with different parameters(overloading)
        this.rank = rank;
        this.suit = suit;
    }

    public void flip() {
        faceUp = !faceUp;
    }

    public boolean isHigherThan(Card otherCard) { //the class we created is a parameter
        return this.getValue() > otherCard.getValue(); //otherCard will be whatever card we pass through
    }

}
