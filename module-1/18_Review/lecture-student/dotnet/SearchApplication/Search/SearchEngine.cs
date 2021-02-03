using SearchApplication.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SearchApplication.Search
{
    public class SearchEngine
    {
        private readonly SearchDomain domain;
        private Dictionary<string, IList<WordLocation>> indexedWords = new Dictionary<string, IList<WordLocation>>();

        public SearchEngine(SearchDomain sd)
        {
            domain = sd;
        }

        public void IndexFiles()
        {
            // Step Five: Index files


        }

        public IList<string> Search(string searchString)
        {
            List<string> rankedFiles = new List<string>();
            string[] searchWords = searchString.Trim().ToLower().Split(" ");
            if (searchWords.Length == 1)
            {
                // Only one word to search, find all files that contain it
                HashSet<string> foundFiles = new HashSet<string>();
                string wordToFind = searchWords[0];
                if (indexedWords.ContainsKey(wordToFind))
                {
                    foreach (WordLocation wl in indexedWords[wordToFind])
                    {
                        foundFiles.Add(domain.Files[wl.FileId]);
                    }
                }
                rankedFiles = new List<string>(foundFiles);
            }
            else
            {
                // Multiple words to search,
                //   start by getting the distances of the first two words.
                IList<WordDistance> distances = GetDistances(searchWords[0], searchWords[1]);
                if (distances.Count > 0)
                {
                    for (int currentWordIndex = 1; currentWordIndex < searchWords.Length - 1; currentWordIndex++)
                    {
                        IList<WordDistance> nextDistances = GetDistances(searchWords[currentWordIndex], searchWords[currentWordIndex + 1]);
                        if (nextDistances.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            for (int k = 0; k < nextDistances.Count; k++)
                            {
                                bool foundFileID = false;
                                int lastFoundIndex = -1;
                                for (int m = 0; m < distances.Count; m++)
                                {
                                    if (nextDistances[k].FileId == distances[m].FileId)
                                    {
                                        foundFileID = true;
                                        lastFoundIndex = m;
                                    }
                                }
                                if (foundFileID)
                                {
                                    distances.Insert(lastFoundIndex + 1, nextDistances[k]);
                                }
                            }
                        }
                    }
                    // All the distances have been calculated and merged,
                    //   sort them by distances. Convert to strings and let Java do the work
                    int currentFileID = -1;
                    string str = "";
                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i].FileId != currentFileID)
                        {
                            if (currentFileID != -1)
                            {
                                str += ":" + currentFileID;
                                rankedFiles.Add(str);
                            }
                            str = "" + distances[i].Distance;
                            currentFileID = distances[i].FileId;
                        }
                        else
                        {
                            str += "," + distances[i].Distance;
                        }
                    }
                    if (currentFileID != -1)
                    {
                        str += ":" + currentFileID;
                        rankedFiles.Add(str);
                    }
                    rankedFiles.Sort();
                    for (int i = 0; i < rankedFiles.Count; i++)
                    {
                        string[] parts = rankedFiles[i].Split(":");
                        if (int.TryParse(parts[1], out int fileId))
                        {
                            rankedFiles[i] = domain.Files[fileId];
                        }
                    }
                }
            }
		    return rankedFiles;
	    }

        private void IndexWords(int fileId, string line)
        {
            string[] words = line.Split(" ");
            for (int location = 0; location < words.Length; location++)
            {
                // Get the word and clean it up
                string cleanedUpWord = CleanUpWord(words[location]);
                // Make sure cleaning up the word didn't make it disappear
                if (cleanedUpWord.Length > 0)
                {
                    WordLocation wl = new WordLocation(fileId, location);
                    IList<WordLocation> locations;
                    if (indexedWords.ContainsKey(cleanedUpWord))
                    {
                        // Previously found the word,
                        //   add new location to the existing list of word locations
                        locations = indexedWords[cleanedUpWord];
                        locations.Add(wl);
                    }
                    else
                    {
                        // First time word,
                        //   create new list of word locations, and add location to it
                        locations = new List<WordLocation> { wl };
                        indexedWords.Add(cleanedUpWord, locations);
                    }
                }
            }
        }

        private IList<WordDistance> GetDistances(string word, string nextWord)
        {
            IList<WordDistance> distances = new List<WordDistance>();
            if (indexedWords.ContainsKey(word) && indexedWords.ContainsKey(nextWord))
            {
                IList<WordLocation> wordLocations = indexedWords[word];
                IList<WordLocation> nextWordLocations = indexedWords[nextWord];

                foreach (WordLocation wl in wordLocations)
                {
                    foreach (WordLocation nextWL in nextWordLocations)
                    {
                        int fileID = wl.FileId;
                        if (nextWL.FileId == fileID)
                        {
                            int distance = wl.DistanceFrom(nextWL);
                            if (distance > 0)
                            {
                                distances.Add(new WordDistance(fileID, distance));
                                break;
                            }
                        }
                    }
                }

            }
            return distances;
        }

        /// <summary>
        /// Limit valid characters: only A-Z, a-z, 0-9 (implicitly trims)
        /// Lower-case, searches are case-insensitive
        /// </summary>
        /// <param name="word"></param>
        /// <returns>"cleaned-up" word</returns>
        private string CleanUpWord(string word)
        {
            StringBuilder cleanedUpWord = new StringBuilder();
            for (int k = 0; k < word.Length; k++)
            {
                char ch = word[k];
                if (((ch >= 'A') && (ch <= 'Z'))
                        || ((ch >= 'a') && (ch <= 'z'))
                        || ((ch >= '0') && (ch <= '9')))
                {
                    cleanedUpWord.Append(ch);
                }
            }
            return cleanedUpWord.ToString().ToLower();
        }

        /// <summary>
        /// Convenience method to build an easy to log/display of the list of indexed words.
        /// </summary>
        private string IndexedWordsToString()
        {
            StringBuilder indexedWordsString = new StringBuilder();
            foreach (KeyValuePair<string, IList<WordLocation>> entry in indexedWords)
            {
                indexedWordsString.Append(entry.Key + ": [");
                foreach (WordLocation location in entry.Value)
                {
                    indexedWordsString.Append(location.ToString());
                    if (location != entry.Value[entry.Value.Count - 1])
                    {
                        indexedWordsString.Append(", ");
                    }
                }
                indexedWordsString.Append("]\n");
            }
            return indexedWordsString.ToString();
        }
    }
}
