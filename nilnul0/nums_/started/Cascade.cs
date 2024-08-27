using nilnul.objs_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nums_.started
{
	public interface CascadeI:
		_cascade_.OvInterfaceI
		,
		nilnul.objs_.started.CascadeI<nilnul.NumI1>
	{
	}
	static public class _CascadeX
	{
		static public NumI1 Cascade(
			this nilnul.objs_.started.CascadeI<nilnul.Num1> cascader, Started3<NumI1> started
		)
		{
			return nilnul.objs_.started._CascadeX.Cascade(
				cascader,
				started.Select(x => Num1.OvInteface(x))
			);
		}
		static public Num1 Cascade(
			this nilnul.objs_.started.CascadeI<nilnul.NumI1> cascader, Started3<Num1> started
		)
		{
			return Num1.OvInteface( nilnul.objs_.started._CascadeX.Cascade(
				cascader
				,
				started
				
			));
		}
	}






}
