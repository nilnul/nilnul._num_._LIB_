using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_;
using nilnul.obj.op_.binary;

namespace nilnul.num.op_.binary
{
	public interface CumulatorI<TOp>
		: nilnul.obj.op_.binary.AccumulatorI<Num1, TOp>


		where TOp : nilnul.num.op_.BinaryI1

	{

	}

	public interface CumulatorI
		:
		CumulatorI<nilnul.num.op_.BinaryI1>
		,
		nilnul.obj.op_.binary.AccumulatorI<Num1, nilnul.num.op_.BinaryI1>
	{

	}

	public class Cumulator<TOp> : nilnul.obj.op_.binary.Accumulator<Num1, TOp>
		,
		CumulatorI<TOp>
		where TOp : nilnul.num.op_.BinaryI1
	{
		public Cumulator(Num1 initial, TOp binder) : base(initial, binder)
		{
		}
	}

	public class Cumulator_opDefault<TOp> : Cumulator<TOp>
		
		where TOp : nilnul.num.op_.BinaryI1, new()


	{
		public Cumulator_opDefault(Num1 initial) : base(initial, nilnul.obj_.singleton_.Lazy<TOp>.Instance)
		{
		}
	}
	public class Cumulator_opGeneric<TOp> 
		:
		nilnul.obj.op_.binary.Accumulator<Num1,nilnul.num.op_.BinaryI1>
		,
		CumulatorI

		where TOp : nilnul.num.op_.BinaryI1, new()

	{
		public Cumulator_opGeneric(Num1 initial) : base(initial, nilnul.obj_.singleton_.Lazy<TOp>.Instance)
		{
		}

	}
}
