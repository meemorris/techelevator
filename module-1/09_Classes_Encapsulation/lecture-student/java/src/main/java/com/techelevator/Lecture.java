package com.techelevator;


public class Lecture {

    public static void main(String[] args) {

        Card firstCard = new Card(); //whenever you make a new instance of a class, you make it by calling the constructor of that class
        Card secondCard = new Card();
        System.out.println(firstCard); //prints out reference

        System.out.println((firstCard.getSuit())); //this is how you can access
        System.out.println((secondCard.getSuit())); //this one currently null, until you assign a value (line 13)
        System.out.println(secondCard.getRank());
        System.out.println(secondCard.isFaceUp());//if this value is empty, it will be false, since boolean is a primitive type
        System.out.println(secondCard.getDescription());
        System.out.println(secondCard.getDescription() + " has a value of " +secondCard.getValue());

        Card thirdCard = new Card("Queen", "Hearts");
        System.out.println(thirdCard.getDescription());
        thirdCard.flip();
        System.out.println(thirdCard.getDescription());
        System.out.println(thirdCard.getValue());

        if (thirdCard.isHigherThan(secondCard)) {
            System.out.println("Third Card is higher");
        } else {
            System.out.println("Second card is higher");
        }

        final int num;
        num = 10;
        //Can't change it after that

        System.out.println(Card.shape); //property of the class, not one particular card
        Card.shape = "Round"; //all cards are now round instead of rectangle

        Deck myDeck = new Deck(); //make a deck
        myDeck.shuffle();
        Card firstPick = myDeck.drawCard(); //draw a card
        firstPick.flip();
        System.out.println(firstPick.getDescription()); //print out description

        while (myDeck.getCardCount() > 0) {
            Card pick = myDeck.drawCard(); //pick a card
            pick.flip(); //flip it over
            System.out.println(pick.getDescription()); //print it out
        }

    }
}
