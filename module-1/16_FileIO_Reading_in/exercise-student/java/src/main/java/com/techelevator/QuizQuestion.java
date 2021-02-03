package com.techelevator;

import java.util.ArrayList;
import java.util.List;

public class QuizQuestion {
    private String quizQuestion;
    private List<String> quizAnswers = new ArrayList<>();
    private String correctAnswer;

    public QuizQuestion() {

    }

    public void addAnswer(String answer) {
        if (answer.contains("*")) {
            answer = answer.replace("*", "");
            setCorrectAnswer(answer);
        }
        quizAnswers.add(answer);
    }

    public String getAnswer(int choice) {
        return quizAnswers.get(choice - 1);
    }

    public boolean choiceIsCorrect(int choice) {
        return getAnswer(choice).equals(getCorrectAnswer());
    }

    public String getQuizQuestion() {
        return quizQuestion;
    }

    public void setQuizQuestion(String quizQuestion) {
        this.quizQuestion = quizQuestion;
    }

    public List<String> getQuizAnswers() {
        return quizAnswers;
    }

    public String getCorrectAnswer() {
        return correctAnswer.substring(0);
    }

    public void setCorrectAnswer(String correctAnswer) {
        this.correctAnswer = correctAnswer;
    }

}
