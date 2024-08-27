using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		poly means 3 or more.
	///			in polynomial, poly means 0 or more; but that's an abusion of this term; as 0 or more is already expressible by "natural","num","nonneg", etc
	///			positive means 1 or more
	///			plural means 2 or more
	///		polynomial means 3 or more, also 0 or 1 or two, as in polynomial
	///			polynom
	/// </remarks>
	public  class Poly:
		nilnul.num.BeA
		,
		BeI1
	{
		

		public override bool be(NumI1 obj)
		{
			return obj.toBigint().en >=3;
			//throw new NotImplementedException();
		}




		static public Poly Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Poly>.Instance;
			}
		}



	}
}
