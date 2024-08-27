using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;

namespace nilnul.num.be_
{
	public class Lt : 
		nilnul.obj.Box<nilnul.num_.Positive1>
		,
		nilnul.num.BeI
	{

		public Lt(Positive1 val) : base(val)
		{
		}

		public bool be(Num obj)
		{
			return obj<this.boxed.en; 

		}
	}
}
