using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge005 {
    public class Intermediate {
        public static void Run() {
            //String array containing all words in dictionary
            string[] allWords = System.IO.File.ReadAllLines("C:\\Users\\Kalen\\words.txt");

            //Getting input
            Console.Write("\nEnter a word: ");
            string word = Console.ReadLine().ToLower();
            
            //Lower-casing every word in the dictionary
            for(int i = 0; i < allWords.Length; i++) {
                allWords[i] = allWords[i].ToLower();
            }


            Console.WriteLine("Here are the anagrams: \n");

            //Looping through each word in dictionary
            foreach(string currWord in allWords) {
                //If current word has the same amount of characters as words in dictionary...
                if (currWord.Length == word.Length) {
                    bool anagram = true;
                    char[] currWordCharArr = currWord.ToCharArray();

                    //Checking to see if every char in both words are identical
                    foreach(char wordChar in word.ToCharArray()) {
                        if (!currWordCharArr.Contains(wordChar)){
                            anagram = false;
                        }
                    }

                    //If anagram, write it to the console
                    if (anagram) {
                        Console.WriteLine(currWord);
                    }
                }
            }
        }
    }
}