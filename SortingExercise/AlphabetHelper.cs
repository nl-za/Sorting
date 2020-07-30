using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExercise
{
    public static class AlphabetHelper
    {
        /// <summary>
        /// Builds a list of all alphabet characters based on the ASCII values 
        /// </summary>
        /// <returns></returns>
        public static List<AlphabetCharacter> GetAlphabet()
        {
            List<AlphabetCharacter> alphabet = new List<AlphabetCharacter>();

            // ASCII code for a = 97, z = 122
            for (int i = 97; i <= 122; i++)
            {
                alphabet.Add(new AlphabetCharacter()
                {
                    Character = (char)i
                });
            }

            return alphabet;
        }
    }
}
