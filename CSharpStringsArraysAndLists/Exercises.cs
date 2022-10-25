using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Exercises
    {
        // The first four exercises can be procedures if you wish
        // Please add appropriate calling code to Program.cs

        // Add tests as well as calling code for the exercises where you use functions

        // 1: Arrays
        // Create an array of doubles each of which holds three coordinates
        // Print these to the screen


        public static void Coordinates()
        { 
            double[] coordinates1 = { 1.1, 2.2, 3.3};
            Console.WriteLine(string.Join(" ", coordinates1));
        }


        // 2: Byte Arrays
        // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
        // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 

        public static string Hello()
        {
            string word = "hello";
            byte[] wordArray = Encoding.ASCII.GetBytes(word);
            return string.Join(" ", wordArray);

        }

        public static void HelloInBytes(string word)   
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"s[{i}] = '{word[i]}' ('\\u{(int)word[i]:x4}')");
            }
           
        }
            

        // 3: Temperatures
        // Populate a list of doubles to represent daily temperatures over two weeks
        // Calculate and output the min, max and average temperatures over the time period
        // Sort the list in ascending order and print it out

        public static void Temperatures()
        {
            double temp = 0;
            List<double> templist = new List<double>();
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine("Input Temperature ");
                temp = Convert.ToDouble(Console.ReadLine());
                templist.Add(temp);
            }
            templist.Sort();

            Console.WriteLine($"Max Temperature: {templist.Last()}");
            Console.WriteLine($"Min Temperature: {templist.First()}");
            Console.WriteLine($"Average Temperature: {templist.Sum()/templist.Count()}");
        }


        // 4: Students
        // Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
        // Print the names of the oldest and youngest students
        // Print out how many students were born after 2010
        // Create a new list of strings with the full names of all the students and print this out

        public static string Students()
        {
            List<(string firstname, string surname, DateTime DOB)> data = new List<(string firstname, string surname, DateTime DOB)>();
            Console.WriteLine("How many students?");
            int StudentNum = Convert.ToInt16(Console.ReadLine());
            for (var i = 0; i < StudentNum; i++)
            {
                Console.WriteLine("Input Firstname");
                string firstname = Console.ReadLine();
                Console.WriteLine("Input Surname");
                string surname = Console.ReadLine();
                Console.WriteLine("Input Date Of Birth");
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                data.Add((firstname, surname, DOB));
            }

            
            
            var Dates = data.GroupBy(DOB => DOB.Item3).ToList();

                                        

            Console.WriteLine($"OLDEST: {data.First()}");
            Console.WriteLine($"YOUNGEST: {data.Last()}");

            DateTime Date1 = new DateTime(2010, 1, 1);
            int Count = 0;
            List<string> Older = new List<string>();
            
            for (int i = 0; i < Dates.Count; i++)
            {
                if (Dates[j] >= Date1)
                {
                    Count = Count + 1;
                    Older.Add(Dates[i]);
                    
                }
            }

            Console.WriteLine(Count);
            return string.Join(" ", Older);

        }

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay noay hetay atmay.
        public static string PigLatin(string input)
        {
             
            List<string> Translated = new List<string>();

            foreach (string word in input.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string lastletters = word.Substring(1, word.Length - 1);

                if(Char.IsPunctuation(Convert.ToChar(firstLetter)))
                {
                    Translated.Add(firstLetter);
                }
                else
                {
                    Translated.Add(lastletters + firstLetter + "ay");
                }
                
            }
            return string.Join(" ", Translated);
        }

        // 6. Mexican wave
        //  1.  The input string will always be lower case but maybe empty.
        //  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
        // Example
        // Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
        public static List<string> Wave(string input)
        {
            throw new NotImplementedException();
        }

        // 7. Anagram
        // Given a word and a list of words return the number of words that are anagrams of the others
        // Anagram("star", ["rats", "arts", "arc"]) => 2
        public static int Anagram(string input, string[] possibleAnagrams)
        {
            throw new NotImplementedException();
        }

        // 8. Variable Name helper
        public enum VariableNameType
        {
            CamelCase,
            PascalCase,
            SnakeCase
        }
        // Return the string in either camelCase, PascalCase or snake_case depending on the user choice
        public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
        {
            throw new NotImplementedException();
        }

        // 9. Binary search
        // The function should take a sorted list. You can sort it in the calling code using default sort.
        // Use a binary search to find the requested value (write this yourself)
        // It should return the index of the value found or -1 if it isn't found
        public static int BinarySearch(List<decimal> values)
        {
            throw new NotImplementedException();
        }
    }
}
