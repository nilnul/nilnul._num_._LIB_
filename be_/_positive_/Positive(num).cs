﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.be
{
	public  class Positive
	{
		
		static public bool Eval(BigInteger i) {
			return i > 0;

			throw new NotImplementedException();
		
		}


		

		public class Be
			:nilnul.bit.Be<BigInteger>
		{
			public Be()
				:base(Eval)
			{

			}
		}
		[Obsolete()]
		public class Expr__bigInt:
			nilnul.bit.be.Asserted<BigInteger,Be>
		{
			public Expr__bigInt(BigInteger x)
				:base(x)
			{

			}



		}

	}
}