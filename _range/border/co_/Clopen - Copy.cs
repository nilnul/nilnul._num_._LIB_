using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.duo_
{
	//extern alias nn;
	public class Clopen
		:
		nilnul.obj.border._duo_.ToTxtA<
			nilnul.Num, 
			nilnul.num.border_.Close
			,nilnul.num.border_.Open
		>
		,
		nilnul.obj.border.DuoI<
			nilnul.Num, nilnul.num.border_.Close
			,
			nilnul.num.border_.Open
		>
	{
		private nilnul.num.border_.Close _lower;

		public override nilnul.num.border_.Close lower
		{
			get { return _lower; }
		}
		private nilnul.num.border_.Open _upper;

		public override nilnul.num.border_.Open upper
		{
			get { return _upper; }
		}


		public Clopen(
			nilnul.num.border_.Close lower
			,
			nilnul.num.border_.Open upper

		)
		{
			_lower = lower;
			_upper = upper;

		}

		




	}
}
