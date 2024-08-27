using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.natural.collection.op
{
	/// <summary>
	/// for 0, Lcm is 0
	/// </summary>
	public  class Lcm
	{
		static public N Eval(N x) {
			return x;
		}

		static public N Eval(N x, N y) {

			if (x==0 && y==0)
			{
				return 0;
				
			}
			return x  / num.natural.op.binary.Gcd.Eval(x, y)*y;	///perform division first to avoid possible overflow
		}
		static public N Eval(IEnumerable<BigInteger> set_nonEmpty)
		{
			return Eval(set_nonEmpty.Select(x=> new N(x)));
		}
		static public N Eval(IEnumerable<N> set_nonEmpty) {

			
			IEnumerable<Dictionary<BigInteger, long>> factored = set_nonEmpty.Select(
				n =>
				//num.natural.prime.Factoring.Eval
				{
					var r11 = new Dictionary<BigInteger, long>(

					  );
					nilnul.num.positive.Factor._Eval(n).ForEach(x=> r11.Add(x.Key.val.val,(long)x.Value.val ));

					return r11;
				}
			);

			Dictionary<BigInteger, long> r = new Dictionary<BigInteger, long>();

			foreach (var item in factored)
			{
				foreach (var item2 in item)
				{
					if (r.ContainsKey(item2.Key))
					{
						r[item2.Key] = (long)(num.natural.collection.op.Max.Eval(r[item2.Key], item[item2.Key]).toBigInteger());
					}
					else
					{
						r.Add(item2.Key,item2.Value);
					}
					
				}
				
			}

			BigInteger rr = 1;
			foreach (var item in r)
			{
				rr *= num.natural.op.PowX2.Eval(item.Key, item.Value);
				
			}

			return new N( rr);
		
			
		}

		static public N Eval(params int[] nonEmpty) {
			return Eval((nonEmpty as IEnumerable<int>).Select(c=>new N(c)));
		}



	}
}
