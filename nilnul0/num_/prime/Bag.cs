using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P = nilnul.num_.plural_.Prime;
using Po = nilnul.num_.Positive1;

namespace nilnul.num_.plural_.prime
{

	public  class Bag
		:nilnul.obj.bag_.EqDefault<P,num_.plural_.prime.Eq>
	{

		public Bag()
			:base()
		{
		}
		public Bag(IEnumerable<int> primes):base(primes.Select(x=>new P(x)))
		{

		}
		public Bag(params int[] primes):this(
			(IEnumerable<int>)primes
		)
		{

		}

		public void add(int key,int val) {
			base.Add(new P(key), new Po(val));
		}

		//public void pack() {
		//	nilnul.obj.bag.op_.Pack<P, num_.plural_.prime.Eq>.Singleton.op(this);
		//}

		static public Bag Create(params int[] x) {
			var r = new Bag();
			for (int i = 0, j=1; j < x.Length; i+=2,j+=2)
			{
				r.add(x[i], x[j]);
			}

			return r;
		}


					
	}

	
}
