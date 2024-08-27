using nilnul.obj.op_;
using nilnul.objs_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.max
{
	public class Cascade :
		nilnul.obj.op_.binary.cascader_.OpDefault<nilnul.NumI1, Max>
		,
		nilnul.nums_.started.CascadeI
		,
		nilnul.nums_.started._cascade_.OvClassI

		
	{
		

		public Num1 cascade(Started3<Num1> started)
		{
			return nilnul.nums_.started._CascadeX.Cascade(this, started);
		}


	}
}
