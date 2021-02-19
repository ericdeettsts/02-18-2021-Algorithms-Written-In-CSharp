using System;
using System.Collections.Generic;

namespace Find_The_Longest_Unique_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(substringUnique("this is abaacacaacda test"));
        }

        public static string substringUnique(string source)
        {
            string result = "";
            char character1 = '\0';
            char character2 = '\0';
            // C# syntax requires instantiation
            bool character1Taken = false;
            bool character2Taken = false;
            int count = 0;
            int stringLength = source.Length;

            List<string> file = new List<string>();

            int characterIndex = 0;

            // File indexer

            int currentCount = 0;
            int highestCount = 0;
            int fileIndex = 0;
            int filePointer = 0;

            // Label indexer

            int saveIndex = 0;

        Iterate:
            characterIndex = saveIndex;
            for (characterIndex = characterIndex; count < source.Length; characterIndex++)
            {
                char c = source[characterIndex];

                if (!character1Taken)
                {
                    character1 = c;
                    character1Taken = true;
                }
                else if (!character2Taken && c != character1)
                {
                    character2 = c;
                    character2Taken = true;
                    saveIndex = count + 1;
                }

                if (character1 == c || character2 == c)
                {
                    result += c;
                }

                else if (character1Taken && character2Taken)
                {
                    file.Add(result);
                    result = "";
                    character1Taken = false;
                    character2Taken = false;
                    character1 = '\0';
                    character2 = '\0';
                    goto Iterate;
                }

                if (count == stringLength - 1)
                {
                    file.Add(result);
                    break;
                }

                count++;
            }

            foreach (string s in file)
            {
                currentCount = s.Length;
                if (currentCount > highestCount)
                {
                    highestCount = currentCount;
                    filePointer = fileIndex;
                }
                if (fileIndex == file.Count - 1)
                {
                    break;
                }
                else
                {
                    fileIndex++;
                }
            }

            result = file[filePointer];

            return result;
        }
    }
}
