using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.add
{
	public class Cumulator_assumeInteger
		:
		nilnul.obj.op_.binary.cumulator_.OpDefault<
			BigInteger
			,
			nilnul.num.op_.binary_.Add
		>
		,
		nilnul.obj.op_.binary.cumulator_.NardableI<BigInteger>

	{
		public Cumulator_assumeInteger() : base(0)
		{

		}


		static public Cumulator_assumeInteger Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator_assumeInteger>.Instance;
			}
		}

	}
}
