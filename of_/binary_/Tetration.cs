using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num1;

namespace nilnul.num.op_.binary_
{
	/// <summary>
	/// alias:
	///		hyperexponential;
	///		hyper[0]
	/// </summary>
	/// 
	public class Tetrate
		:
		num.op_.BinaryA
		
	{

		static public BigInteger Op_assumeNats(BigInteger radic_natural,BigInteger index_natural) {
			if (index_natural==0)
			{
				return 1;

			}


			return num.op_.binary_._PowX._Op(radic_natural, Op_assumeNats(radic_natural, index_natural - 1));
		}

		static public N Op(nilnul.NumI1 radic,NumI1 index) {
			return new N(
				Op_assumeNats(radic.toBigint(),index.toBigint())	
			);
		}

		public override NumI1 op(NumI1 par, NumI1 par1)
		{
			return Op(par,par1);
		}

		static public Tetrate Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tetrate>.Instance;
			}
		}






	}

}
