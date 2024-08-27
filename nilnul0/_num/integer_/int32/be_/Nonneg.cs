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
	///		natural
	///		nat
	public class Nonneg
		:
		BeI
	{
		public bool be(in int val)
		{
			return val >= 0;
			//throw new NotImplementedException();
		}


		static public Nonneg Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Nonneg>.Unison;
			}
		}

	}
}
