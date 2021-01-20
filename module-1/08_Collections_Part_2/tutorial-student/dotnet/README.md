# Introduction to Collections (Part 2) Tutorial

In this tutorial, you'll create and use a `Dictionary` collection object from the C# language.

A `Dictionary` is a key-value pair data structure. `Dictionary`s are also called **associative arrays** because they're collections of objects that have a relation between the key and the value stored in them.

Like `List`s, the data types for the keys and values in a `Dictionary` have to be defined. The keys and values don't need to be the same data type.

To get started, open the `CollectionsPart2Tutorial.sln` solution file in Visual Studio. You'll write your code in the `Program.cs` file under the `CollectionsPart2Tutorial` project.

In `Program.cs`, you'll see some comments where you can type your code for each step.

## Step One: Declare a Dictionary

Find the first comment in `Program.cs`. You'll add your code after this line:

```csharp
// Step One: Declare a Dictionary
```

You'll create a `Dictionary` that has a `string` for the key and a `string` for the value. First, declare the variable that holds the `Dictionary`:

```csharp
Dictionary<string, string> projects
```

Here, you specify two types in the `<>`. The first is the type of the key, and the second is the type of the value. You can mix these depending what you want to do with the structure.

To continue with the theme from yesterday, you'll add the names of some famous programmers as the key and their most famous project as the value, so you'll use two `string`s to represent them.

Next, you need to create a new `Dictionary` and assign it to the variable:

```csharp
Dictionary<string, string> projects = new Dictionary<string, string>();
```

## Step Two: Add items to a Dictionary

Find the second comment in `Program.cs`. You'll add your code after this line:

```csharp
// Step Two: Add items to a Dictionary
```

Now that you have a `Dictionary` object, you can add items to it. You could use the `Add()` method of the `Dictionary`, but that comes with a risk; if you try to use the `Add()` method with a key that already exists in the `Dictionary`, an `ArgumentException` is thrown:

```csharp
projects.Add("Grace", "COBOL"); // this line is successful
projects.Add("Grace", "Invented Modern Programming Languages"); // System.ArgumentException: 'An item with the same key has already been added. Key: Grace'
```

Instead, you'll use the square bracket notation. This technique adds the key and value if the key doesn't exist, and updates the value if the key does exist.

Similar to arrays and `List`s, where you used the square brackets to specify the integer index, for `Dictionary`s you use the key of the item you want to add or update:

```csharp
projects["Ada"] = "Inventing Computer Programming";
projects["Grace"] = "COBOL";
projects["Margaret"] = "Apollo Guidance Computer";
projects["Adele"] = "Graphical User Interfaces";
```

This links the four names, or keys, to the values that describe their projects.

## Step Three: Loop through a Dictionary

Find the third comment in `Program.cs`. You'll add your code after this line:

```csharp
// Step Three: Loop through a Dictionary
```

You can print out each of the key-value pairs by looping through all the elements in the `Dictionary`.

Using a `foreach` loop, you can assign each element to a temporary `KeyValuePair<string, string>` variable, and use the `.Key` and `.Value` properties to access the key and value:

```csharp
foreach (KeyValuePair<string, string> project in projects)
{
    Console.WriteLine("The key " + project.Key + " is linked to the value " + project.Value);
}
```

> Note: Your `KeyValuePair` must have the same types as the `Dictionary` that you're looping through.

If you run your code again, you'll see this output:

```
The key Ada is linked to the value Inventing Computer Programming
The key Grace is linked to the value COBOL
The key Margaret is linked to the value Apollo Guidance Computer
The key Adele is linked to the value Graphical User Interfaces
```

> Note: Since `Dictionary` is an unordered data structure, the order of the items displayed may not be in the order shown above.

## Step Four: Remove an item from a Dictionary

For this step, you'll add your code between Steps Two and Three so you can see the difference in the loop you wrote in Step Three.

For both `List`s and `Dictionary`s, the `Remove()` method removes an item from the collection. For `List`s, you pass the list item to the `Remove()` method; for `Dictionary`s, you pass the key to the method.

Add this line above your `foreach` loop from Step Three:

```csharp
projects.Remove("Grace");
```

Notice that when you added items to the `Dictionary`, you had to provide both the key and value, but to remove an item, you only need the key.

If you run your code now, you'll notice that "Grace" and her project is no longer printed:

```
The key Ada is linked to the value Inventing Computer Programming
The key Margaret is linked to the value Apollo Guidance Computer
The key Adele is linked to the value Graphical User Interfaces
```

> Note: Since `Dictionary` is an unordered data structure, the order of the items displayed may not be in the order shown above.

## Summary

After completing this tutorial, you should understand:

- The common operations of a `Dictionary` and how to use them.
- How to use the `foreach` loop to iterate through a collection.
