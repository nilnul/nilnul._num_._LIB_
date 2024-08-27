using nilnul.objs_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nums_.started.cascade_
{
	public class OvClass
		: nilnul.obj.Box1<nilnul.nums_.started._cascade_.OvClassI>
		,
		nilnul.nums_.started._cascade_.OvInterfaceI
	{
		public OvClass(nilnul.nums_.started._cascade_.OvClassI val) : base(val)
		{
		}

		public NumI1 cascade(Started3<NumI1> started)
		{
			return nilnul.nums_.started._CascadeX.Cascade(this.boxed,started);
		}
	}

	/// <summary>
	/// ov means over/of
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		ov like one
	/// </remarks>
	public abstract class OvClassA :
	nilnul.objs_.started.CascadeA<nilnul.Num1>
	,
	nilnul.objs_.started.CascadeI<nilnul.NumI1>
	,
	CascadeI
	,
	_cascade_.OvClassI
	{
		public abstract override Num1 cascade(Started3<Num1> started);

		public NumI1 cascade(Started3<NumI1> started)
		{

			return _CascadeX.Cascade(this, started);
		}

	}
}
