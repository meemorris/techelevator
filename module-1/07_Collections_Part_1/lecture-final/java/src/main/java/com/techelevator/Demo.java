package com.techelevator;


import java.util.ArrayList;
import java.util.List;

public class Demo {

    public static void main(String[] args) {


        int num = 5;
        Integer number = 5;
        String s = number.toString(); //s will be "5"

        num = number;

        number = 7;

        List<Integer> myList; //myList is null
        myList = new ArrayList<Integer>();

        List<Double> myOtherList = new ArrayList<Double>();


        myList.add(5);
        myList.add(10);
        myList.add(2);
        myList.add(99);

        for (int i = 0; i < myList.size(); i++) {
            System.out.println(myList.get(i));
        }

        for (int value : myList) {
            System.out.println(value);
        }










    }
}
