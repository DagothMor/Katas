using LeetCode.TopInterviewQuestions.Easy.Array;
using NUnit.Framework;

namespace LeetCodeNUnitTests.TopInterviewQuestions.Easy.Array
{
    [TestFixture]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        
        public static void TestingLengthArrays(int expectedarraylength, int[] givenarray)
        {
            int actualarraylength = RemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] {1, 1, 2});
            Assert.AreEqual(expectedarraylength,actualarraylength);
        }
        public static void Testing
        [Test]
        public static void Start_Test()
        {

        }
    }
}
