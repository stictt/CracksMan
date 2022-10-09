using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracksMan.Infrastructure
{
    public static class ServiceRandom
    {
        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }
            if (enumerable.Count() == 0)
            {
                throw new ArgumentException("Empty collection.");
            }

            var list = enumerable as IList<T> ?? enumerable.ToList();

            var random = new Random();

            return list[random.Next(0, list.Count)];
        }
    }
}
