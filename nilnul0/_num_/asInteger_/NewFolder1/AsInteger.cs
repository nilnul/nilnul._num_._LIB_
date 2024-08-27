using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num_
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="asInteger_.RetRefI"/>
	[Obsolete(nameof(EeByRefI) + " is preferred for performance.")]
	public interface AsIntegerI
	{
		BigInteger asInteger {
			get;
		}
	}
}
