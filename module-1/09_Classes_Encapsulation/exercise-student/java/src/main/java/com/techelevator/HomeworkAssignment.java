package com.techelevator;

public class HomeworkAssignment {

    private int earnedMarks;
    private int possibleMarks;
    private String submitterName;

    public int getEarnedMarks() {
        return earnedMarks;
    }

    public void setEarnedMarks(int earnedMarks) {
        this.earnedMarks = earnedMarks;
    }

    public int getPossibleMarks() {
        return possibleMarks;
    }

    public String getSubmitterName() {
        return submitterName;
    }

    public String getLetterGrade() {
        double percent = (double) earnedMarks / possibleMarks;
        String grade = "";
        if (percent >= 0.90) {
            grade = "A";
        } else if (percent >= 0.80) {
            grade = "B";
        } else if (percent >= 0.70) {
            grade = "C";
        } else if (percent >= 0.60) {
            grade = "D";
        } else grade = "F";
        return grade;
    }

    public HomeworkAssignment(int possibleMarks, String submitterName) {
        this.possibleMarks = possibleMarks;
        this.submitterName = submitterName; //what people have to specify when they're creating an instance of the class
    }

}
