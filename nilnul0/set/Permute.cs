using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num._proc
{
	static public class PermuteX
	{
		static public IEnumerable< List<T> > Permute<T>(this HashSet<T> set ) {
			if (set.Count ==0)
			{
				yield return new List<T>();
			}
			foreach (var item in set)
			{
				var decreasedSet = new HashSet<T>(set);
				decreasedSet.Remove(item);

				foreach (var item1 in PermuteX.Permute(decreasedSet))
				{
					item1.Add(item);
					yield return item1;
				}
			}
			//throw new NotImplementedException();
		}
	}
}