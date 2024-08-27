using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_.commutative.cumulator_
{
	/// <summary>
	/// a cumulator, where:
	///		1. the op is commutative
	///		2. the intial is zeroth.
	/// </summary>
	public interface AggregatorI<TOp>
		:
		nilnul.obj.op_.binary.accumulator_.AggregatorI<Num1,TOp>
		where TOp: nilnul.num.op_.binary_.CommutableI

	{
	}
}
