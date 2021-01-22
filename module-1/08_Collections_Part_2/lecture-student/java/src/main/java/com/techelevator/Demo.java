package com.techelevator;

import java.util.*;

public class Demo {

    public static void main(String[] args) {

        List<Integer> numbers = new ArrayList<>(); //list

        numbers.add(12);
        numbers.add(10);
        numbers.add(4096);
        numbers.add(10);
        System.out.println(numbers);


        for (int number : numbers) {    //for each loop to loop through a list
            System.out.println(number);
        }

        Set<Integer> moreNumbers = new TreeSet<>();

        moreNumbers.add(12);
        moreNumbers.add(10);
        moreNumbers.add(4096);
        moreNumbers.add(10);
        System.out.println(moreNumbers);

        for(int number : moreNumbers) {
            System.out.println(number);
        }

        Map<String,String> studentClass = new HashMap<>();
        studentClass.put("Garrett", "Java");
        studentClass.put("Megan", "Java");
        studentClass.put("Wes", ".NET");

        System.out.println(studentClass);










    }
}
