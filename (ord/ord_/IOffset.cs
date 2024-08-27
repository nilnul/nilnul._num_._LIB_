using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord_
{
	/// <summary>
	/// zero based
	/// </summary>
	/// alias：
	///		offset
	///			, this explains why it starts with 0 in that it's an offset, a deviation from the base, which might 1 so offset 0 from 1 is 1+0=1.
	///			,o looks like 0;
	///			
	///		indexer
	///			initial
	///			,
	///			i looks like 1. for a 1-long array, index one is 1%1=0 the offset.
	///			,same initial as "integer"
	///			,which can be negative, as is so in MsDotNet framework; eg: -1 means last one. it doesnot supports modulo though; eg: 8 for five-long array is an exception and it's not paraphrased as 8%5=3;
	///			, <see cref="nilnul.num.integer.indic"/>|index|offset as this one can be negative.
	///			
	///			
	public interface IOffset
	{
	}
}
