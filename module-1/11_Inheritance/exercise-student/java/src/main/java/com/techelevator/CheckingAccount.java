package com.techelevator;

public class CheckingAccount extends BankAccount {

    public CheckingAccount(String accountHolderName, String accountNumber) {
        super(accountHolderName, accountNumber);
    }

    public CheckingAccount(String accountHolderName, String accountNumber, int balance) {
        super(accountHolderName, accountNumber, balance);
    }

    @Override
    public int withdraw(int amountToWithdraw) {

        int overdraftFee = 10;
        boolean overdrawnByMoreThan100 = super.getBalance() <= 0 && amountToWithdraw > 100;
        boolean lessThanZeroLessThanNeg100 = super.getBalance() < 0 && super.getBalance() > -100;

        if (super.getBalance() > 0) {
            super.withdraw(amountToWithdraw);
        }
        if (!overdrawnByMoreThan100 && lessThanZeroLessThanNeg100) {
            super.withdraw(overdraftFee + amountToWithdraw);
        }
        return getBalance();
    }
}
