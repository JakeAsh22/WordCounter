using System;

namespace WordCounting
{
    public class WordCounter
    {
        private string _word;
        private string _sentence;
        int count = 0;
        string numbers = "0123456789";
        string punt = ".,;!?;:'";
        // string characters = "abcdefghijklmnopqrstuvwxyz";

        public WordCounter(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public string RepeatCounter()
        {
            
            string lowerWord = _word.ToLower();
            string lowerSentence = _sentence.ToLower();

            for (int i =0; i<lowerSentence.Length;i++)
            {
                if (numbers.Contains(lowerSentence[i]))
                    return "Please only use letters";
                if (punt.Contains(lowerSentence[i]))
                    lowerSentence.Remove(i,1);
            }

            string[] sentenceArr = lowerSentence.Split(' ');

            foreach (string word in sentenceArr)
            {
                if (word==lowerWord)
                    count++;
            }
            
            return count.ToString();
        }
    }
}