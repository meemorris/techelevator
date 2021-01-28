using System.Collections.Generic;

namespace Exercises
{
    public class WordCount
    {
        /*
        * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
        * number of times that string appears in the array.
        *
        * ** A CLASSIC **
        *
        * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
        * GetCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
        * GetCount([]) → {}
        * GetCount(["c", "b", "a"]) → {"c": 1, "b": 1, "a": 1}
        *
        */
        public Dictionary<string, int> GetCount(string[] words)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!output.ContainsKey(word))
                {
                    output[word] = 1;
                }
                else
                {
                    output[word] = output[word] + 1;
                }
            }

            return output;
        }
    }
}
