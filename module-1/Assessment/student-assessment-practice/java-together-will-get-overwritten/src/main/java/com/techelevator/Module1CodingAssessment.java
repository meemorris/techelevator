package com.techelevator;

import java.io.File;
import java.io.FileNotFoundException;
import java.math.BigDecimal;
import java.nio.file.Path;
import java.util.Scanner;

public class Module1CodingAssessment {

	public static void main(String[] args) {
		FlowerShopOrder katiesOrder = new FlowerShopOrder("standard",0);

		//i'm expecting katies order standard 0 19.99
		System.out.println("Katies order "+katiesOrder.getBouquetType()+" "+katiesOrder.getNumRoses()+" "+katiesOrder.getSubTotal());

		katiesOrder = new FlowerShopOrder("fancy",12);

		//i'm expecting katies order standard 12 55.87
		System.out.println("Katies order "+katiesOrder.getBouquetType()+" "+katiesOrder.getNumRoses()+" "+katiesOrder.getSubTotal());

		//5.99+3.99
		BigDecimal deliveryTotal = katiesOrder.calcDeliveryTotal(true,"20000");
		System.out.println("same day delivery to 20000 is "+deliveryTotal);

		FlowerShopOrder newOrder = new FlowerShopOrder("presidents day",3);
		System.out.println(newOrder);

		/* Open and read in the csv file, create a FSO for each one and then print sum of all subTotals*/

		System.out.println("***** READ FROM FILE*****");
		BigDecimal sumOfAllSubtotals = BigDecimal.ZERO;
		//Path.of("data-files/FlowerInput.csv");
		File text = new File("data-files/FlowerInput.csv");
		Scanner fileScanner = null;
		try {
			fileScanner = new Scanner(text);
			while(fileScanner.hasNext()){
				String line = fileScanner.nextLine();
				String [] lineAr = line.split(",");
				int numRoses = Integer.parseInt(lineAr[1]);
				FlowerShopOrder order = new FlowerShopOrder(lineAr[0],numRoses);
				System.out.println(order.getBouquetType() + " "+order.getNumRoses()+ " "+order.getSubTotal());
				sumOfAllSubtotals = sumOfAllSubtotals.add(order.getSubTotal());
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}

		System.out.println("Your total of subtotals: "+sumOfAllSubtotals);
	}

}
