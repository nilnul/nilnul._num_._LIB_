using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.op_.binary_
{
		/// <summary>
		/// if one is zero, return the other.	hence if both are zero, return zero.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
     public class Gcd
		:
		num.op_.BinaryA,

		num.op_.BinaryI1
		,
		num.op_.BinaryI_onInterfaces
    {
		
		public BigInteger opAsBigint(Num1 par, Num1 par1)
		{
			return BigInteger.GreatestCommonDivisor(
				par.en,par1.en
			);
			//throw new NotImplementedException();
		}

		public BigInteger opAsBigint(NumI1 par, NumI1 par1)
		{
			return BigInteger.GreatestCommonDivisor(
				par.toBigint().en,par1.toBigint().en
			);
			
		}

		

		public override NumI1 op(NumI1 par, NumI1 par1)
		{
			return new Num1( opAsBigint(par, par1) );


			//throw new NotImplementedException();
		}


		static public Gcd Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Gcd>.Instance;
			}
		}
		static public Gcd Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Gcd>.Instance;
			}
		}


	}
}
