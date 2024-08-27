using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._num.bigint.be;
using N = nilnul.num._num.bigint.be.Natural.Asserted;

namespace nilnul.num
{
	[Obsolete()]
	public interface StreamI
		:nilnul.num.type.StreamI_inhereNext_withReset<N>
	{

	}
	[Obsolete()]
	public abstract class StreamA : StreamI, IEnumerable<N>
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
