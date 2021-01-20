# Tutorial for Introduction to Classes and Encapsulation

In this tutorial, you'll build a bookstore application using some of the concepts and principles of encapsulation. You'll create two classes, `Book` and `ShoppingCart`, and use them in the application.

## Step One: Review and run the `Program` class

To get started, open the `EncapsulationTutorial` solution in Visual Studio.

Next, open `Program.cs` in the Solution Explorer. This is the starting point of the command line bookstore application.

Inside the `Main()` method, you'll see code that displays a welcome message, and some "step" comment lines:

```csharp
Console.WriteLine("Welcome to the Tech Elevator Bookstore");
Console.WriteLine();

// Step Three: Test the properties

// Step Five: Test the Book constructor

// Step Nine: Test the ShoppingCart class
```

Before moving on to step two, you'll need to run the application to make sure it works. In the "Debug" menu, choose "Start Debugging." You'll see the welcome message:

```
Welcome to the Tech Elevator Bookstore
```

The application terminates once it displays the welcome message.

## Step Two: Create the `Book` class

Now that you've reviewed the starting code, and confirmed the application runs, it's time to create your first class.

You'll start with creating a `Book` class. Each instance of the `Book` class holds the information for one book. Each book has a title, an author's name, and a price.

Remember classes combine, or *encapsulate*, *state* (properties) and *behavior* (instance methods). Instead of creating separate variables in the program to hold a book's title, author, and price, you keep all details of a book in one place—in a `Book` object.

In the Solution Explorer, right-click on the `BookStore` project and select **Add > Class**.

Next, type in `Book.cs` as the name. Then, press Enter or select "Add" to create the class.

### Create the class properties

The new `Book.cs` file opens in the editor.

Typically, you begin writing the class with the *properties*. Properties are the *state* that each `Book` object holds; for this application, that's title, author, and price.

Type the following into `Book.cs` within the `class` block to add the properties:

```csharp
namespace BookStore
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

    }
}
```

> Note: `namespace BookStore` was automatically added for you when the class file was created.

Properties are preferred over regular variables because you can control read and write access and validate values before setting a property. The reason is that properties allow you to *encapsulate* state by hiding the internal logic of the class. Properties can only be changed through methods that the class makes publicly available.

In other words, a class controls its internal state and ensures it remains consistent.

The basic `Book` class is now complete.

## Step Three: Test the `Book` properties

Test your properties by creating an instance of `Book`, setting values for `Title`, `Author`, and `Price`, and then getting and displaying the values.

Open `Program.cs`, if not already open, and enter the following code below the "Step Three" comment line as shown.

```csharp
// Step Three: Test the properties
Book twoCities = new Book();
twoCities.Title = "A Tale of Two Cities";
twoCities.Author = "Charles Dickens";
twoCities.Price = 14.99;
Console.WriteLine("Title: " + twoCities.Title + ", Author: " + twoCities.Author + ", Price: $" + twoCities.Price);
```

Once you've entered and saved the test code, re-run the application. You'll see this:

```
Welcome to the Tech Elevator Bookstore

Title: A Tale of Two Cities, Author: Charles Dickens, Price: $14.99
```

## Step Four: Add constructors to the `Book` class

Properties are great, but sometimes they can be awkward to use. It might be better to include the title, author, and price when creating an instance of a `Book` instead of creating the instance and assigning a value to each property one at a time.

Assigning a value to each property one at a time involves additional typing, which might lead to errors. For example, forgetting to set one of the properties might put the object into an *inconsistent state*.

Constructors can address these concerns. Constructors allow you to create instances of a class, reduce excess code, and help eliminate inconsistent state.

By default, when no other constructor is defined, C# automatically adds a *default constructor* to your class. Default constructors set all properties to `null` for reference types, and `0` or `false` for primitives.

Because you didn't include a constructor in the `Book` class code, the C# generated default constructor for `Book` was called when you created an instance of the class in the last step:

```csharp
Book twoCities = new Book();
```

Because all the properties were set to `null` or `0` by the default constructor, you needed to assign values to them:

```csharp
twoCities.Title = "A Tale of Two Cities";
twoCities.Author = "Charles Dickens";
twoCities.Price = 14.99;
```

Fortunately, adding a custom constructor is no more difficult than writing a method. In fact, constructors are just *special* methods.

Like methods, constructors have a name, and optionally have parameters. The differences between constructors and methods are that constructors always have the same name as their class, and they never return anything, not even `void`.

Return to `Book.cs`, and type in this new constructor:

```csharp
public Book(string title, string author, double price)
{
    Title = title;
    Author = author;
    Price = price;
}
```

Because once you provide a custom constructor, C# no longer generates the default one, and there's now only one way to create a new `Book` by giving the book a title, an author, and a price.

Consequently, you also need to provide the default constructor so the original code you wrote continues to work:

```csharp
public Book() {
}
```

## Step Five: Test the `Book` constructors

To test the `Book` constructor, create two additional instances of `Book` using the custom constructor, and display the results:

```csharp
// Step Five: Test the Book constructor
Book threeMusketeers = new Book("The Three Musketeers", "Alexandre Dumas", 12.95);

Book childhoodEnd = new Book("Childhood's End", "Arthur C. Clark", 5.99);

Console.WriteLine("Title: " + threeMusketeers.Title + ", Author: " + threeMusketeers.Author + ", Price: $" + threeMusketeers.Price);

Console.WriteLine("Title: " + childhoodEnd.Title + ", Author: " + childhoodEnd.Author + ", Price: $" + childhoodEnd.Price);
```

The following results are displayed after you've entered and saved the test code and re-run the application:

```
Welcome to the Tech Elevator Bookstore

Title: A Tale of Two Cities, Author: Charles Dickens, Price: $14.99
Title: The Three Musketeers, Author: Alexandre Dumas, Price: $12.95
Title: Childhood's End, Author: Arthur C. Clark, Price: $5.99
```

## Step Six: Create string representation of `Book` object

Classes frequently have a method which builds a string representation of the values of the properties. This can be extremely useful for testing and debugging purposes, but it's also convenient to have a way to consistently display the contents of an object.

It also helps to eliminate duplicate code by building the string representation in a single method rather than repeatedly concatenating strings as you've seen in the testing code.

Add the following method to the `Book` class:

```csharp
public string BookInfo()
{
    return "Title: " + Title + ", Author: " + Author + ", Price: $" + Price;
}
```

This completes the `Book` class. You now have a class that contains all the information needed to represent a book, has a convenient constructor, and a way to form a consistent string representation of it.

## Step Seven: Test the `BookInfo` method

Modify `Program.cs` by replacing the separate string concatenations in the three `Console.WriteLine()` lines with the following code:

```csharp
...
//Console.WriteLine("Title: " + twoCities.Title + ", Author: " + twoCities.Author + ", Price: $" + twoCities.Price);
Console.WriteLine(twoCities.BookInfo());
...
//Console.WriteLine("Title: " + threeMusketeers.Title + ", Author: " + threeMusketeers.Author + ", Price: $" + threeMusketeers.Price);
//Console.WriteLine("Title: " + childhoodEnd.Title + ", Author: " + childhoodEnd.Author + ", Price: $" + childhoodEnd.Price);
Console.WriteLine(threeMusketeers.BookInfo());
Console.WriteLine(childhoodEnd.BookInfo());
```

Save the replaced code, and re-run the application. You'll see the same output you saw when testing the constructor:

```
Welcome to the Tech Elevator Bookstore

Title: A Tale of Two Cities, Author: Charles Dickens, Price: $14.99
Title: The Three Musketeers, Author: Alexandre Dumas, Price: $12.95
Title: Childhood's End, Author: Arthur C. Clark, Price: $5.99
```

## Step Eight: Create the `ShoppingCart` class

Now, you need to work on the Shopping Cart.

The `ShoppingCart` class represents a collection of books that a customer wants to buy.

Once again, right-click on the `BookStore` project in the Solution Explorer and select **Add > Class**.

Next, type in `ShoppingCart.cs` as the name. Then, press Enter or select "Add" to create the class.

You need a single class variable, not a property, to store the book objects in the shopping cart. This is because you want to keep the value `private` since you don't want anyone to be able to directly modify the contents.

Enter the following code into `ShoppingCart.cs`:

```csharp
private List<Book> booksToBuy = new List<Book>();
```

Since there is only the one class variable, and it's automatically instantiated as an empty list of books, you don't need a custom constructor. The default constructor works fine.

However, books do need to be added to the list, so the `ShoppingCart` needs an `Add()` method. The method takes an instance of `Book` that's the book to add to the list.

Type the following code in `ShoppingCart.cs`:

```csharp
public void Add(Book newBook)
{
    booksToBuy.Add(newBook);
}
```

The `ShoppingCart` also needs to get the total price for all the books currently in the cart. This is a derived property calculated by looping through the list of books and adding each book's price to the total purchase amount.

Add the following code to create a derived property in the `ShoppingCart` class called `TotalPrice`:

```csharp
public double TotalPrice
{
    get
    {
        double total = 0;
        foreach (Book book in booksToBuy)
        {
            total += book.Price;
        }
        return total;
    }
}
```

Finally, the `ShoppingCart` needs a `PrintReceipt()` method that returns a receipt-like string representation of the shopping cart, with a listing of all the books in the cart and, at the end, the total price of everything in the cart:

```csharp
public string PrintReceipt()
{
    string receipt = "\nReceipt\n";
    foreach (Book book in booksToBuy)
    {
        receipt += book.BookInfo();
        receipt += "\n";
    }

    receipt += "\nTotal: $" + TotalPrice;

    return receipt;
}
```

> Note the use of `book.BookInfo()` to build the string representation of the `book` object, and `TotalPrice` to calculate the returned value for the receipt.

The `ShoppingCart` is complete.

Take a minute to review how the state of `ShoppingCart` is encapsulated. The class variable `booksToBuy` is declared `private` with the only way to alter it through the public `Add()` method.

The `ShoppingCart`'s state is further encapsulated with the `public` derived property, `TotalPrice`. Remember, safely encapsulating an object is not just hiding data, but also keeping implementation details firmly embedded in the class.

## Step Nine: Test the `ShoppingCart` class

To test the `ShoppingCart`, edit `Program.cs` to add the three instances of the `Book` already created to a new `ShoppingCart`, then call `PrintReceipt()` and display the returned string representation of the shopping cart:

```csharp
// Step Nine: Test the ShoppingCart class
ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.Add(twoCities);
shoppingCart.Add(threeMusketeers);
shoppingCart.Add(childhoodEnd);
Console.WriteLine(shoppingCart.PrintReceipt());
```

Re-run the application after adding and saving the test code. You'll see the following output:

```
Welcome to the Tech Elevator Bookstore

Title: A Tale of Two Cities, Author: Charles Dickens, Price: $14.99
Title: The Three Musketeers, Author: Alexandre Dumas, Price: $12.95
Title: Childhood's End, Author: Arthur C. Clark, Price: $5.99

Receipt
Title: A Tale of Two Cities, Author: Charles Dickens, Price: $14.99
Title: The Three Musketeers, Author: Alexandre Dumas, Price: $12.95
Title: Childhood's End, Author: Arthur C. Clark, Price: $5.99

Total: $33.93
```

## Summary

After completing this tutorial, you should understand:

* How to create a basic C# class.
* How to safely encapsulate state through the use of `private` and `public` access modifiers and derived properties.
* How to write constructors, and their role in furthering encapsulation.
* How to create instances of a class, and make use of their `public` methods.
