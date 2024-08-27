using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;

namespace nilnul.num.stream.duo.op_
{
	public class Add
		:OpI
	{

		public class _Ret : Duo
			,StreamI3
		{
			

			public _Ret(StreamI3 a, uint b)
				:this(a,
					 new stream_.Constant(b)
					)
			{
				
			}

			public _Ret(StreamI3 a, StreamI3 b) : base(a, b)
			{
			}

			public Natural.Asserted next()
			{
				return Item1.next() + Item2.next();

 			}
		}
		public StreamI3 eval(StreamI3 a, StreamI3 b)
		{
			return new _Ret(a, b);
		}

		public StreamI3 eval(StreamI3 a, uint b)
		{
			return new _Ret(a, b);
		}



		static public readonly Add Singleton = SingletonByDefault<Add>.Instance;


	}
}
