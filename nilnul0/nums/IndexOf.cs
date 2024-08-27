using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.s
{
	static public class IndexOfX
	{
		public static int IndexOf<T>(
			this IEnumerable<T> list, T element
			)
		{

			return IndexOf(list, x => EqualityComparer<T>.Default.Equals(x, element));

		}

		public static int IndexOf<T>(
			this IEnumerable<T> list, Predicate<T> finder
			)
		{
			///http://geekswithblogs.net/BlackRabbitCoder/archive/2011/01/06/c.net-ndash-finding-an-itemrsquos-index-in-ienumerablelttgt.aspx
			/// If you’re concerned about too many throw-away objects, you can always roll your own FindIndex() method, but for sheer simplicity and overall performance, using the ToList()/FindIndex() combo performs best on nearly all list sizes in the average and worst cases. 
			return IndexOfX.IndexOf_byToList(list, finder);

		}

		public static int IndexOf_byTakeWhile<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			// note if item not found, result is length and not -1!
			return list.TakeWhile(i => !finder(i)).Count();
		}


		public static int IndexOf_byLoop<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			int index = 0;
			foreach (var item in list)
			{
				if (finder(item))
				{
					return index;
				}

				index++;
			}

			return -1;
		}

		public static int IndexOf_byToList<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			return list.ToList().FindIndex(finder);
		}

		public static int IndexOf_bySelectIndex<T>(this IEnumerable<T> list, Predicate<T> finder)
		{
			// if you don't name the anonymous properties they are the variable names
			return list.Select((item, index) => new
			{
				item,
				index
			})
			.Where(p => finder(p.item))
			 .Select(p => p.index + 1)
			 .FirstOrDefault() - 1;
		}




	}
}
