package com.techelevator;

import java.math.BigDecimal;

public class BankAccount {

    private final String accountHolderName;
    private final String accountNumber;
    private BigDecimal balance;

    public String getAccountHolderName() {
        return accountHolderName;
    }

    public String getAccountNumber() {
        return accountNumber;
    }

    public int getBalance() {
        return balance.intValue();
    }

    public BankAccount(String accountHolderName, String accountNumber) {
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        balance = BigDecimal.valueOf(0);
    }

    public BankAccount(String accountHolderName, String accountNumber, int balance) {
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        this.balance= BigDecimal.valueOf(balance);
    }

    public int deposit(int amountToDeposit) {
        balance = balance.add(BigDecimal.valueOf(amountToDeposit)); //balance value is updated and has a new reference in the heap
        return balance.intValue();
    }

    public int withdraw(int amountToWithdraw) {
        balance = balance.subtract(BigDecimal.valueOf(amountToWithdraw));
        return balance.intValue();
    }





}
