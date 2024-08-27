using nilnul.num.natural.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections;

namespace nilnul.num.stream
{
	public class Pell : IEnumerable<BigInteger>
	{



		public IEnumerator<BigInteger> GetEnumerator()
		{
			BigInteger index = 0;
			BigInteger p0 = 0;
			BigInteger p1 = 1;
			BigInteger p_sum = p0 + p1;
			yield return 0;
			yield return 1;
			while (true)
			{
				yield return p_sum;

				p0 = p1;
				p1 = p_sum;
				p_sum = p1 + p0;
			}
			

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
