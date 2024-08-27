using nilnul.objs_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nums_.started.cascade
{
	public class OfClass
		: nilnul.obj.Box1<nilnul.nums_.started.CascadeI>
		,
		nilnul.nums_.started._cascade_.OvClassI
	{
		public OfClass(CascadeI val) : base(val)
		{
		}

		public Num1 cascade(Started3<Num1> started)
		{
			return nilnul.nums_.started._CascadeX.Cascade(this.boxed,started);
		}
	}

	public abstract class OfClassA :
	nilnul.objs_.started.CascadeA<nilnul.NumI1>
	,
	nilnul.objs_.started.CascadeI<nilnul.Num1>
	//,
	//CascadeI
	,
	_cascade_.OvClassI
	{
		public Num1 cascade(Started3<Num1> started)
		{

			return _CascadeX.Cascade(this, started);
		}

		public abstract override NumI1 cascade(Started3<NumI1> started);

	}
}
