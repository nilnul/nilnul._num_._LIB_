using nilnul.num.op_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.expr_.closed_.call_
{
	public class Nary :
		nilnul.obj.expr_.closed_.call_.Nary<nilnul.NumI1>
		,
		num.expr_.closed_.CallI
	{
		public Nary(NaryI<NumI1> op) : base(op)
		{
		}

		public Nary(NumI1 literal) : base(literal)
		{
		}
	}
}
