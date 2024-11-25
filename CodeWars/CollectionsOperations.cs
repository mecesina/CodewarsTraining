using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject")]

namespace CodeWars
{
    internal class CollectionsOperations
    {
        //Given an array of integers, find the one that appears an odd number of times.
        //There will always be only one integer that appears an odd number of times.

        public static int Find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Where(n => n.Count() % 2 != 0).Select(n=> n.Key).First();
        }

        //Method that hides all the chars in the text except the last 4
        public static string Maskify(string cc)
        {
            char[] inputCharArr = cc.ToCharArray();

            for (int i = 0; i < inputCharArr.Length; i++)
            {

            }
            return new string(inputCharArr);
        }

        //Implement the function which takes an array containing the names of people that like an item.
        //[]                                -->  "no one likes this"
        //["Peter"]                         -->  "Peter likes this"
        //["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
        //["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
        //["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
        //Note: For 4 or more names, the number in "and 2 others" simply increases.
        public static string Likes(string[] name)
        {
            return name.Length switch
            {
                0 => "no one likes this",
                1 => $"{name[0]} likes this",
                2 => $"{name[0]} and {name[1]} like this",
                3 => $"{name[0]}, {name[1]} and {name[2]} like this",
                _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this"
            };
        }

        //The goal of this exercise is to convert a string to a new string where each character
        //in the new string is "(" if that character appears only once in the original string,
        //or ")" if that character appears more than once in the original string.
        //Ignore capitalization when determining if a character is a duplicate.
        public static string DuplicateEncode(string word)
        {
            string wordToLower = word.ToLower();

            return new string(wordToLower.Select(c =>
            wordToLower.Count(x => x.Equals(c)) > 1 ? ')' : '('
            ).ToArray());
        }
    }
}
