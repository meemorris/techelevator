package com.techelevator;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Lecture {

	//1. returnsAnArray(5) -> {1, 2, 3, 4, 5}
	public int[] returnsAnArray(int number) {
		int[] array = new int[number];
		for (int i = 0; i < array.length; i++) {
			array[i] = i + 1;
		}
		return array;
	}

	//2. returnsAList(5) -> [1, 2, 3, 4, 5]
	public List<Integer> returnsAList(int number) {
		List<Integer> intList = new ArrayList<>();
		for (int i = 0; i < number; i++) {
			intList.add(i + 1);
		}
		return intList;
	}

	//3. returnThirdName(["Frodo","Sam","Merry","Pippin"]) -> "Merry"
	public String returnThirdName(List<String> names) {
		return names.get(2);
	}

	//4. insertAfterFirst(["Luke","Leia"], "Han") -> ["Luke", "Han", "Leia"]
	public List<String> insertAfterFirst(List<String> names, String name) {
		List<String> result = new ArrayList<>(names); //copies elements from names into result. Best practice is to not change data that is passed in.
		result.add(1, name);
		return result;
	}

	//5. onlyOneAnswer(["yes", "no", "maybe"]) -> false
	//   onlyOneAnswer(["no"]) -> true
	public boolean onlyOneAnswer(List<String> answers) {
		return answers.size() == 1;
	}

	//6. removeLastNumber([1.5, 2.2, 0.9]) -> [1.5, 2.2]
	public List<Double> removeLastNumber(List<Double> numbers) {
		List<Double> result = new ArrayList<>(numbers); //add all elements from numbers into result
		result.remove(result.size() - 1); //to get the last index removed
		return result;
	}

	//7. hasACow(["duck","cow","chicken"]) -> true
	//   hasACow(["turkey", "rooster"]) -> false
	public boolean hasACow(List<String> farmAnimals) {
		return farmAnimals.contains("cow");
	}

	//8. yourPlaceInLine(["customer","customer","you","customer"]) -> 3
	public int yourPlaceInLine(List<String> allCustomers) {
		return allCustomers.indexOf("you") + 1;
	}

	//9. trimArray({"a","b","c","d"}) -> {"b","c"}
	public String[] trimArray(String[] input) {
		List<String> fixedSizeCopy = Arrays.asList(input); //converting array to list but this is a fixed size
		List<String> copy = new ArrayList<>(fixedSizeCopy); //copying all elements into a list that is not fixed size
		//Doing it in one step: List<String> copy = new ArrayList<>(Arrays.asList(input));
		copy.remove(0); // get rid of first element
		copy.remove(copy.size() - 1); //get rid of last element
		String[] result = copy.toArray(new String[0]);//convert list to array, convention is to pass it an array of size 0
		return result;
	}

	//10. descendingOrder([3, 4, 2, 9, 4, 8]) -> [9, 8, 4, 4, 3, 2]
	public List<Integer> descendingOrder(List<Integer> numbers) {
		List<Integer> result = new ArrayList<>(numbers);
		Collections.sort(result); //puts it into ascending order
		Collections.reverse(result); //reverse it so that it is in descending order
		return result;
	}

	//11. countTrues([false,true,true,false,true]) -> 3
	public int countTrues(List<Boolean> answers) {
		int count = 0;
		for (boolean isTrue : answers) {
			if (isTrue) {
				count++;
			}
		}
		return count;
	}

	//12. incrementAll([100, 17, 33]) -> [101, 18, 34]
	public List<Integer> incrementAll(List<Integer> numbers) {
		List<Integer> result = new ArrayList<>(); //create a new list

		for (int value : numbers) { //add the elements and change the value
			result.add(value + 1);
		}

		return result;
	}

	//13. echo(["Tech","Elevator"]) -> ["Tech","Tech","Elevator","Elevator"]
	public List<String> echo(List<String> words) {
		List<String> result = new ArrayList<>();

		for (String word : words) {
			result.add(word);
			result.add(word);
		}

		return result;
	}

}
