package com.techelevator.farm;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

public class OldMacdonald {
	public static void main(String[] args) {

		Cow daisy = new Cow();
		Chicken nugget = new Chicken();
		Alpaca peru = new Alpaca();
		Cat longfellow = new Cat();
		longfellow.setNickname("Longfellow");
		Duck firstDuck = new Duck();
		firstDuck.setNickname("Quackers");
		Singable[] singables = new Singable[] { daisy, nugget, peru, new Tractor(), longfellow, firstDuck };

		for (Singable singableThing : singables) {
			String name = singableThing.getName();
			String sound = singableThing.makeSound();
			System.out.println("Old MacDonald had a farm, ee, ay, ee, ay, oh!");
			System.out.println("And on his farm he had " + singableThing.getArticle() + " " + name + ", ee, ay, ee, ay, oh!");
			System.out.println("With a " + sound + " " + sound + " here");
			System.out.println("And a " + sound + " " + sound + " there");
			System.out.println("Here a " + sound + " there a " + sound + " everywhere a " + sound + " " + sound);
			System.out.println();
		}

		Sellable[] merchandise = new Sellable[] {daisy, nugget, peru, new Egg()};
		BigDecimal total = BigDecimal.ZERO;
		for (Sellable product : merchandise) {
			System.out.println("And you can buy that " + product.getName() + " for only $" + product.getPrice());
			total = total.add(product.getPrice());
		}
		System.out.println("Or buy the whole farm for $" + total);


		System.out.println(daisy);
		System.out.println(longfellow);



	}
}