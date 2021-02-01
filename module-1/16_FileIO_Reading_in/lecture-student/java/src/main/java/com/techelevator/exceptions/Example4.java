package com.techelevator.exceptions;

public class Example4 {

	public static void main(String[] args) {
		
		/* we can throw our own Exceptions in response to exceptional cases 
		 * see the source code of calculateHotelRoomCharges for an example */
		int nights = -3;
		int numberOfGuests = 2;
		try {
			double amountOwed = calculateHotelRoomCharges(nights, numberOfGuests);
			System.out.println("Total owed for "+numberOfGuests+" guests for "+nights+" nights is $"+amountOwed);
		} catch(IllegalArgumentException e) {
			System.out.println(numberOfGuests+" guests for "+nights+" nights just doesn't make sense.");
			System.out.println(e.getMessage());
		}
		
	}
	
	
	/* this method does not need to declare that it throws an IllegalArgumentException because
	 * it is a subclass of RuntimeException.  These are known as "unchecked exceptions" because
	 * the compiler does not force us to catch them. */
	private static double calculateHotelRoomCharges(int nights, int numberOfGuests) {
		final double EXTRA_GUEST_CHARGE = 20;
		final double ROOM_RATE = 85;
		
		/* The throw statements below demonstrate how to throw a new Exception. */
		if(nights < 1) {
			throw new IllegalArgumentException("Minimum number of nights is 1");
		} else if(numberOfGuests < 1) {
			throw new IllegalArgumentException("Minimum number of guests is 1");
		}
		
		int numberOfExtraGuests = 0;
		if(numberOfGuests > 4) {
			numberOfExtraGuests = numberOfGuests - 4;
		}
		
		double dailyRate = ROOM_RATE + (EXTRA_GUEST_CHARGE * numberOfExtraGuests);
		return dailyRate * nights;
	}

}
