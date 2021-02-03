package com.techelevator.exceptions;

public class OverdraftException extends Exception { //you can create as many subclasses of exception as you want. Exception is a checked exception.

	private double overdraftAmount = 0;
	
	public OverdraftException(String message, double overdraftAmount) {
		super(message);
		this.overdraftAmount = overdraftAmount;
	}

	public double getOverdraftAmount() {
		return overdraftAmount;
	}
}
