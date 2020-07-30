using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingExercise
{
    public class CustomSort : ISort
    {
        /// <summary>
        /// Sort a string using the custom sort
        /// </summary>
        /// <param name="textToSort"></param>
        /// <returns>A sorted string</returns>
        public SortResult Sort(string textToSort)
        {
            SortResult sortResult = new SortResult();

            if (string.IsNullOrEmpty(textToSort))
            {
                sortResult.Success = false;
                sortResult.ErrorMessage = "Null or empty string passed in";

                return sortResult;
            }

            textToSort = PrepareTextToSort(textToSort);

            string sortedText = PerformSort(textToSort);

            sortResult.Success = true;
            sortResult.SortedString = sortedText;

            return sortResult;
        }

        /// <summary>
        /// Performs the actual sort with the following logic:
        /// Add all characters a-z into a list in alphabetical order. Iterate through string to sort (as char array)
        /// and increment each character's count every time it occurs in the master list.
        /// Append each character the number of times it occurred to a new string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Sorted string</returns>
        private string PerformSort(string input)
        {
            List<AlphabetCharacter> alphabet = AlphabetHelper.GetAlphabet();

            char[] charactersToSort = input.ToCharArray();

            foreach (char character in charactersToSort)
            {
                AlphabetCharacter characterToIncrease = alphabet.Where(x => x.Character.Equals(character)).FirstOrDefault();

                if (characterToIncrease != null)
                {
                    characterToIncrease.Count++;
                }
            }

            StringBuilder sortedText = new StringBuilder();

            alphabet.ForEach(x =>
            {
                if (x.Count > 0)
                    sortedText.Append(new string(x.Character, x.Count));
            });

            return sortedText.ToString();
        }

        /// <summary>
        /// Change text to lower case and remove any characters other than a-z
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String ready to be sorted</returns>
        private string PrepareTextToSort(string input)
        {
            string result = ChangeToLowerCase(input);

            result = RemovePunctuation(result);

            return result;
        }

        private string ChangeToLowerCase(string input)
        {
            return input.ToLower();
        }

        private string RemovePunctuation(string input)
        {
            return new string(input.Where(char.IsLetter).ToArray());
        }
    }
}
