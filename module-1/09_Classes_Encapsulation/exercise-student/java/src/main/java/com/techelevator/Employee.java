package com.techelevator;

public class Employee {

    private final int employeeId;
    private final String firstName;
    private String lastName;
    private String department;
    private double annualSalary;

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    public String getLastName() {
        return lastName;
    }

    public String getDepartment() {
        return department;
    }

    public int getEmployeeId() {
        return employeeId;
    }

    public String getFirstName() {
        return firstName;
    }

    public double getAnnualSalary() {
        return annualSalary;
    }

    public String getFullName() {
        return lastName + ", " + firstName;
    }

    public Employee(int employeeId, String firstName, String lastName, double salary) {
        this.employeeId = employeeId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.annualSalary = salary;
    }

    public void raiseSalary(double percent) {
        double decimalPercent = percent / 100;
        double increaseAmount = annualSalary * decimalPercent;
        annualSalary = annualSalary + increaseAmount;
    }
}
