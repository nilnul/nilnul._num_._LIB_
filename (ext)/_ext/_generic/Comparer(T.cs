using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num._ext._generic
{
	public class Comparer<T,TComparer,TExt>
		: IComparer<TExt>
		where TExt :ExtI<T>
		where TComparer :IComparer<T>

	{
		private TComparer _unextComparer;

		public TComparer unextComparer
		{
			get { return _unextComparer; }
			set { _unextComparer = value; }
		}

		public Comparer(TComparer unextComparer)
		{
			_unextComparer = unextComparer;

		}

		public int Compare(TExt x, TExt y)
		{
			if (x is UnExt<T>)
			{
				if (y is UnExt<T>)
				{
					return _unextComparer.Compare((x as UnExt<T>).val, (y as UnExt<T>).val);
				}else
				if (y is Inf<T>)
				{
					return -1;

				}
				else
				{
					throw new UnexpectedTypeException();
				}
			}
			else
			{
				return -Compare(y, x);
			}

			throw new NotImplementedException();
		}

		
	}
}
