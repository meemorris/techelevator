package com.techelevator.farm;

public class Cow extends FarmAnimal {

	public Cow() {
		super("Cow");
	}

	@Override
	public String makeSound() {
		return "Moo";
	}
}