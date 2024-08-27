using nilnul.num.op_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.expr_.closed_.call_
{
	public class Binary :
		nilnul.obj.expr_.closed_.call_.Binary<nilnul.NumI1>
		,
		num.expr_.closed_.CallI
	{
		public Binary(BinaryI<NumI1> op, obj.expr_.ClosedI<NumI1> arg, obj.expr_.ClosedI<NumI1> arg1) : base(op, arg, arg1)
		{
		}
	}
}
