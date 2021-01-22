package com.techelevator.playingcards;

import java.util.Scanner;

public class DrawCards {

    public static void main(String[] args) {

        Deck myDeck = new Deck();
        myDeck.shuffle();

        System.out.print("How many cards would you like? ");
        Scanner input = new Scanner(System.in);
        int numberOfCards = Integer.parseInt(input.nextLine());

        for (int i = 0; i < numberOfCards; i++) {
            Card currentCard = myDeck.drawCard();
            currentCard.flip();
            System.out.println(currentCard.getDescription());
        }
    }
}
