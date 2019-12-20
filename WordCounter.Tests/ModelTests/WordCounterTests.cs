using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounting;

namespace WordCountingTests
{
    [TestClass]
    public class WordCounterTest
    {

        [TestMethod]
        public void WordCounting_GetResult_NotAWord()
        {
            WordCounter count1 = new WordCounter ("1", "1111111");
            string result = count1.RepeatCounter();
            Assert.AreEqual("Please only use letters", result);

        }

        [TestMethod]
        public void WordCounting_GetResult_OneMatchingWord()
        {
            WordCounter count1 = new WordCounter ("cat", "cat");
            string result = count1.RepeatCounter();
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void WordCounting_GetResult_EveryMatchingWordInSentence()
        {
            WordCounter count1 = new WordCounter ("cat", "cat cat cat dog");
            string result = count1.RepeatCounter();
            Assert.AreEqual("3", result);
        }
        
        [TestMethod]
        public void WordCounting_GetResult_OnlyChecksForFullWords()
        {
            WordCounter count1 = new WordCounter ("cat", "I'm walking to the cathedral.");
            string result = count1.RepeatCounter();
            Assert.AreEqual("0", result);
        }
    }
}