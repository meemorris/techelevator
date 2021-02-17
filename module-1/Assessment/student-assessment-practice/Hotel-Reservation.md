# Hotel Reservation

1. Create a new class that represents a *Hotel Reservation*.
2. Add a *name*, *number of nights*, and *estimated total* attribute/property to the Hotel Reservation class:
    * `name`: indicates the name on the reservation.
    * `number of nights`: indicates how many nights the reservation is for.
    * `estimated total`: indicates the estimated total using `number of nights` times a daily rate of $59.99.
3. Create a constructor that accepts `name` and `number of nights`.
4. Instantiate an object, or objects, in `main()`/`Main()`, and use the object(s) to test your methods.
5. Create a method that calculates the actual total using two `bool`/`boolean` input parameters: `requiresCleaning` and `usedMinibar`:
    * If the minibar was used, a fee of $12.99 is added to the estimated total.
    * If the room requires cleaning, a fee of $34.99 is added to the estimated total.
    * The cleaning fee is doubled if the minibar was used.
6. Override the `toString()`/`toString()` method and have it return `"RESERVATION - {name} - {estimated total}"` where `{name}` and `{estimated total}` are placeholders for the actual values. The values from the object should be shown in the string where `{variable-name}` is indicated.
7. Implement unit tests to validate the functionality of:
    * The estimated total calculation
    * The actual total method
8. In the main program class, within the main method, read in the provided csv file `HotelInput.csv`, and use it to populate a list of *Hotel Reservation* objects.
9. Add up the estimated total for all of the hotel reservations in the list, and print it to the screen.