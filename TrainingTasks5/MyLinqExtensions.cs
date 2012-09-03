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
				var newlist = new List<T>();
				
				foreach (T item in list)
				{
					if (action(item))
						newlist.Add(item);
				}
				return newlist;
			}
			return list;
		}

		public static IEnumerable<T> Alternate<T>(this IEnumerable<T> list, IEnumerable<T> list2)
		{

			var newlist = new List<T>();
			var lista = list.ToList();
			var listb = list2.ToList();

			if (lista.Count >= listb.Count)
			{
				for (var n = 0; n < lista.Count; n++)
				{
					newlist.Add(lista[n]);
					if (n < listb.Count)
					{
						newlist.Add(listb[n]);
					}
				}
			}
			else
			{
				for (var n = 0; n < listb.Count; n++)
				{
					newlist.Add(listb[n]);
					if (n < lista.Count)
					{
						newlist.Add(lista[n]);
					}
				}
			}

			//foreach (T item in GetItem(lista))
			//{
			//    newlist.Add(item);
			//    foreach (T item2 in GetItem(listb))
			//    {
			//        newlist.Add(item2);
			//    }
			//}

			return newlist;
		}

		private static IEnumerable<T> GetItem<T>(this IEnumerable<T> list)
		{
			foreach (var item in list)
			{
				yield return item;
			}
		}

	}
}