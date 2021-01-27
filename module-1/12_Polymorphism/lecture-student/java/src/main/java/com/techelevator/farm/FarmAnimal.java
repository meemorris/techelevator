package com.techelevator.farm;

import java.math.BigDecimal;

public class FarmAnimal implements Singable, Sellable {
	private final String name;

	public FarmAnimal(String name) {
		this.name = name;
	}

	public String getName() {
		return name;
	}

	public String makeSound() {
		return null;
	}

	public String getArticle() {
		return "a";
	}

	public BigDecimal getPrice() {
		return null; //something in a base class that you don't really have a use for
	}



}