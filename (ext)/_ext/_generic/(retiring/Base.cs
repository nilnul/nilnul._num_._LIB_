using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num._ext._generic
{
	[Obsolete("_ext.Bare")]
	public class Base<T> :
		Box<T>
		,
		
		ExtI<T>
	{
		public Base(T val)
			:base(val)
		{

		}

	}


	[Obsolete("_ext.Bare")]
	public class UnExt<T> :
		Box<T>
		,
		
		ExtI<T>
	{
		public UnExt(T val)
			:base(val)
		{

		}

	}
}
