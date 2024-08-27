using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ask_
{
	/// <summary>
	/// a necklace, with p (>=2) different types, such as sapphire/emerald/ruby/diamond, of precious stones, with the counting of each type is a even number, was stolen by two thieves.
	/// to cut <var>r</var> times (resulting ++<var>r</var> segments), and distribute segments among the two thieves such that each thief get the same number of each type.
	/// Let's find a minimal r.
	/// 
	/// </summary>
	public class StolenNecklace
	{
		private nilnul.num_.Plural1 _types;

		public nilnul.num_.Plural1 types
		{
			get { return _types; }
			set { _types = value; }
		}

		/// 0 can be optimized out.
		/// <summary>
		/// </summary>
		private nilnul.num_.plural_.Even _counts;

		public nilnul.num_.plural_.Even counts
		{
			get { return _counts; }
			set { _counts = value; }
		}

		/// the answer of this can be found in geometry.stereo.

		





	}
}
