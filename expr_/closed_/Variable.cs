using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.expr_.closed_
{
	public class Variable
		:
		nilnul.obj.expr_.closed_.Variable<nilnul.NumI1>
		,
		ClosedI
	{
		[Obsolete(nameof(nilnul.num.var_.handled_.Typed))]
		public Variable(VarI6<NumI1> val) : base(val)
		{
		}
		public Variable(
			nilnul.num.var_.handled_.Typed var
		):base(var)
		{

		}
	}
}
