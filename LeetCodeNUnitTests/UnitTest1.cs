using NUnit.Framework;

namespace LeetCodeNUnitTests
{
    
    public class Tests
    {
        private int number;
        [SetUp]
        public void Setup()
        {
            //Assert.AreEqual();
            number = 1;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(number,number*number);
        }
    }
}