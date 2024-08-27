using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.vow.ee_
{
	public class VowDefault<TCol,TRow,TVow>
		: nilnul.obj.vow.ee_.Defaultable<Co<TCol,TRow>, TVow>
		where TVow : VowI<TCol,TRow>, new()

		where TCol : nilnul.num.OrdI2
		where TRow : nilnul.num.OrdI2

	{
		public VowDefault(Co<TCol,TRow> val) : base(val)
		{
		}
	}

	public class VowDefault_OnColVow<TCol,TVow>
		: nilnul.obj.vow.ee_.Defaultable<Co<TCol>, TVow>
		
		

		where TVow : VowI<TCol>, new()

		where TCol : nilnul.num.OrdI2


	{
		public VowDefault_OnColVow(Co<TCol> val) : base(val)
		{
		}

		
	}

	

}
