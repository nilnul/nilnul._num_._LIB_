using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.be_
{
	public class Positive : nilnul.num.BeA, BeI, nilnul.num.BeI1
	{
		public bool be(Num obj)
		{
			return obj.val > 0;
			//throw new NotImplementedException();
		}

		public override bool be(NumI1 obj)
		{
			return obj.toBigint().en > 0;
		}


		static public Positive Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Positive>.Instance;
			}
		}

	}
}
