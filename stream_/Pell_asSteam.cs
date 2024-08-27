using nilnul.num.natural.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Collections;

namespace nilnul.num.stream
{
	public class Pell_asStream : InfiniteEnumerable<BigInteger>
	{

		public IEnumerator<BigInteger> GetEnumerator()
		{
			BigInteger p0 = 0;
			BigInteger p1 = 1;
			BigInteger p_next = 2*p0 + p1;
			yield return p0;
			yield return p1;
			while (true)
			{

				yield return p_next;

				p0 = p1;
				p1 = p_next;
				p_next =2* p1 + p0;
			}
			

			throw new NotImplementedException();
		}

	

		private IEnumerator<BigInteger> _enumerator;
		public Pell_asStream()
		{
			_enumerator = GetEnumerator();
		}

	

		public BigInteger next()
		{
			_enumerator.MoveNext();
			return _enumerator.Current;
			
			


			throw new NotImplementedException();
		}

		
	}
}
