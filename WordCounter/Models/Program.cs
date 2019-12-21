using System;

namespace WordCounting
{
   public class Program
   {
       static void Main()
       {
           
           Console.WriteLine("Please enter the word you would like to search the sentence for:");
           string word = Console.ReadLine();
           Console.WriteLine("Please enter the sentence:");
           string sentence = Console.ReadLine();

           WordCounter userFind = new WordCounter(word,sentence);
           Console.WriteLine(word+" appeared "+userFind.RepeatCounter()+ " times in the sentence.");

       }
   }
}