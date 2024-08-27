using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.ext_._generic
{
	public class Eq<TLiteral, LiteralEq, TExtLiteral>
		where LiteralEq :IEqualityComparer<TLiteral>
		where TExtLiteral : num._ext._generic.UnExt<TLiteral>
	{
		private LiteralEq _literalEq;

		public LiteralEq literalEq
		{
			get { return _literalEq; }
			set { _literalEq = value; }
		}
		public Eq(LiteralEq eq)
		{
			_literalEq = eq;

		}

		public bool eval(TExtLiteral x, TExtLiteral y) {

			return _literalEq.Equals(x.val, y.val);

		}

		
	






	}
}
