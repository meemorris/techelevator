package com.techelevator;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;

public class BankCustomer {
    private String name;
    private String address;
    private String phoneNumber;
    private List<Accountable> accounts = new ArrayList<>();

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public Accountable[] getAccounts() {
        Accountable[] myArray = new Accountable[accounts.size()];

        for (int i = 0; i < accounts.size(); i++) {
            myArray[i] = accounts.get(i);
        }

        return myArray;
    }

    public void addAccount(Accountable newAccount) {
        accounts.add(newAccount);
    }

    public boolean isVip() {
        boolean result = false;
        int sum = 0;
        for (Accountable account : accounts) {
            sum += account.getBalance();
        }
        if (sum >= 25000) {
            result = true;
        }
        return result;
    }

}
