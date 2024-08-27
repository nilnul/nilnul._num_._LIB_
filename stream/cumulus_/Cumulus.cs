using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_.binary;

namespace nilnul.num.stream.cumulus_
{
	public class Series : nilnul.num.stream.Cumulus
	{
		public Series(StreamI6 val) : base(val, nilnul.num.op_.binary_.comutable_.add.Gregator.Singleton)
		{
		}
	}

	public class Series_froNew<T> : Series
		where T:nilnul.num.StreamI6,new()
	{
		public Series_froNew() : base(new T())
		{
		}
	}
}
