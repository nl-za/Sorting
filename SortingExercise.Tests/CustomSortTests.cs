using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text.RegularExpressions;

namespace SortingExercise.Tests
{
    [TestClass]
    public class CustomSortTests
    {
        private const string INPUT = "Contrary to popular belief, the pink unicorn flies east.";
        private const string EXPECTED_RESULT = "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy";

        /// <summary>
        /// Validates that the input string is not empty and that an error message is returned
        /// </summary>
        [TestMethod]
        public void ShouldErrorEmptyString()
        {
            CustomSort customSort = new CustomSort();
            SortResult result = customSort.Sort(string.Empty);

            Assert.IsNotNull(result);
            Assert.IsFalse(result.Success);
            Assert.IsNotNull(result.ErrorMessage);
        }

        /// <summary>
        /// Ensure an error is not returned when a non empty string is passed in
        /// </summary>
        [TestMethod]
        public void ShouldNotErrorNonEmptyString()
        {
            CustomSort customSort = new CustomSort();
            SortResult result = customSort.Sort(INPUT);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
        }

        /// <summary>
        /// When success = true, the result should never be empty
        /// </summary>
        [TestMethod]
        public void ShouldNotReturnEmptyResult()
        {
            CustomSort customSort = new CustomSort();
            SortResult result = customSort.Sort(INPUT);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsFalse(string.IsNullOrEmpty(result.SortedString));
        }

        /// <summary>
        /// Tests that the output only contains lower case characters
        /// </summary>
        [TestMethod]
        public void ShouldBeLowerCase()
        {
            CustomSort customSort = new CustomSort();
            SortResult result = customSort.Sort(INPUT);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsFalse(result.SortedString.Any(char.IsUpper));
        }

        /// <summary>
        /// Tests that the output does not contain any punctuation marks
        /// </summary>
        [TestMethod]
        public void ShouldNotContainAnyPunctuation()
        {
            CustomSort customSort = new CustomSort();
            SortResult result = customSort.Sort(INPUT);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsTrue(Regex.IsMatch(result.SortedString, @"^[a-z]+$"));
        }

        /// <summary>
        /// Make sure the output matches the expected output for the given input
        /// </summary>
        [TestMethod]
        public void ShouldMatchExpectedResult()
        {
            CustomSort customSort = new CustomSort();
            SortResult result = customSort.Sort(INPUT);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.AreEqual(result.SortedString, EXPECTED_RESULT);
        }
    }
}
