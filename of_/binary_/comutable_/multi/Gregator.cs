using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.comutable_.multi
{
	public class Gregator
		: nilnul.num.op_.binary.Cumulator_opGeneric<Multi>
		,
				nilnul.num.op_.binary.CumulatorI

	{
		public Gregator() : base(1)
		{
		}


		static public Gregator Singleton
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Gregator>.Instance;
			}
		}

	}
}
