using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.border;

using N = nilnul.NumI;


namespace nilnul.num
{

	public class Bound1 : nilnul.num.border.co.be_.dwelt.vow.En
	{
		

		public Bound1(border.Co val) : base(val)
		{
		}

		public Bound1(Border2 border, Border2 borderUpper):this(new border.Co(border,borderUpper))
		{
			
		}

		static public Bound1 CreateClose(nilnul.Num1 a, nilnul.Num1 b) {

			return new Bound1(
				border.Co.CreateClose(a,b)
			);
		}

		static public Bound1 CreateClose(BigInteger a, BigInteger b) {

			return new Bound1(
				border.Co.CreateClose(a,b)
			);
		}



		static public Bound1 CreateClose_sortWhenNecessary(nilnul.Num1 a, nilnul.Num1 b) {
			
			return new Bound1(
				 border.Co.CreateClose(
					nilnul.num.co.convert_.Sort.Singleton.eval(a,b)
				)
			)
			
			;
		}

		public static Bound1 CreateClose_sortWhenNecessary(Co boxed)
		{
			return CreateClose_sortWhenNecessary(boxed.Item1,boxed.Item2);
			//throw new NotImplementedException();
		}

		static public Bound1 CreateSingleton(nilnul.Num1 a) {

			return CreateClose(a,a);
		}

		static public Bound1 CreateSingleton(BigInteger a) {

			return CreateClose(a,a);
		}

		public static Bound1 CreateOpen(BigInteger lower, BigInteger upper)
		{
			return new Bound1(
				Border2.CreateOpen((Num1)lower)
				,
				Border2.CreateOpen((Num1)upper)
			);
		}

		
	}
}
