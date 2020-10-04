using System.Collections.Generic;

namespace BilgeAdam.OOP.GenericTypes.App.Extensions
{
    public static class HashSetExtension
    {
        public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                hashSet.Add(item);
            }
        }
    }
}
