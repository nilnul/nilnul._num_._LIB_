using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.be_
{
	 public class Odd
		:
		nilnul.num.BeA
		,
		nilnul.num.BeOfByRefI
	{
		

		public override bool be(NumI1 obj)
		{
			return obj.toBigint().en % 2==1;

			//throw new NotImplementedException();
		}

		public bool be(Num_byRef obj)
		{
			return obj.eeByRef % 2 ==1;
			//throw new NotImplementedException();
		}

		static public Odd Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Odd>.Instance;
			}
		}

	}
}
