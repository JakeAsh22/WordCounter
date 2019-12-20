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
    }
}