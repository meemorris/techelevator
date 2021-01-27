package com.techelevator.farm;

public class Tractor implements Singable {
    @Override
    public String getName() {
        return "Tractor";
    }

    @Override
    public String makeSound() {
        return "Putt Putt";
    }

    @Override
    public String getArticle() {
        return "a";
    }
}
