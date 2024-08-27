using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		_stream
	///			avoid confliction with later project: nilnul.num.integer;
	///		stream1l
	///			1"L", not 11, as 0lmeans -1;
	public interface StreamI
		:
		nilnul.obj.StreamI2<BigInteger>
	{


	}
}
