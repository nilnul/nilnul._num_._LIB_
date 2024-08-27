using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.expr_
{
	public interface ClosedI
		: nilnul.num.ExprI
		,
		nilnul.obj.expr_.ClosedI< nilnul.NumI1>
	{

	}

	public class Closed :
		nilnul.obj.expr_.Closed<nilnul.NumI1>
		,
		ClosedI
	{
		public Closed(obj.expr_.ClosedI<NumI1> val) : base(val)
		{
		}

	}
}
