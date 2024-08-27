using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.op_.binary;

namespace nilnul.num.stream.cumulus_
{ 

	public class Multi : nilnul.num.stream.Cumulus
	{
		public Multi(StreamI6 val) : base(val, nilnul.num.op_.binary_.comutable_.multi.Gregator.Singleton)
		{
		}
	}

	public class Multi_froNew<T> : Multi
	where T : nilnul.num.StreamI6, new()
	{
		public Multi_froNew() : base(new T())
		{
		}
	}

}
