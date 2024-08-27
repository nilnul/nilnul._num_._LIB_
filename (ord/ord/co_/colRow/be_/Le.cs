using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow.be_
{
	

	public class Le<TCol,TRow>
		:
		colRow.BeI< TCol,TRow>
		where TCol:OrdI1
		where TRow:OrdI1
	{
		public bool be(co_.ColRow<TCol,TRow> obj)
		{
			return nilnul.num.ord.comparer.Re.Singleton.le(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}

		static public Le<TCol,TRow> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Le<TCol,TRow>>.Instance;
			}
		}

	}


}
