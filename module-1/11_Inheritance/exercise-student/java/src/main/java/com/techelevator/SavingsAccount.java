package com.techelevator;

public class SavingsAccount extends BankAccount{

    public SavingsAccount(String accountHolderName, String accountNumber) {
        super(accountHolderName, accountNumber);
    }

    public SavingsAccount(String accountHolderName, String accountNumber, int balance) {
        super(accountHolderName, accountNumber, balance);
    }

    @Override
    public int withdraw(int amountToWithdraw) {
        int serviceCharge = 2;
        boolean moreThanBalance = amountToWithdraw >= super.getBalance();
        int currentBalanceAfterWithdrawal = super.getBalance() - amountToWithdraw;
        if (!moreThanBalance && currentBalanceAfterWithdrawal < 150) { //put  most restrictive first
            super.withdraw(amountToWithdraw + serviceCharge);
        } else if (!moreThanBalance) {
            super.withdraw(amountToWithdraw);
        }

        return getBalance();
    }
}
