using nilnul.num_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.algebra_
{
	/// <summary>
	/// the set: all the nums
	/// the equiv:
	///		eq when: %p, where p is the divisor.
	///	the multiplycation
	///	
	/// </summary>
	public class Modulo
		:
		nilnul.obj.Box1<
			nilnul.num_.Positive1
		>
	{
		public Modulo(Positive1 val) : base(val)
		{
		}
	}
}
