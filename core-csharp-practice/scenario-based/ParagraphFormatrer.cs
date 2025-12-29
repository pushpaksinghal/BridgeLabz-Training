using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Write a method that takes a paragraph as input and returns a corrected version with:
//● One space after punctuation,
//● Capital letter after period/question/exclamation marks,
//● Trimmed extra spaces.

//formatter->case 1 punctutaion checkmethod-> case 2 capital letter convertter afterperiodmethods-> case3 trim method->  case 4 exit

//2.Scenario: Create a program that analyzes a given paragraph of text. Implement the following
//functionalities:
//● Count the number of words in the paragraph.
//● Find and display the longest word.
//● Replace all occurrences of a specific word with another word (case-insensitive).
//● Handle edge cases like empty strings or paragraphs with only spaces
namespace BridgelabzTraining.senario_based
{
    internal class ParagraphFormatrer
    {
        static void Main(string[] args)
        {
            //creating the object of the class to access all the methods
            ParagraphFormatrer obj = new ParagraphFormatrer();
            String paragraph = Console.ReadLine();
            obj.Formatter(paragraph);
            Console.WriteLine(obj.TotalWords(paragraph));
            Console.WriteLine(obj.LongestWord(paragraph));
            Console.WriteLine(obj.ReplaceWord(paragraph, "hi", "hello"));
        }

        private void Formatter(string paragraph)
        {
            // fixingthe paragraph in the method
            while (true)
            {
                Console.WriteLine("What operations Would you like to do?");
                Console.WriteLine("1.Spaces after punctutaion");
                Console.WriteLine("2.Capital letter after periods,question marks and exclamation marks");
                Console.WriteLine("3.Trim extra Spaces");
                Console.WriteLine("4. Exit");
                // using switch case

                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        int i = 0;
                        while (i < paragraph.Length - 1)
                        {
                            if ((paragraph[i] == '.' || paragraph[i] == ',' || paragraph[i] == '?' || paragraph[i] == '!' || paragraph[i] == ':' || paragraph[i] == '-') && paragraph[i + 1] != ' ' && i + 1 < paragraph.Length)
                            {
                                paragraph = paragraph.Substring(0, i + 1) + " " + paragraph.Substring(i + 1);
                            }
                            i++;
                        }
                        Console.WriteLine(paragraph);
                        continue;
                    case 2:
                        int j = 0;
                        while (j < paragraph.Length - 1)
                        {
                            if ((paragraph[j] == '.' || paragraph[j] == '?' || paragraph[j] == '!') && j + 1 < paragraph.Length)
                            {
                                int next = j + 1;
                                while (next < paragraph.Length && paragraph[next] == ' ')
                                {
                                    next++;
                                }

                                if (next < paragraph.Length && paragraph[next] >= 'a' && paragraph[next] <= 'z')
                                {
                                    paragraph = paragraph.Substring(0, next) + char.ToUpper(paragraph[next]) + paragraph.Substring(next + 1);
                                }
                            }
                            j++;
                        }
                        Console.WriteLine(paragraph);
                        continue;
                    case 3:
                        int k = 0;
                        int count = 0;
                        while (k < paragraph.Length - 1)
                        {
                            if (paragraph[k] == ' ')
                            {
                                for (int s = k + 1; s < paragraph.Length; s++)
                                {
                                    if (paragraph[s] == ' ')
                                    {
                                        count++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (count > 0)
                                {
                                    paragraph = paragraph.Substring(0, k) + paragraph.Substring(k + count);

                                }

                            }
                            count = 0;
                            k++;
                        }
                        Console.WriteLine(paragraph);
                        continue;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                //if choice is 4 exit the method
                if (Choice == 4)
                {
                    break;
                }

            }
        }
        // count the total words
        private int TotalWords(String paragraph)
        {
            int i = 0;
            int count = 0;
            while (i < paragraph.Length)
            {
                if (paragraph[i] == ' ')
                {
                    count++;
                }
            }
            return count + 1;
        }
        // from all teh word which is the longest word
        private string LongestWord(String paragraph)
        {
            string word = "";
            string longestWord = "";
            for (int i = 0; i < paragraph.Length; i++)
            {
                if (paragraph[i] == ' ')
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                    word = "";
                }
                else word += paragraph[i];
            }
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
            return longestWord;
        }
        // replace the given word to the one giving by the user
        private string ReplaceWord(String s, String o, String n)
        {
            string r = "";
            for (int i = 0; i < s.Length;)
            {
                int j = 0;
                while (j < o.Length && i + j < s.Length && s[i + j] == o[j])
                {
                    j++;
                }
                if (j == o.Length)
                {
                    r += n;
                    i += o.Length;
                }
                else
                {
                    r += s[i];
                    i++;
                }
            }
            return r;
        }
    }


}
