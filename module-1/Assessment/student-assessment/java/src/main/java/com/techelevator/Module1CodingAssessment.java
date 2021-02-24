package com.techelevator;

import java.io.IOException;
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
		loadOrders();
		printSubtotal();
	}

	public void loadOrders() {
		Path path = Path.of("data-files/FlowerInput.csv");
		try (Scanner orderScanner = new Scanner(path)) {
			while (orderScanner.hasNextLine()) {
				String line = orderScanner.nextLine();
				String[] items = line.split(",");
				FlowerShopOrder order = new FlowerShopOrder(items[0], Integer.parseInt(items[1]));
				allOrders.add(order);
			}
		} catch (IOException e) {
			System.out.println("File does not exist");
		}
	}

	public void printSubtotal() {
		BigDecimal subtotalTotal = new BigDecimal("0.00");
		for (FlowerShopOrder order : allOrders) {
			subtotalTotal = subtotalTotal.add(order.calcSubtotal());
		}
		System.out.println("Subtotal total for all orders: $" + subtotalTotal);
	}



}
