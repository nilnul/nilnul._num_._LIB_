using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.border.duo.vow_.dwelled
{
	[Obsolete(nameof(be_.dwelt.vow.En))]
	public class Ed : nilnul.obj.vow.Ed<nilnul.num.border.Duo, nilnul.num.border.duo.be_.dwelled.Vow>
	{
		public Ed(Duo val) : base(val)
		{

		}

		public bool contain(Num x) {
			return _duo_.lower.Contain.Eval(ed.lower,  x) && _duo_.upper.Contain.Eval(ed.upper,x);
		}
		public bool contain(NumI x) {
			return _duo_.lower.Contain.Eval(ed.lower,  x) && _duo_.upper.Contain.Eval(ed.upper,x);
		}


		static public Ed CreateClopen(Num x, nilnul.num_.Positive y) {
			return new Ed(
				new Duo(
					Border1.CreateClose(x)
					,
					Border1.CreateOpen(y)
				)
			);
		}

		static public Ed CreateClopenSinceZero(nilnul.num_.Positive y) {
			return CreateClopen(new nilnul.Num( 0),y);
		}

		static public Ed CreateLt(nilnul.num_.Positive x) {
			return CreateClopenSinceZero(
				x
			);
		}
	}
}
