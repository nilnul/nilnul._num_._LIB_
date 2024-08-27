using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.co.vow.ee_
{
	public class VowDefault<TVow> : co.vow.Ee
		where TVow : nilnul.num.co.VowI, new()
	{
		public VowDefault(Co_onInteface val) : base(
			val,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
		public VowDefault(NumI1 a, NumI1 b):this(
			new Co_onInteface(a,b)
		)
		{
		}
		public VowDefault(
			Num1 a
			,
			Num1 b
		):this(
			(NumI1)a,
			(NumI1)b
		)
		{

		}
		public VowDefault(int x, int y):this(
			new Num1(x)
			,
			new Num1(y)
		)
		{

		}

	}
}
