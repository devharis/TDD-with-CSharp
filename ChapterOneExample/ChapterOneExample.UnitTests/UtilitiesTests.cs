using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChapterOneExample.UnitTests
{
    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;
            StringUtilities classUnderTest = new StringUtilities();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;
            StringUtilities stringUtilities = new StringUtilities();

            int actualResult = stringUtilities.CountOccurences(stringToCheck, stringToFind);
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SearchShouldBeCaseSensitive()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;
            StringUtilities stringUtilities = new StringUtilities();

            int actualResult = stringUtilities.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            string stringToFind = "s";
            int expectedResult = -1;
            StringUtilities stringUtilities = new StringUtilities();

            int actualResult = stringUtilities.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
