using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.Num1;


namespace nilnul.num.op_.binary_
{
	public class Multi : nilnul.num.op_.BinaryI1
	{
		public N op(N arg, N arg1)
		{
			return new N(arg.en*arg1.en);
			//throw new NotImplementedException();
		}


		static public Multi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi>.Instance;
			}
		}



	}
}
