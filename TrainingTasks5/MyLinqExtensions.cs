using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks5
{
	public static class MyLinqExtensions
	{
		public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool isTrue, Func<T, bool> predicate)
		{
			if (isTrue)
                return source.Where(predicate);
            else
			    return source;
		}

		public static IEnumerable<T> Alternate<T>(this IEnumerable<T> source1, IEnumerable<T> source2)
		{
            using (var e1 = source1.GetEnumerator())
                using (var e2 = source2.GetEnumerator())
                    while (e1.MoveNext() && e2.MoveNext())
                    {
                        yield return e1.Current;
                        yield return e2.Current;
                    }
		}

	}
}