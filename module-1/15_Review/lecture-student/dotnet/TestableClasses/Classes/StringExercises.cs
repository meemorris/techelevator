namespace TestableClasses.Classes
{
    public class StringExercises
    {
        /*
        Given two strings, a and b, return the result of putting them together in the order abba,
        e.g. "Hi" and "Bye" returns "HiByeByeHi".
        makeAbba("Hi", "Bye") → "HiByeByeHi"
        makeAbba("Yo", "Alice") → "YoAliceAliceYo"
        makeAbba("What", "Up") → "WhatUpUpWhat"
        */
        public string MakeAbba(string a, string b)
        {
            return a + b + b + a;
        }

        /*
        Given a string, return the string made of its first two chars, so the string "Hello" yields "He". If the
        string is shorter than length 2, return whatever there is, so "X" yields "X", and the empty string ""
        yields the empty string "". Note that str.Length returns the length of a string.
        firstTwo("Hello") → "He"
        firstTwo("abcdefg") → "ab"
        firstTwo("ab") → "ab"
        */
        public string FirstTwo(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 2);
            }
        }
    }
}
