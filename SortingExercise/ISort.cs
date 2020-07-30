using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExercise
{
    /// <summary>
    /// Interface to be implemented by all sorting algorithms
    /// </summary>
    public interface ISort
    {
        /// <summary>
        /// Sort all the characters in a string
        /// </summary>
        /// <param name="textToSort"></param>
        /// <returns>A sorted string</returns>
        SortResult Sort(string textToSort);
    }
}
