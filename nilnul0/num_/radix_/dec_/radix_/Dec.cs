using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.radix_
{
	[Obsolete("nilnul.txt.radix.")]
	public class Dec
		:nilnul.num.Radix
	{
		public Dec()
			:base(
				nilnul.character.sorted_.alphabet_.Digit.Singleton 
				 )
		{

		}



		static public readonly Dec Singleton = SingletonByDefault<Dec>.Instance;



	}
}
