using System;

namespace SortingExercise
{
    public static class SortFactory
    {
        /// <summary>
        /// Creates an instance of a class
        /// </summary>
        /// <param name="sortType"></param>
        /// <returns></returns>
        public static ISort Build(SortTypes sortType)
        {
            switch (sortType)
            {
                case SortTypes.Custom:
                    return new CustomSort();
                default:
                    throw new Exception("Unknown sort type");
            }
        }
    }
}
