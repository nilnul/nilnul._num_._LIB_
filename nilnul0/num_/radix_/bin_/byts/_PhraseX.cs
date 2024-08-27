using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.radix_.binary_.byts
{
	static public  class _PhraseX
	{
		public static string AsPaddedBinaryEs(IEnumerable<byte> bytes,string sep="")
		{
			return string.Join(
					sep,
					bytes.Select(
						x =>
						byt._PhraseX.AsPaddedBinary(x)
					)
			);
		}
		public static string AsPaddedBinaryEsSpaced(IEnumerable<byte> bytes)
		{
			return AsPaddedBinaryEs(bytes," ");
		}



	}
}
