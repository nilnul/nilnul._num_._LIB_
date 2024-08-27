using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num_.plural_.prime.set_.db_.ef
{


	/// <summary>
	/// this is an auto-increase table, an ideal table, i.e., it can hold unlimited primes; while the table implemented in sql serer, due to the capacity constraints there, can only hold bounded primes.
	/// </summary>
	/// <remarks>
	/// sql server talbe + memeory.
	/// </remarks>
	public class AutoGrowMem
	{


		//static nilnul.num.natural.Adapter _buffer;

		static List<BigInteger> _overflow = new List<BigInteger>();

		static BigInteger _chekedTill = AutoGrowDb.MAX;
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="next">
		/// overflowing BigInt.
		/// 
		/// </param>
		/// <returns></returns>
		static private bool _Contains_up2checkedInMemory(BigInteger _plural)
		{


			if (_plural <= AutoGrowDb.MAX)
			{
				return AutoGrowDb.Contains((long)_plural);
			}
			if (_plural <= _chekedTill)
			{
				return _overflow.Cast<BigInteger>().Contains(_plural);
			}


			return false;

		}





		static private void _PopulateToCover(BigInteger p_plural)
		{

			if (p_plural<=AutoGrowDb.MAX)
			{
				AutoGrowDb.PopulateAndCommit(p_plural);
				return;
				
			}

			for (BigInteger i = _chekedTill; i < p_plural; )
			{
				//check i's primability
				i++;
				if (_isNextPrime(i))
				{
					_overflow.Add(i);

				}

			}
			_chekedTill = p_plural;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="b">geater than upperbound</param>
		/// <returns></returns>
		/// 
		
		static private bool _isNextPrime(BigInteger b)
		{


			BigInteger sqrtFloor = ( nilnul.num.op_.unary_.SqrtFloorX._SqrtFloor(b));


			foreach (
				var item 
				in 
				AutoGrowDb.db.Prime.Where(e => e.prime1<= sqrtFloor).Select(f => f.prime1).Cast<BigInteger>().Union(_overflow.Where(g => g <= sqrtFloor))
			)
			{

				if (b % item == 0)
				{
					return false;

				}
			}

			return true;


		}


		

		static public IEnumerable<BigInteger> SequenceUpTo_inBigInteger__positive(BigInteger _positive )   
		{


			if (_positive <= AutoGrowDb.MAX)
			{
				return AutoGrowDb.SequenceUpTo_inLong__positive((long)_positive).Select(c => new BigInteger(c));//.Cast<BigInteger>();
			}

			_PopulateToCover(_positive);

			return AutoGrowDb.SequenceUpToMax().Select(c => new BigInteger(c)).Union(_overflow.TakeWhile(c => c <= _positive));

		}


		

		static public bool IsPrime(nilnul.num.natural.Natural n)
		{
			_PopulateToCover(n);
			return _Contains_up2checkedInMemory(n);

		}


		static public bool _IsPrime(BigInteger n_plural)
		{
			if (n_plural <= AutoGrowDb.MAX)
			{
				return AutoGrowDb._Contains((long)n_plural);

			}


			_PopulateToCover(n_plural);
			return _Contains_up2checkedInMemory(n_plural);

		}


		static public bool IsPrime(BigInteger n_plural)
		{
			if (n_plural<2)
			{
				return false;
				
			}
			return _IsPrime(n_plural);
		}


		static public bool IsPrime(nilnul.num.natural.Plural2.Noun n)
		{
			return _IsPrime(n.val.val);

		}





	}



}

