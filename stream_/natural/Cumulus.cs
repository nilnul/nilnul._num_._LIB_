using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.natural
{
	/// <summary>
	/// 0,0,1,3,6,10,15. 
	/// </summary>
	/// <remarks>
	/// dehead, we get:
	///		0,1,3,6,10,15, ...
	///	increment, we get
	///		1,2,4,7,11,16,...
	/// </remarks>
	public class Cumulus
		:nilnul.num.stream.cumulus_.Series_froNew<stream_.Natural>
	{
		static public nilnul.Num1 SumUp2numero(nilnul.Num1 numero) {
			return  ( numero * (numero + 1) ) / 2u;
		}
		static public nilnul.Num1 SumBeforeNmero(nilnul.Num1 numero) {
			if (numero==0)
			{
				return 0;
			}
			return SumUp2numero(
				numero-1
			);
		}

		static public BigInteger SumBeforeNmero_assumeNumero(BigInteger numero) {
			return  ( numero * (numero - 1) ) / 2;
			
		}



	}
}
