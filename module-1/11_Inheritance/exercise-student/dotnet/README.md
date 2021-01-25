# Inheritance

The purpose of this exercise is to practice writing code that uses the Object-Oriented Programming principle of Inheritance.

## Learning objectives

After completing this exercise, students will be able to:

* Describe the purpose and use of inheritance in an Object-Oriented Programming environment
* Define and use superclasses and subclasses in an inheritance hierarchy
* Identify superclasses and subclasses from viewing source code
* Define an IS-A relationship in reference to inheritance
* Define what overriding means in the context of inheritance
* Describe what's being inherited
* Describe how access modifiers work in an inheritance relationship
* Use super class constructors in a subclass

## Getting started

* Open the `InheritancePart1Exercise.sln` solution in Visual Studio.
* Complete the appropriate classes to satisfy the requirements.

## Tips and tricks

* A good way to determine if you're implementing inheritance correctly is to read the code or classes out loud. A child class ["is-a"][inheritance-and-an-is-a-relationship] type of its parent. For instance, a CheckingAccount "is-a" BankAccount. Is a BankCustomer a BankAccount, or does a BankCustomer have a BankAccount? Thinking about the relationships of objects in these terms helps you to quickly identify opportunities to improve your code.

## Evaluation criteria and functional requirements

* The project must not have any build errors.
* Code is presented in a clean, organized format.
* Code is appropriately encapsulated.
* Inheritance is used appropriately to avoid code duplication.
* The code meets the specifications defined below.

### Bank teller application

**Notes for all classes**

- X in the set column indicates it **should have a `set` accessor**.
- Readonly attributes do not require a `set` accessor, they will be set from the class's constructor.
- Private setters require the property to have `private set`.

#### Instructions

Create three new classes to represent a bank account, savings account, and a simple checking account. The class files have been created for you, but you have to define the proper inheritance.

#### Step One: Implement the `BankAccount` class

The `BankAccount` class represents a simple checking or savings account at a bank.

Implement the `BankAccount` class.

| Constructor                                                              | Description                                                                                                                         |
| ------------------------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------- |
| BankAccount(String accountHolderName, String accountNumber)              | A new bank account requires an account holder name and account number. The balance defaults to a 0 dollar balance if not specified. |
| BankAccount(String accountHolderName, String accountNumber, decimal balance) | A new bank account requires an account holder name and account number. The balance is initialized to the dollar balance given.      |

| Property Name     | Data Type | Get | Set     | Description                                                  |
| ----------------- | --------- | --- | ------- | ------------------------------------------------------------ |
| AccountHolderName | string    | X   | private | Returns the account holder name that the account belongs to. |
| AccountNumber     | string    | X   | X       | Returns the account number that the account belongs to.      |
| Balance           | decimal   | X   | private | Returns the balance value of the bank account in USD.        |

| Method Name                        | Return Type | Description                                                                                             |
| ---------------------------------- | ----------- | ------------------------------------------------------------------------------------------------------- |
| Deposit(decimal amountToDeposit)   | decimal     | Adds `amountToDeposit` to the current balance, and returns the new balance of the bank account.         |
| Withdraw(decimal amountToWithdraw) | decimal     | Subtracts `amountToWithdraw` from the current balance, and returns the new balance of the bank account. |

#### Step Two: Implement the `CheckingAccount` class

A `CheckingAccount` "is-a" `BankAccount`, but it also has some additional rules:

| Override Method | Description                                                                                                                                                             |
| --------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Withdraw        | If the balance falls below $0.00 and is less than -$100.00, a $10.00 overdraft fee is also charged against the account.                                                                            |
|        | Checking account can't be overdrawn by $100.00 or more. If a withdrawal request leaves the account $100 or more overdrawn, it fails and the balance remains the same.<br><br> For example, if the current balance is -$89.00, and the amount to withdraw is $10.00, the resulting balance would be -$99.00. The withdraw is permitted since the new balance is less than -$100.00. The $10.00 overdraft fee is then charge against the account, resulting in a final balance of -$109.00.<br><br>A withdraw of $11.00 in the same situation would fail because the new balance would be -$100.00 which is equal to ***but not less than*** the limit of -$100.00. |

#### Step Three: Implement the `SavingsAccount` class

A `SavingsAccount` "is-a" `BankAccount`, but it also has some additional rules:

| Override Method | Description                                                                                                                              |
| --------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| Withdraw        | If the current balance is less than $150.00 when a withdrawal is made, an additional $2.00 service charge is withdrawn from the account. |
|         | If a withdrawal is requested for more than the current balance, the withdrawal fails and balance remains the same. No fees are incurred. |


_Sample usage_
``` csharp
BankAccount checkingAccount = new CheckingAccount("Bernice", "CHK:1234");
BankAccount savingsAccount = new SavingsAccount("Bernice", "SAV:9876");

decimal amountToDeposit = 100.00M;
decimal newBalance = checkingAccount.Deposit(amountToDeposit);
```

---

[inheritance-and-an-is-a-relationship]: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance#inheritance-and-an-is-a-relationship
