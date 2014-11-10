
using System;

namespace ChapterOneExample.UnitTests
{
    public class StringUtilities
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            if (String.IsNullOrEmpty(stringToCheck)) return -1;

            var stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];

            var ocurranceCount = 0;

            for (var characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                    ocurranceCount++;
            }

            return ocurranceCount;
        }
    }
}
