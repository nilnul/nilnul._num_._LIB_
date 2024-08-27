using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num
{
	[Obsolete()]
	public interface StreamI2
		:_stream_.NextI
		,nilnul._stream_.ResetI

	{

	}

	[Obsolete()]

	public abstract class StreamA2 : StreamI2, IEnumerable<N>
	{
		public IEnumerator<N> GetEnumerator()
		{
			while (true)
			{
				yield return next();

			}

			//throw new NotImplementedException();
		}

		public abstract N next();

		public abstract void reset();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}








}
