using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ext_.op_.binary_
{
	/// <summary>
	/// the inf is the unit-object for this var
	/// </summary>
	public class Min : nilnul.num.ext_.op_.BinaryI
	{


		public ExtI op(ExtI par, ExtI par1)
		{
			if (nilnul.num.ext_.comparer.Re.Singleton.ge(par,par1))
			{
				return par;
			}
			return par1;
			//throw new NotImplementedException();
		}


		static public Min Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Min>.Instance;
			}
		}

	}
}
