using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.uint32.codec_
{
	/// <summary>
	/// use network endianness
	/// </summary>
	static public class _PortableX
	{
		public static byte[] Num2bytes(uint value)
		{
			return  BitConverter.GetBytes(IPAddress.HostToNetworkOrder(value));
		}
	}
}
