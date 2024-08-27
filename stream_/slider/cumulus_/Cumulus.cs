using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_.binary;

namespace nilnul.num.stream_.slider.cumulus_
{
	public class Series : nilnul.num.stream_.slider.Cumulus
	{
		public Series(num.stream_.SliderI4 val) : base(val, nilnul.num.op_.binary_.comutable_.add.Gregator.Singleton)
		{
		}
	}

	public class Series_froNew<T> : Series
		where T:nilnul.num.stream_.SliderI4,new()
	{
		public Series_froNew() : base(new T())
		{
		}
	}
}
