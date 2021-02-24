package com.techelevator;

import java.io.IOException;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class QuizMaker {

	private static QuizMaker quizCreator = new QuizMaker();
	List<QuizQuestion> quiz = new ArrayList<>();

	public static void main(String[] args) {

		//Ask user a single question when the application starts. Don't show the asterisk in the list of choices
		Scanner input = new Scanner(System.in);

		System.out.println("Enter the fully qualified name of the file to read in for quiz questions.");
		String fileName = input.nextLine();
		Path path = Path.of(fileName);

		quizCreator.getQuestionsFromFile(path);
		quizCreator.giveQuiz(input);

	}

	public List<QuizQuestion> getQuestionsFromFile(Path path) {

		try (Scanner fileScanner = new Scanner(path)) {
			while (fileScanner.hasNextLine()) {
				String line = fileScanner.nextLine();
				String[] quizItems = line.split("\\|");
				QuizQuestion question = new QuizQuestion();
				question.setQuizQuestion(quizItems[0]); //set quiz question to first item in array
				quiz.add(question); //add question to quiz list

				for (int i = 1; i < quizItems.length; i++) {
					question.addAnswer(quizItems[i]);
				}
			}
		} catch (IOException e) {
			System.out.println("Can't read from that file!");
		}
		return quiz;
	}

	public void giveQuiz(Scanner input) {
			int rightCounter = 0;
			int wrongCounter = 0;

			for (QuizQuestion question : quiz) {
				System.out.println(question.getQuizQuestion() + "\n" + "1) " + question.getAnswer(1) + "\n" + "2) " + question.getAnswer(2)
						+ "\n" + "3) " + question.getAnswer(3) + "\n" + "4) " + question.getAnswer(4));

				System.out.print("Your answer: ");
				int userAnswer = Integer.parseInt(input.nextLine());

				if (question.choiceIsCorrect(userAnswer)) {
					System.out.println("RIGHT!");
					rightCounter++;
				} else {
					System.out.println("WRONG!");
					wrongCounter++;
				}
			}
			int totalCounter = rightCounter + wrongCounter;
			System.out.println("You got " + rightCounter + " answer(s) correct out of the " + totalCounter + " questions asked.");
		}


}