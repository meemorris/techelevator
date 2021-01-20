package com.techelevator;

public class ArrayExample {

    public static void main(String[] args) {

        int[] a = {1, 9, 100, -17};
        int[] b = a;

        a[2] = 500;

        System.out.println(b[2]);

    }
}
