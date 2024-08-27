using nilnul.obj.op_.binary.cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.add.cumulator
{
	public class Cumulate
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<
			nilnul.NumI1
			
			,
			add.Cumulator
		>
	//,
	//nilnul.obj.op_.binary.cumulator._cumulate_.OfSeq<BigInteger>
	{

		static public Cumulate Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulate>.Instance;
			}
		}

	}
}
