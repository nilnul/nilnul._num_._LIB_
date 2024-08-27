using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_._radix.root_
{
	public class Dec:Root1
	{
		public Dec() : base(10)
		{
		}

		static public nilnul.nums_.List ToDigits(nilnul.Num num) {
			return new nilnul.num_._radix.Root(10)._toDigits(num);
		}
		static public nilnul.nums_.ListOfClass ToDigits(nilnul.Num1 num) {
			return Singleton._toPositions(num);
		}


		static public nilnul.nums_.List ToDigits(int num) {
			return new nilnul.num_._radix.Root(10)._toDigits(num);
		}


		static public Dec Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dec>.Instance;
			}
		}


	}
}
