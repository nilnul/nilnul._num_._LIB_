using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border.co_
{
	//extern alias nn;
	public class Clopen
		:
		nilnul.obj.border._duo_.ToTxtA<
			nilnul.Num1, 
			nilnul.num.border_.Close1
			,nilnul.num.border_.Open1
		>
		,
		nilnul.obj.border.DuoI<
			nilnul.Num1, nilnul.num.border_.Close1
			,
			nilnul.num.border_.Open1
		>
	{
		private nilnul.num.border_.Close1 _lower;

		public override nilnul.num.border_.Close1 lower
		{
			get { return _lower; }
		}
		private nilnul.num.border_.Open1 _upper;

		public override nilnul.num.border_.Open1 upper
		{
			get { return _upper; }
		}


		public Clopen(
			nilnul.num.border_.Close1 lower
			,
			nilnul.num.border_.Open1 upper

		)
		{
			_lower = lower;
			_upper = upper;

		}

		




	}
}
