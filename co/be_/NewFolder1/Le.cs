﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo.be_
{
	public class Le : BeI1
	{
		

		public bool be(Duo1 obj)
		{
			return obj.Item1 <= obj.Item2;
			//throw new NotImplementedException();
		}


		static public readonly Le Singleton = nilnul.obj.SingletonByDefault<Le>.Instance;

	}
}
