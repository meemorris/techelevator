package com.techelevator.farm;

public class Chicken extends FarmAnimal {

	public Chicken() {
		super("Chicken");
	}

	@Override
	public String makeSound() {
		return "Cluck";
	}

	public void layEgg() {
		System.out.println("Chicken laid an egg!");
	}

}