package com.techelevator.farm;

public class Dog extends FarmAnimal{

    public Dog() {
        super("Sable");
    }

    @Override
    public String makeSound() {
        return "ruff";
    }
}
