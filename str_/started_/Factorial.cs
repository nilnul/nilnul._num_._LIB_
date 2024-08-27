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
	///  0!=1, 1!= 1, 2!=2, ..., (n-1)!, n!
	/// </summary>
	public class Factorial
		:
		nilnul.obj.Box1<
			nilnul.NumI1
		>
		,
		nilnul.num.SeqI
	{
		public Factorial(NumI1 val) : base(val)
		{
		}

		public IEnumerator<BigInteger> enumerateBigint()
		{
			BigInteger r = 1;

			yield return (r);

			var boxedAsBigint = boxed.toBigint().en;

			for (BigInteger i =1; i<= boxedAsBigint;  i++)
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
