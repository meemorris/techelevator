package com.techelevator;

import java.util.*;

public class Demo {

    public static void main(String[] args) {

        List<Integer> numbers = new ArrayList<>();
        numbers.add(12);
        numbers.add(10);
        numbers.add(4096);
        numbers.add(10);
        numbers.add(100);
        System.out.println(numbers);

        for (int number : numbers) {
            System.out.println(number);
        }

        Set<Integer> moreNumbers = new HashSet<>();
        moreNumbers.add(12);
        moreNumbers.add(10);
        moreNumbers.add(4096);
        moreNumbers.add(10);
        moreNumbers.add(100);
        System.out.println(moreNumbers);

        for (int number : moreNumbers) {
            System.out.println(number);
        }

        Map<String,String> studentClass = new HashMap<>();
        studentClass.put("Garrett", "Java");
        studentClass.put("Megan", "Java");
        studentClass.put("Wes", ".NET");
        studentClass.put("Megan", ".NET");

        System.out.println(studentClass);





    }
}
