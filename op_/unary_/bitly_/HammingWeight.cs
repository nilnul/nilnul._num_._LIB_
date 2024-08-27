using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.op_.unary_.bitly_
{
	/// <summary>
	/// also known as popcount
	/// </summary>
	static public class _HammingWeightX

	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		/// <example>
		/// So if I have number 395 in binary 00 00 00 01 10 00 10 11 (0 0 0 0 0 0 0 1 1 0 0 0 1 0 1 1)
		/// After the first step I have:      00 00 00 01 01 00 01 10 (0+0 0+0 0+0 0+1 1+0 0+0 1+0 1+1) = 00 00 00 01 01 00 01 10
		/// In the second step I have:        0000  0001  0001  0011 ( 00+00   00+01   01+00   01+10 ) = 0000 0001 0001 0011
		/// In the fourth step I have:        00000001    00000100 (   0000+0001       0001+0011   ) = 00000001 00000100
		/// In the last step I have:          0000000000000101 (       00000001+00000100       )

		/// 
		/// </example>
		static public uint HammingWeight(uint v)
		{
			v = (v & 0x55555555) + ((v >> 1) & 0x55555555);     //note that (v & 0x55555555) + ((v >> 1) & 0x55555555)+((v >> 1) & 0x55555555)=v. so (v & 0x55555555) + ((v >> 1) & 0x55555555)= v- ((v >> 1) & 0x55555555)
			v = (v & 0x33333333) + ((v >> 2) & 0x33333333);
			v = (v & 0x0F0F0F0F) + ((v >> 4) & 0x0F0F0F0F);
			v = (v & 0x00FF00FF) + ((v >> 8) & 0x00FF00FF);
			return (v & 0x0000FFFF) + ((v >> 16) & 0x0000FFFF);
		}
	}
}