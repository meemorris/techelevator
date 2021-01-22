package com.techelevator.pencil;

public class Demo {

    public static void main(String[] args) {

        WoodenPencil pencil = new WoodenPencil();
        System.out.println("Pencil length: " + pencil.getLength() + " inches");
        System.out.println("Pencil sharpness: " + pencil.getSharpness());
        System.out.println();

        pencil.sharpen();
        System.out.println("Sharpening...");
        System.out.println("Pencil length: " + pencil.getLength() + " inches");
        System.out.println("Pencil sharpness: " + pencil.getSharpness());
        System.out.println();

        pencil.write();
        System.out.println("Writing...");
        System.out.println("Pencil sharpness: " + pencil.getSharpness());
        System.out.println();

        pencil.sharpen();
        System.out.println("Sharpening...");
        System.out.println("Pencil length: " + pencil.getLength() + " inches");
        System.out.println("Pencil sharpness: " + pencil.getSharpness());
    }
}
