using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co_.colRow_.sameType.be_
{
	
	public class Le<TCol> : 
		
		co_.colRow_.sameType.BeI<TCol>
		where TCol:OrdI1
	{
		public bool be(co_.colRow_.SameType<TCol> obj)
		{
			return nilnul.num.ord.comparer.Re.Singleton.le(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}

		static public Le<TCol> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Le<TCol>>.Instance;
			}
		}

	}


}
