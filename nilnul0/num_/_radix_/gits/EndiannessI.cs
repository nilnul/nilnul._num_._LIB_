using System.Collections.Generic;

namespace nilnul.num_._radix_.gits
{
	/// <summary>
	/// little1st|light1st, not heavy1st; eg: for 123, the gits are: 3,2,1, not 1,2,3;
	/// this will correspond to the ponent of each position, and 123=3*10^0+2*10^1 +1 *10^0
	/// </summary>
	/// <remarks>
	/// for floaty number such as 0.456, the heavier comes first, as we first know 4 and then 5;
	/// for 123.456, the integer part, when we convert it to another base, would be light1st as each git is the remainder, while for the mantissa, we would get heavy1st as each git is the quotient;
	/// especially for recurring cyclic number such as 3.3333..., we cannot assign an index for tail term, so here we prefer heavy1st.
	/// So for floaty pointed number, be careful to explicitly specify the endianness; A rule of thumb is for integer, we use light1st, for floaty, it's defaulted to heavy first;
	/// </remarks>

	public interface EndiannessI
	{
	}

}