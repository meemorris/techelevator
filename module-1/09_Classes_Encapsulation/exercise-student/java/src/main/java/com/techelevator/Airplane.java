package com.techelevator;

public class Airplane {
    private final String planeNumber;
    private final int totalFirstClassSeats;
    private int bookedFirstClassSeats;
    private final int totalCoachSeats;
    private int bookedCoachSeats;

    public int getAvailableFirstClassSeats() {
        return totalFirstClassSeats - bookedFirstClassSeats;

    }

    public int getAvailableCoachSeats() {
        return totalCoachSeats - bookedCoachSeats;
    }

    public String getPlaneNumber() {
        return planeNumber;
    }

    public int getTotalFirstClassSeats() {
        return totalFirstClassSeats;
    }

    public int getBookedFirstClassSeats() {
        return bookedFirstClassSeats;
    }

    public int getTotalCoachSeats() {
        return totalCoachSeats;
    }

    public int getBookedCoachSeats() {
        return bookedCoachSeats;
    }

    public Airplane(String planeNumber, int totalFirstClassSeats, int totalCoachSeats) {
        this.planeNumber = planeNumber;
        this.totalFirstClassSeats = totalFirstClassSeats;
        this.totalCoachSeats = totalCoachSeats;
    }

    public boolean reserveSeats(boolean forFirstClass, int totalNumberOfSeats) {
        boolean result = false;
        if (forFirstClass && totalNumberOfSeats < totalFirstClassSeats) {
            bookedFirstClassSeats += totalNumberOfSeats;
            result = true;
        } else if (totalNumberOfSeats < totalCoachSeats)  {
            bookedCoachSeats += totalNumberOfSeats;
            result = true;
        }
        return result;
    }

}
