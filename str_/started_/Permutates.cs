using nilnul.num._num.bigint.be;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str_.started_
{


	/// <summary>
	/// given n,
	/// return
	///  P(n,0), P(n,1)=n, P(n,2)=n*(n-1), ..., P(n, n-1), P(n,n)=n!
	/// </summary>
	public class Permutates
		:
		nilnul.obj.Box1<
			nilnul.NumI1
		>
		,
		nilnul.num.SeqI
	{
		public Permutates(NumI1 val) : base(val)
		{
		}

		public IEnumerator<BigInteger> enumerateBigint()
		{
			BigInteger r = 1;
			yield return (r);

			var boxedAsBigint = boxed.toBigint().en;

			for (BigInteger i = boxedAsBigint; i >0; i--)
			{
				r *= i;

				yield return (r);

			}



		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// newly appended, not in place.
		/// </returns>
		public IEnumerator<NumI1> GetEnumerator()
		{
			var enumer = enumerateBigint();
			while (enumer.MoveNext())
			{
				yield return new Num1( enumer.Current );
			}



		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
