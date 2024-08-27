using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer_.int32.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	public class Poly
		:
		BeI
	{
		public bool be(in int val)
		{
			return val >= 3;
			//throw new NotImplementedException();
		}


		static public Poly Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Poly>.Unison;
			}
		}

	}
}
