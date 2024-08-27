using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_.binary;

namespace nilnul.num.stream_.slider.cumulus_
{ 

	public class Multi : nilnul.num.stream_.slider.Cumulus
	{
		public Multi(num.stream_.SliderI4 val) : base(val, nilnul.num.op_.binary_.comutable_.multi.Gregator.Singleton)
		{
		}
	}

	public class Multi_froNew<T> : Multi
	where T : nilnul.num.stream_.SliderI4, new()
	{
		public Multi_froNew() : base(new T())
		{
		}
	}

}
