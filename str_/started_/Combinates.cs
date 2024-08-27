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

	public class Combinates
		:
		nilnul.obj.Box1<
			nilnul.NumI1
		>
		,
		nilnul.num.SeqI
	{
		public Combinates(NumI1 val) : base(val)
		{
		}

		public Combinates(Num1 val) : this((NumI1)val)
		{
		}

		public Combinates(BigInteger x):this(new nilnul.Num1(x))
		{

		}

		public IEnumerator<BigInteger> enumerateBigint()
		{
			var enumer4numerator = new Permutates(boxed).enumerateBigint();
			var enumer4denominator = new Factorial(boxed).enumerateBigint();
			// they can run parallel



			while (enumer4numerator.MoveNext())
			{
				enumer4denominator.MoveNext();
				yield return enumer4numerator.Current / enumer4denominator.Current;

			}

			//throw new NotImplementedException();
		}

		public IEnumerator<NumI1> GetEnumerator()
		{
			var enumer = enumerateBigint();
			while (enumer.MoveNext())
			{
				yield return new Num1(enumer.Current);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
