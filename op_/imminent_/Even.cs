using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.imminent_
{

	/// <summary>
	/// among all even numbers, select minimal one that is ge current.
	/// </summary>
	static public class _EvenX
	{
		static public int _AsEven_0num(int x) {

			///<see cref="nilnul.num_.BijectiveNum"/>
			return (
				x
				+1		///   ;<see cref="nilnul.num_.BijectiveNum"/>
				)
				/ 2

				*  2		//ensure it's even

				;
		}
	}
}
