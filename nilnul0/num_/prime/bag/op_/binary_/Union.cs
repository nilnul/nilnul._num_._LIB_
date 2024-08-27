using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural_.prime.bag.op_.binary_
{
	public class Union
		:
		nilnul.obj_.singular.Heir<Union>
		,

		num_.plural_.prime.bag.op_.BinaryI
	{

		static public Bag Op(Bag a, Bag b)
		{

			var r = new Bag();
			r.unionWith(a);
			r.unionWith(b);
			return r;
			//throw new NotImplementedException();
		}
			
			

		
		public Bag op(Bag a, Bag b)
		{

			var r = new Bag();
			r.unionWith(a);
			r.unionWith(b);
			return r;
			//throw new NotImplementedException();
		}
	}
}
