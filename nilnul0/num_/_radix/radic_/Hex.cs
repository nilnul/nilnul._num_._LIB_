using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_._radix.root_
{
	public class Hex:nilnul.num_._radix.Root1 //.Root
	{
		public Hex():base(16)
		{

		}
		static public nilnul.nums_.ListOfClass ToGits(nilnul.Num num) {
			return Singleton._toPositions(num);
		}

		static public nilnul.nums_.ListOfClass ToGits(int num) {
			return Singleton._toPositions(num);
		}

		static public Hex Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Hex>.Instance;
			}
		}
	}
}