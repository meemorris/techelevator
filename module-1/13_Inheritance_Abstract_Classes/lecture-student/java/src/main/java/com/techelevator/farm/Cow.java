package com.techelevator.farm;

import java.math.BigDecimal;

public class Cow extends Livestock {

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