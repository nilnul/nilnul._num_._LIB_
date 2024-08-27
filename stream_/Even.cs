using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;
using nilnul.obj._stream_;
using N = nilnul.NumI;

namespace nilnul.num.stream_
{
	public  class Even:StreamI4
	{
		

		private BigInteger _b4head=-1;// /*default */=0;

		public BigInteger b4head
		{
			get { return _b4head; }
			set { _b4head = value; }
		}

		public Even()
		{
			//reset();

		}
		public  N next()
		{
			return new nilnul.Num(_b4head+=2);

			//throw new NotImplementedException();
		}



		public  void reset()
		{
			_b4head = -1;
			return;
			//throw new NotImplementedException();
		}

		
	}
}
