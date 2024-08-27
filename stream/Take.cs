using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;

using N = nilnul.NumI;


namespace nilnul.num.stream
{
	public class Take :nilnul.obj.stream.Take<N> 
	{
		public Take(StreamI4 stream, N count ):base(stream,count)
		{
			
		}
	}
}
