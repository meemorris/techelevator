package com.techelevator.playingcards;

public enum Suit {
    HEARTS("Hearts"), SPADES("Spades"), CLUBS("Clubs"), DIAMONDS("Diamonds"); //these are the only suits that will ever be allowed to exist
    //default representation of an enum is whatever it is over here
    //naming convention for all caps since they are so similar to constants

    private String name;

    Suit(String name) { //you can't make new enums so don't use an access modifier
        this.name = name;
    }


    @Override
    public String toString() {
        return name;
    }
    //methods where you wouldn't need to have a name property
    //another option: return super.toString().toLowerCase;
    //another option: substring all but the first letter to lower case

}
