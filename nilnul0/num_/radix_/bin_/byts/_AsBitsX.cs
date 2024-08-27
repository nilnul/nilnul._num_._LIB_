using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.binary_.byts
{
	static public  class _AsBitsX
	{
		public static BitArray AsBits(IEnumerable<byte> bytes)
		{
			return new BitArray(bytes.ToArray());
		}
	



	}
}
