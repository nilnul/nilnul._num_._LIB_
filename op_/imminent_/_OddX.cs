using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.imminent_
{

	/// <summary>
	/// among all odd numbers, select minimal one that is ge current.
	/// </summary>
	static public class _OddX
	{
		static public int _AsOdd_0num(int x) {

			///<see cref="nilnul.num_.BijectiveNum"/>
			return (
				x
			)
				/ 2

				*  2
				+1 //ensure it's odd

				;
		}
	}
}
