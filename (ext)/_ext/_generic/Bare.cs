
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num._ext._generic
{
	public class Bare<T> :
		Box<T>
		,
		
		ExtI<T>
	{
		public Bare(T val)
			:base(val)
		{

		}

	}



	
}
