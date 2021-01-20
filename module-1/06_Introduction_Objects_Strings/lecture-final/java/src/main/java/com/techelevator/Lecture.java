package com.techelevator;

import java.util.Locale;

public class Lecture {

	//0. Return any String
	public String returnsAString() {
		String myString = "";
		return myString;
	}

	//1. Return a String made from the characters in the input
	public String makeStringFromChars(char a, char b, char c) {
		char[] input = new char[] {a, b, c};
		String output = new String(input);
		return output;
	}

	//2. getInputLength("abc") -> 3
	public int getInputLength(String input) {
		return input.length();
	}

	//3. getFirst3Letters("abcdef") -> "abc"
	public String getFirst3Letters(String input) {
		return input.substring(0, 3);
	}

	//4. getLast3Letters("abcdef") -> "def"
	public String getLast3Letters(String input) {
		int startIndex = input.length() - 3;
		return input.substring(startIndex);
	}

	//5. removeFirstLetter("abcdef") -> "bcdef"
	public String removeFirstLetter(String input) {
		return input.substring(1);
	}

	//6. locationOfFirstCat("I have a catalog of cats.") -> 9
	public int locationOfFirstCat(String stringWithCat) {
		return stringWithCat.indexOf("cat");
	}

	//7. locationOfLastCat("I have a catalog of cats.") -> 20
	public int locationOfLastCat(String stringWithCat) {
		return stringWithCat.lastIndexOf("cat");
	}

	//8. getFifthCharacter("abcdef") -> 'e'
	public char getFifthCharacter(String input) {
		return input.charAt(4);
	}

	//9. isCareful("I don't think Voldemort is real.") -> "No"
	//   isCareful("Beware of He Who Must Not Be Named.") -> "Yes"
	public String isCareful(String statement) {
		String result = "Yes";
		if (statement.contains("Voldemort")) {
			result = "No";
		}
		return result;
	}

	//10. roundOnBothEnds("Ohio") -> true
	//    roundOnBothEnds("Oklahoma") -> false
	public boolean roundOnBothEnds(String name) {
		boolean result = false;
		boolean startsWithO = name.startsWith("O") || name.startsWith("o");
		boolean endsWithO = name.endsWith("O") || name.endsWith("o");
		if (startsWithO && endsWithO) {
			result = true;
		}
		return result;
	}

	//11. sayItLouder("Look out!") -> "LOOK OUT!"
	public String sayItLouder(String phrase) {
		return phrase.toUpperCase();
	}

	//12. princeToFrog("The prince sat by the pond.") -> "The frog sat by the pond. "
	public String princeToFrog(String story) {
		return story.replace("prince", "frog");
	}

	//13. isDarthVader("Anakin", "Skywalker") -> true
	public boolean isDarthVader(String firstName, String lastName) {
		String fullName = firstName + " " + lastName;
		return fullName.equals("Anakin Skywalker");
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
		String result = a + b;
		if (a.length() > 0 && b.length() > 0) {
			if (a.charAt(a.length() - 1) == b.charAt(0)) {
				result = a + b.substring(1);
			}
		}
		return result;
	}
}
