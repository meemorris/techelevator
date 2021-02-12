package com.techelevator;

import java.io.IOException;
import java.io.PrintWriter;
import java.math.BigDecimal;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Module1CodingAssessment {

	private FlowerShopOrder order = new FlowerShopOrder("Roses", 12);
	public List<FlowerShopOrder> allOrders = new ArrayList<>();
	public static void main(String[] args) {
		Module1CodingAssessment app = new Module1CodingAssessment();
		app.run();
	}

	public void run() {
		order.calcSubtotal();
		order.calcDeliveryTotal(true, "25000");
		System.out.println(order.toString());
	}

	public void loadOrders() {
		Path path = Path.of("FlowerInput.csv");
		try (Scanner orderScanner = new Scanner(path)) {
			while (orderScanner.hasNextLine()) {
				String line = orderScanner.nextLine();
				String[] items = line.split(" ");
				FlowerShopOrder order = new FlowerShopOrder(items[0], Integer.parseInt(items[1]));
				order.setSubtotal(BigDecimal.valueOf(Long.parseLong(items[2]))); //not sure where the price will be
				allOrders.add(order);
			}
		} catch (IOException e) {
			System.out.println("File does not exist");
		}
	}

	public void printSubtotal() {

	}



}
