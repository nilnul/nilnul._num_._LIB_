﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.slider_
{
	/// <summary>
	/// 1!, 3!, 5!
	/// </summary>
	public class EvenFactorial
		: nilnul.num.SliderI
	{
		private nilnul._num.bigint.be.Natural.Asserted _current=1 ;

		public nilnul._num.bigint.be.Natural.Asserted current
		{
			get
			{
				return  _current;
			}
		}

		private N _index=1;

		public void moveNext()
		{
			_current *= _index++;
			_current *= _index++;

		}


	}
}