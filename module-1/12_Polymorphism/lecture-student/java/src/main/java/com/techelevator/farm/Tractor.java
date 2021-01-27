package com.techelevator.farm;

public class Tractor implements Singable {

    @Override
    public String getName() {
        return "Tractor";
    }

    @Override
    public String makeSound() {
        return "Vroom";
    }

    @Override
    public String getArticle() {
        return "a";
    }
}
