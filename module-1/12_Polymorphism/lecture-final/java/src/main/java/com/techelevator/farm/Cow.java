package com.techelevator.farm;

import java.math.BigDecimal;

public class Cow extends FarmAnimal {

	public Cow() {
		super("Cow");
	}

	@Override
	public String makeSound() {
		return "Moo";
	}

	@Override
	public BigDecimal getPrice() {
		return new BigDecimal("5000.00");
	}
}