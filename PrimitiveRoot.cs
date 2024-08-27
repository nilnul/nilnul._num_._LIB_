using nilnul.num.natural.prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num
{
	/// <summary>
	/// If n is a positive integer, the integers between 0 and n − 1 that are coprime to n (or equivalently, the congruence classes coprime to n) form a group, with multiplication modulo n as the operation; it is called the group of units modulo n, or the group of primitive classes modulo n.
	/// As explained in the article multiplicative group of integers modulo n, this multiplicative group  is cyclic if and only if n is equal to 2, 4, p^k, or 2*p^k where p^k is a power of an odd prime number. When (and only when) this group is cyclic, a generator of this cyclic group is called a primitive root modulo n (or in fuller language primitive root of unity modulo n, emphasizing its role as a fundamental solution of the roots of unity polynomial equations X^m − 1 in the ring Z<sub>n</sub>, or simply a primitive element of  Z<sup>x</sup><sub>n</sub>n.
	/// </summary>
	public class PrimitiveRoot
	{


		static public bool Is(int natural, int prime)
		{
			return Is((BigInteger)natural, (BigInteger)prime);

		}

		static public HashSet<BigInteger> GetRoots(
			BigInteger natural, BigInteger prime

			)
		{

			var r = new HashSet<BigInteger>();
			for (BigInteger i = 1; i < prime; i++)
			{
				var mod = nilnul.num.natural.op.PowX.Pow(natural, i).val % prime;
				r.Add(mod);

			}
			return r;

		}

		static public bool Is(BigInteger natural, BigInteger prime)
		{

			var r = GetRoots(natural, prime);

			if (r.Count == prime - 1)
			{
				return true;


			}
			return false;

			throw new NotImplementedException();

		}

	}
}
