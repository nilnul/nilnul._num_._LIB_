using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.uint32.codec_._gray_
{
	/// <summary>
	/// </summary>
	static public class _Gray2numX
	{


		//en.wikipedia.org/wiki/Gray_code

		//A more efficient version for Gray codes 32 bits or fewer through the use of SWAR (SIMD within a register) techniques. 
		// It implements a parallel prefix XOR function. The assignment statements can be in any order.
		// 
		// This function can be adapted for longer Gray codes by adding steps.

		static public uint Gray2num(uint num)
		{
			num ^= num >> 16;
			num ^= num >> 8;
			num ^= num >> 4;
			num ^= num >> 2;
			num ^= num >> 1;
			return num;
		}
		// A Four-bit-at-once variant changes a binary number (abcd)2 to (abcd)2 ^ (00ab)2, then to (abcd)2 ^ (00ab)2 ^ (0abc)2 ^ (000a)2.
	}
}
