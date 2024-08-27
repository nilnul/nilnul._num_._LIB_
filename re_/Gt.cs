using System;
using System.Net;
using System.Numerics;

namespace nilnul.num.re_
{
	 public  class Gt
		:nilnul.num.ReI
	{
		

		public bool re(NumI1 a, NumI1 b)
		{
			return a.toBigint().en>b.toBigint().en;
		}


		static public Gt Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Gt>.Instance;
			}
		}

	}
}
