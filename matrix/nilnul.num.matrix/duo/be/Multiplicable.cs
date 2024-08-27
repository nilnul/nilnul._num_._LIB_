using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.matrix.duo.be
{
	public class Multiplicable
	{
		static public bool Eval(uint[,] a, uint[,] b) {
			return nilnul.collection.matrix.duo.be.Associable.Eval(a, b);
		}
	}
}
