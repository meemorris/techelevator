package com.techelevator.exceptions;

public class Example5 {

	public static void main(String[] args) {

		/* The withdraw method can throw a checked exception (i.e. OverdraftException) so we need to catch it since
		 * the main method does not declare that it throws any exceptions. */
		double currentBalance = 250;
		double amountToWithdraw = 300;
		try {
			double newBalance = withdraw(currentBalance, amountToWithdraw);
			System.out.println("new balance is "+newBalance);
		} catch(OverdraftException e) {
			System.out.println("Unfortunately, you can't withdraw more money than you have in the bank...");
			System.out.println("The requested amount would overdraw the account by "+e.getOverdraftAmount());
		}
		
		/* if we try to call the withdraw method outside of a try/catch, it will cause a compiler error */
		//withdraw(currentBalance, amountToWithdraw);
		
	}
	
	/* OverdraftException is a "checked exception" (i.e. it is a subclass of java.lang.Exception)
	 * so we need to either catch it or declare that it is thrown.  This method declares that 
	 * it can throw an OverdraftException using the "throws" keyword */
	public static double withdraw(double currentBalance, double amountToWithdraw) throws OverdraftException {
		double newBalance;
		if(amountToWithdraw <= currentBalance) {
			newBalance = currentBalance - amountToWithdraw;
		} else {
			throw new OverdraftException("The requested withdrawal amount is greater than the current balance", Math.abs(currentBalance - amountToWithdraw));
		}
		return newBalance;		
	}

}
