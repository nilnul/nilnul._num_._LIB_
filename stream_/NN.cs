using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.natural.stream
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Note: 15151515...., cannot be computed by 15*10^n+15*10^n-1
	/// </remarks>
	public partial class NN
	{
		static public string GetItem_asStr(BigInteger x) {

			
			

			return duo.op.StrRepeat.Eval(x.ToString(),x);

		}
		static public BigInteger GetItem(BigInteger x) {

			return BigInteger.Parse(GetItem_asStr(x));
			
		}

		static public IEnumerable<BigInteger> GetItems(BigInteger x) {
			BigInteger i = 0;
			while (i++<x)
			{
				yield return GetItem(i);
			}
		}
	}
}
