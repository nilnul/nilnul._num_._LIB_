using nilnul.obj.op_.binary.cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.add.cumulator
{
	public class Cumulate_integerAssume
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<
			BigInteger
			
			,
			add.Cumulator_assumeInteger
		>
	//,
	//nilnul.obj.op_.binary.cumulator._cumulate_.OfSeq<BigInteger>
	{

		static public Cumulate_integerAssume Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulate_integerAssume>.Instance;
			}
		}

	}
}
