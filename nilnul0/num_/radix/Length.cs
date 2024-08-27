using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix
{
	/// <summary>
	/// how many positions needed 
	/// </summary>
	static public class _WidthX
	{
		static public BigInteger _Interger_assumeNum_assumePlural(BigInteger _num, BigInteger _radical ) {
			var r = 0;
			while (_num!=0)
			{
				_num /= _radical;
				r++;
			}
			return r;

		}

		static public BigInteger _Interger_assumeNum_assumePlural(BigInteger _num ) {
			return _Interger_assumeNum_assumePlural(_num, 10);

		}


		static public BigInteger Integer(nilnul.Num1 num, nilnul.num_.Plural1 radic ) {
			return _Interger_assumeNum_assumePlural(num.en, radic.en);
		}


		static public BigInteger Integer(nilnul.Num1 num ) {
			return _Interger_assumeNum_assumePlural(num.en,  10);
		}

	}
}
