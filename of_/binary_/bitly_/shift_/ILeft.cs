using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.bitly_.shift_
{
	/// <summary>
	/// (x,y) => x*2^y
	/// </summary>
	/// <see cref="op_.unary_.bitly_.shift_._LeftX"/>
	internal class ILeft
	{
		static public int ShiftLeft(int x, int y) {
			return x << y;
		}
	}
}
