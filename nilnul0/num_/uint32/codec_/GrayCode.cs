using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.uint32.codec_
{
	/// <summary>
	/// codec for number such that:
	///		consecutive numbers have only one bit different;
	///		last number is considered to be adjacent with first number.
	/// </summary>
	/// <remarks>
	/// 0
	/// 1,
	/// then prepend 1 for the previous:
	/// 10
	/// 11
	/// ,then prepend 1 for the previous
	/// 100
	/// 101
	/// 110
	/// 111
	/// , and
	/// go on.
	/// </remarks>
	static public class _GrayCodecX
	{
		/// <summary>
		/// This function converts an unsigned binary number to reflected binary Gray code.
		/// </summary>
		/// 
		/// <param name="number"></param>
		/// <returns></returns>
		static public uint Num2gray(uint num)
		{
			return num ^ (num >> 1); // The operator >> is shift right. The operator ^ is exclusive or.
		}

		static public uint Num2grayAsUint(int num)
		{
			return Num2gray(
				BitConverter.ToUInt32(
					BitConverter.GetBytes(num)
					,
					0
				)
			);
		}

		/// This function converts a reflected binary Gray code number to a binary number.
		static public uint Gray2num(uint num)
		{
			uint mask = num;
			while (mask != 0)
			{           // Each Gray code bit is exclusive-ored with all more significant bits.
				mask >>= 1;
				num ^= mask;
			}
			return num;
		}
		static public uint Gray2numAsUint(int num)
		{
			return Gray2num(
				BitConverter.ToUInt32(
					BitConverter.GetBytes(num)
					, 0
				)
			);
		}

	}
}
