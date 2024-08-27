using System;
using System.Collections;
using System.Numerics;
using nilnul._num.bigint.be;

namespace nilnul.num.convert_
{

	public class Inc : ConvertI
	{
		public NumI convert(NumI arg)
		{
			return new nilnul.Num(arg.toBigint()+1);
			throw new NotImplementedException();
		}



		static public Inc Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inc>.Instance;
			}
		}

	}


}
