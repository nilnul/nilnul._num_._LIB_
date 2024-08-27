using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_
{
	/// <summary>
	/// <see cref="op_.unary_._TotientX"/>
	/// </summary>
	public abstract class TotientA : nilnul.num.op_.UnaryI1
		,
		nilnul.obj.OpI5<BigInteger>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <returns>
		/// 0 =>0
		/// 1: 0
		/// 2: 1
		/// 3:2
		/// 4:2
		/// 5: 3
		/// </returns>
		public abstract Num1 op(Num1 par);
		public abstract BigInteger op(in BigInteger obj);
	}
}
