package com.techelevator;

public class Lecture {

	//0. Return any String
	public String returnsAString() {
		String myString = null;
		return myString;
	}

	//1. Return a String made from the characters in the input array
	public String makeStringFromChars(char a, char b, char c) {
		return null;
	}

	//2. getInputLength("abc") -> 3
	public int getInputLength(String input) {
		return -1;
	}

	//3. getFirst3Letters("abcdef") -> "abc"
	public String getFirst3Letters(String input) {
		return new String();
	}

	//4. getLast3Letters("abcdef") -> "def"
	public String getLast3Letters(String input) {
		return "";
	}

	//5. removeFirstLetter("abcdef") -> "bcdef"
	public String removeFirstLetter(String input) {
		return "";
	}

	//6. locationOfFirstCat("I have a catalog of cats.") -> 9
	public int locationOfFirstCat(String stringWithCat) {
		return Integer.MAX_VALUE;
	}

	//7. locationOfLastCat("I have a catalog of cats.") -> 20
	public int locationOfLastCat(String stringWithCat) {
		return Integer.MIN_VALUE;
	}

	//8. getFifthCharacter("abcdef") -> 'e'
	public char getFifthCharacter(String input) {
		return 'x';
	}

	//9. isCareful("I don't think Voldemort is real.") -> "No"
	//   isCareful("Beware of He Who Must Not Be Named.") -> "Yes"
	public String isCareful(String statement) {
		return "Yes";
	}

	//10. roundOnBothEnds("Ohio") -> true
	//    roundOnBothEnds("Oklahoma") -> false
	public boolean roundOnBothEnds(String name) {
		return false;
	}

	//11. sayItLouder("Look out!") -> "LOOK OUT!"
	public String sayItLouder(String phrase) {
		return phrase;
	}

	//12. princeToFrog("The prince sat by the pond.") -> "The frog sat by the pond. "
	public String princeToFrog(String story) {
		return "";
	}

	//13. isDarthVader("Anakin", "Skywalker") -> true
	public boolean isDarthVader(String firstName, String lastName) {
		String fullName = firstName + " " + lastName;
		return fullName == "Anakin Skywalker";
	}

	/*
	14. Given two strings, append them together (known as "concatenation") and return the result.
	    However, if the concatenation creates a double-char, then omit one of the chars, so "abc" and
	    "cat" yields "abcat".
		conCat("abc", "cat") → "abcat"
		conCat("dog", "cat") → "dogcat"
		conCat("abc", "") → "abc"
	*/
	public String conCat(String a, String b) {
		return a + b;
	}
}
