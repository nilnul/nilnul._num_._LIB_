using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_;
using nilnul.obj.op_.binary;

namespace nilnul.num.op_.binary_.comutable_.add
{
	public class Gregator
		: nilnul.num.op_.binary.Cumulator_opGeneric<Add>
		,
		nilnul.num.op_.binary.CumulatorI
	{
		public Gregator() : base(0)
		{
		}

		static public Gregator Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Gregator>.Instance;
			}
		}

		
	}
}
