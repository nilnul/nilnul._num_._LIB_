using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{
	public interface SeqI
		:IEnumerable<OrdI1>
	{

	}

	public abstract class SeqA : SeqI
	{
		public abstract IEnumerator<OrdI1> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
