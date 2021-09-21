using System;
using System.Collections.Generic;
using System.Linq;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for list instances
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        ///     Returns an iterable list containing every item AND it's index.
        /// </summary>
        /// <param name="source">target list</param>
        /// <typeparam name="T">data type of the items in the lsit</typeparam>
        /// <returns>IEnumerable containing tuples with index and title</returns>
        public static IEnumerable<(int index, T item)> ForEachWithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((item, index) => (index, item));
        }

        /// <summary>
        ///     Checks if a list of strings contains another string and does the search using
        ///     culture invariant and case insensitive.
        /// </summary>
        /// <param name="list">target list</param>
        /// <param name="contains">string that will be checked</param>
        /// <returns>true if list contains target text. false otherwise</returns>
        public static bool ContainsCaseInsensitive(this IList<string> list, string contains)
        {
            if (list == null || !list.Any() || string.IsNullOrWhiteSpace(contains))
                return false;

            return list.Any(i => i.Equals(contains, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        ///     Replaces an item in the list
        /// </summary>
        /// <param name="list">list of T</param>
        /// <param name="oldObj">old object. to be replaced by new</param>
        /// <param name="newObj">new/updated object that will replace the old</param>
        /// <typeparam name="T">type of the objects in the list</typeparam>
        /// <returns>true if object is replaced, false if object is not found in list</returns>
        public static bool Replace<T>(this IList<T> list, T oldObj, T newObj)
        {
            var index = list.IndexOf(oldObj);

            if (index == -1) return false;

            list[index] = newObj;

            return true;
        }
    }
}