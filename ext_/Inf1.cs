using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		arbitrary
	///			,which is still a number sampled from the set of all nums, with no need to specify statistical distribution, or in otherwords, we disregard or lack the information.
	/// alias:
	///		infinite
	///		exfinite
	///		beyondfinite
	///		nonfinite
	///		transfinite
	public sealed class Inf1:
		ExtA1
	{


		static public Inf1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inf1>.Instance;
			}
		}


	}
}
