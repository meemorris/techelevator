package com.techelevator;

public class SquareWall extends RectangleWall {

    private int sideLength;

    public int getSideLength() {
        return sideLength;
    }

    public SquareWall(String name, String color, int sideLength) {
        super(name, color);
        this.sideLength = sideLength;
    }

    @Override
    public int getArea() {
        return sideLength * sideLength;
    }

    @Override
    public String toString() {
        return super.getName() + " (" + sideLength + "x" + sideLength + ") square";
    }
}
