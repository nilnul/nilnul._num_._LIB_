using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.add
{
	public class Cumulator
		:
		nilnul.obj.op_.binary.cumulator_.OpDefault<
			nilnul.NumI1
			,
			nilnul.num.op_.binary_.Add
		>
		,
		nilnul.obj.op_.binary.cumulator_.NardableI<nilnul.NumI1>

	{
		public Cumulator() : base(new nilnul.Num1())
		{

		}


		static public Cumulator Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator>.Instance;
			}
		}

	}
}
