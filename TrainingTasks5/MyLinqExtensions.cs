using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingTasks5
{
	public static class MyLinqExtensions
	{
		public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> list, bool isTrue, Func<T, bool> action)
		{
			if (isTrue)
			{
                return list.Where(action);
			}
            else
			    return list;
		}

		public static IEnumerable<T> Alternate<T>(this IEnumerable<T> list, IEnumerable<T> list2)
		{
            using (var e1 = list.GetEnumerator())
                using (var e2 = list2.GetEnumerator())
                    while (e1.MoveNext() && e2.MoveNext())
                    {
                        yield return e1.Current;
                        yield return e2.Current;
                    }
		}

	}
}