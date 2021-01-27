package com.techelevator.farm;

import java.math.BigDecimal;

public class Chicken extends Livestock {

	public Chicken() {
		super("Chicken");
	}

	@Override
	public String makeSound() {
		return "Cluck";
	}

	@Override
	public BigDecimal getPrice() {
		return new BigDecimal("20.00");
	}

	public void layEgg() {
		System.out.println("Chicken laid an egg!");
	}

}