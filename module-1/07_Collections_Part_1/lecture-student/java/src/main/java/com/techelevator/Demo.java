package com.techelevator;

import java.util.ArrayList;
import java.util.List;


public class Demo {

    public static void main(String[] args) {

        int num = 5; //num would be put on the stack (int is a primitive value type). Does not have methods you can call on it.

        Integer number = 5; // number would be put on the heap (integer is a class, a reference type) Has methods you can call on it.
        //Every primitive type has a corresponding primitive wrapper, a class that can wrap that primitive type and give us some methods to work with it.
        //A list can only be made of reference types, you can't use primitive types.
        //Inside this integer object there is an int that it is keeping track of. It's been wrapped, it's in a box.

        String S = number.toString(); //s will now be "5"

        num = number; //this is unboxing, which java handles for you
        //you can put an int into a list of integers and java will automatically box it up for you

        number = 7; //takes 7, boxes it up, puts it on the heap, and puts a reference to it into number

        List<Integer> myList; //myList is null

        myList = new ArrayList<>();//having the word integer in there is not necessary to specify explicitly since it has already been specified when declaring on 25.

        List<Double> myOtherList = new ArrayList<>(); //declaring and initializing the list. Generic, you can specify a type between those ankle brackets

        myList.add(5);
        myList.add(10);
        myList.add(2);
        myList.add(99);

        for (int i = 0; i < myList.size(); i++) {
            System.out.print(myList.get(i));
        }

        /* Equivalent for each loop

        for (int value : myList) {  - Think of this as for each int value of myList
            System.out.println(value);
        }


         */


    }
}
