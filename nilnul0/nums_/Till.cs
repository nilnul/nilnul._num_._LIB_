using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.nums_
{
	public class Til
		:
		nilnul.num.calc_._unary.Arg,

		nilnul.NumsI
	{
		public Til(NumI1 arg) : base(arg)
		{
		}

		public IEnumerator<NumI1> GetEnumerator()
		{
			var classed = nilnul.Num1.OvInteface(this.arg);
			var ini =new BigInteger();
			while (ini<= classed)
			{
				yield return new nilnul.Num1( ini );
				ini++;
			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
