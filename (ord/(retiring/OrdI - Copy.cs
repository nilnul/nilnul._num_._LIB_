using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N=nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num
{

	/// <summary>
	/// anything that can map one2one with Num
	/// This is placed as an extension, not subtype, is in that: for one-based ord, the ToString() of it will return 1 and it's toNum will return 0; To clear the confusion, nilnul.num.Ord shall be an ext, not a subtype of num as it changed the supertype's behavior in "ToString()"
	/// </summary>
	///
	[Obsolete()]
	public interface OrdI1
		:_ord_.ToBaseZeroI1
	{
	}

	public abstract class OrdA : OrdI1
	{
		public abstract Num toNum();
		static public bool  operator <=(OrdA x, OrdA y){
			return ord.comparer.Re.Singleton.le(x, y);
		}

		static public bool  operator <(OrdA x, OrdA y){
			return ord.comparer.Re.Singleton.lt(x, y);
		}
		static public bool  operator >(OrdA x, OrdA y){
			return ord.comparer.Re.Singleton.gt(x, y);
		}

		static public bool  operator >=(OrdA x, OrdA y){
			return ord.comparer.Re.Singleton.ge(x, y);
		}

		static public bool  operator ==(OrdA x, OrdA y){
			return ord.comparer.Re.Singleton.eq(x, y);
		}
		static public bool  operator !=(OrdA x, OrdA y){
			return ord.comparer.Re.Singleton.ne(x, y);
		}


	}
}
