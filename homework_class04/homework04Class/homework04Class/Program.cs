using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFromUser = Console.ReadLine();

            if(String.IsNullOrEmpty(inputFromUser) || inputFromUser == " ")
            {
                Console.WriteLine("You did not enter anything.");
                
            }
            else
            {
                FunWithStrings(inputFromUser);
            }           

            Console.ReadLine();
        }
        //My name is Aleksandar, Aleksandar Aleksandar I am from Skopje. Today is Friady.
        static void FunWithStrings(string input)
        {
            // recerse
            char[] charArray = input.ToLower().ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);
            Console.WriteLine("Reverse of the input sentence is:");
            Console.WriteLine(reverse.Trim());


            // num of vowels
            int numOfVowels = 0;
            foreach (char letter in charArray)
            {
                if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    numOfVowels += 1;
                }
            }

            Console.WriteLine($"The number of vowels in the provided string is {numOfVowels}");

            // palindrome
            if (input.ToLower() == reverse.ToLower())
            {
                Console.WriteLine($@"The string ""{input}"" is palindrome");
            }
            else
            {
                Console.WriteLine($@"The string ""{ input}"" is not palindrome");
            }

            // print the largest word
            string[] substrings = input.Split(' ', ',', '.');
            int largestWord = 0;
            string largesWordString = "";
            foreach(string word in substrings)
            {
                if(word.Length > largestWord)
                {
                    largestWord = word.Length;
                    largesWordString = word;
                }
            }
            Console.WriteLine($@"The largest word is ""{largesWordString}"" with {largestWord} letters");


            // print the smallest word
            string[] substringsS = input.Split(' ', ',', '.');
            int smallestWord = 100000;
            string smallestWordString = "";
            foreach (string word in substringsS)
            {
                if (word.Length < smallestWord)
                {
                    if (word.Length != 0)
                    {
                        smallestWord = word.Length;
                        smallestWordString = word;
                    }

                }
            }
            Console.WriteLine($@"The smallest word is ""{smallestWordString}"" with {smallestWord} letters");

            // count of words
            int counter = 0;
            foreach (string word in substringsS)
            {
                if(word.Length != 0)
                {
                    counter += 1;
                }
            }
            Console.WriteLine($"The number of words in the sentence is {counter}");


            // print the most used word
            int mostUsedNum = 0;
            string mostUsedWord = "";

            string corrected = input.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("/", "").Replace("-", "");
            string[] substringsC = corrected.Split(' ', ',', '.');
            //foreach (string a in substringsC)
            //{
            //    Console.WriteLine(a.Trim().ToLower());
            //}

            for (int i = 0; i < substringsC.Length; i++)
            {
                int numOccur = 0;
                for (int y = i; y < substringsC.Length; y++)
                {
                    if(substringsC[i].Trim().ToLower() == substringsC[y].Trim().ToLower() && substringsC[y].Length != 0 && substringsC[i].Length != 0)
                    {
                        numOccur += 1;
                    }
                }
                if (numOccur >= mostUsedNum)
                {
                    mostUsedNum = numOccur;
                    mostUsedWord = substringsC[i];
                }
            }

            Console.WriteLine($@"The most occuring word is ""{mostUsedWord}"" with occurences of {mostUsedNum} times");

            // print the most used character
            int mostUsedC = 0;
            char mostUsedChar = 's';
            for (int i = 0; i < charArray.Length; i++)
            {
                int numOccur = 0;
                for (int y = i; y < charArray.Length; y++)
                {
                    if(charArray[i] == ' ')
                    {
                        continue;
                    }
                    if (charArray[i] == charArray[y])
                    {
                        numOccur += 1;
                    }
                }
                if (numOccur >= mostUsedC)
                {
                    mostUsedC = numOccur;
                    mostUsedChar = charArray[i];
                }

            }

            Console.WriteLine($@"The most occuring character is ""{mostUsedChar}"" with occurences of {mostUsedC} times");


            Console.WriteLine("EXERCICE 2=====================");
            string sentence = "The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";

            sentence = string.Join(" ", sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(sentence);
        }
    }
}
