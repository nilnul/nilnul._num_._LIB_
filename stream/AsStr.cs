using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;
using N = nilnul.num._num.bigint.be.Natural.Asserted;

namespace nilnul.num.stream
{
	

	static public class AsStrX
	{
		

		static public StrI1 Eval(this StreamI2 stream, N length) {

			return new AsStr(stream, length);

		}

	}

	public class AsStr : StrA
	{
		private StreamI2 _stream;

		public StreamI2 stream
		{
			get { return _stream; }
			set { _stream = value; }
		}



		public AsStr(StreamI2 stream, N length )
		{
			_stream = stream;
			_length = length;
		}


		public override N this[BigInteger index]
		{
			get
			{

				if (index>_length || index<0)
				{
					throw new IndexOutOfRangeException();
				}
				while (index-->0)
				{
					_stream.next();

				}

				return new N( _stream.next().val);

				throw new NotImplementedException();
			}
		}

		private N _length;

		public override N count
		{
			get
			{
				return _length;
				throw new NotImplementedException();
			}
		}
	}






}
