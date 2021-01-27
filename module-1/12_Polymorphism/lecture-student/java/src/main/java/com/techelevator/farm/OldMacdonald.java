package com.techelevator.farm;

import java.math.BigDecimal;

public class OldMacdonald {
	public static void main(String[] args) {

		Cow daisy = new Cow();
		Chicken nugget = new Chicken();
		Alpaca peru = new Alpaca();
		Tractor harry = new Tractor();
		Singable[] singables = new Singable[] { daisy, nugget, peru, harry }; //singable is something they can do. these items don't have to be part of the same tree/class.
		//they just need to be able to DO the same thing


		for (Singable singableThing : singables) { //we didn't have to touch this for loop at all, since Alpaca inherits from farm animal, it works just as well as farm animal did in the loop
			String name = singableThing.getName();
			String sound = singableThing.makeSound(); //there are three different places this could go (line 10 of three diff class files) that's polymorphism, when you have a method call and it could go three diff places
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

		Chicken chuck = new Chicken(); //you need to make sure you are calling the right class or interface
		chuck.makeSound(); //this would work for all singables
		chuck.layEgg(); //layEgg is only implemented by Chickens
		//not every singable is a chicken
		//every chicken is a FarmAnimal (you can put something smaller into something bigger but not vice versa without casting, which is not recommended)

		if (chuck instanceof Chicken) { //instanceof can be used to check
			System.out.println("Chuck is a chicken.");
		}

		if (chuck instanceof Singable) { //don't use a bunch of if else statements, you won't be using polymorphism right. You should be using methods
			//within the classes and using interfaces to group the classes and then print out everything using your getters
			System.out.println("You can sing about Chuck.");
		}

		if (chuck instanceof Tractor) { //he's not a tractor so it won't print out
			System.out.println("Chuck is a tractor");
		}




	}
}