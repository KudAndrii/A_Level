using System.Diagnostics;

namespace ModuleTask.Tests
{
    [TestClass]
    public class AllLogicTests
    {
        private AllLogic _allLogic;
        [TestInitialize]
        public void TestInitialize() // method executing before every test method
        {
            _allLogic = new AllLogic();
        }

        [TestCleanup]
        public void TestCleanup() // method executing after every test method
        {
            _allLogic = null;
        }

        [TestMethod]
        public void GetOddOrEvenNumbers_12345array_oddAndEvenArrays()
        {
            // arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expectedEvenArray = { 2, 4 };
            int[] expectedOddArray = { 1, 3, 5 };

            // act
            int[] actualEvenArray = _allLogic.GetOddOrEvenNumbers(array, true);
            int[] actualOddArray = _allLogic.GetOddOrEvenNumbers(array, false);

            // assert
            CollectionAssert.AreEqual(expectedEvenArray, actualEvenArray);
            CollectionAssert.AreEqual(expectedOddArray, actualOddArray);
        }

        [TestMethod]
        public void ChangeNumbersOnLetters_123array_abcArray()
        {
            // arrange
            int[] array = { 1, 2, 3 };
            char[] expected = { 'a', 'b', 'c' };

            // act
            char[] actual = _allLogic.ChangeNumbersOnLetters(array);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SomeLettersToUpper_aeidhjlmArray_AEIDHJArray()
        {
            // arrange
            char[] array = { 'a', 'e', 'i', 'd', 'h', 'j', 'l', 'm' };
            char[] expected = { 'A', 'E', 'I', 'D', 'H', 'J', 'l', 'm' };

            // act
            _allLogic.SomeLettersToUpper(ref array);

            // assert
            CollectionAssert.AreEqual(expected, array);
        }
    }
}