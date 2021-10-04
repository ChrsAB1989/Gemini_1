using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */


    public class Anagram
    {

        //function to check whether two strings are anagram of each other
        public bool AreAnagrams(string word1, string word2)
        {
            //Check if string values are null
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                throw new ArgumentNullException();

            //Create an array of all characters in word1 and word2
            var charArrayWord1 = word1.ToLower().ToCharArray();
            var charArrayWord2 = word2.ToLower().ToCharArray();

            //Sort all characters in the array before comparing values.
            Array.Sort(charArrayWord1);
            Array.Sort(charArrayWord2);

            // Create new strings after sorting the array's
            var newWord1 = new String(charArrayWord1).Trim();
            var newWord2 = new String(charArrayWord2).Trim();

            //Compare new string values
            if (newWord2 == newWord1)
                return true;

            return false;
        }
    }
}
