using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_._radix.root_
{
	public class Binary:nilnul.num_._radix.Root
	{

		public Binary():base(2)
		{

		}


		static public readonly Binary Singleton = nilnul.obj.SingletonByDefault<Binary>.Instance;



		static public nilnul.nums_.List ToDigits(nilnul.Num num) {
			return Singleton._toDigits(num);
		}

		static public nilnul.nums_.List ToDigits(int num) {
			return Singleton._toDigits(num);
		}

	}
}
