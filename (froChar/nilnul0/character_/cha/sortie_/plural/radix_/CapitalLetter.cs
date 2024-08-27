using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character_.cha.sortie_.plural.radix_
{
	public class CapitalLetter : nilnul.character_.cha.sortie_.plural.Radix
	{
		public CapitalLetter() : base(

			nilnul.character_.cha.sortie_.plural_.Upper.Singleton
			
		)
		{
		}

		static public CapitalLetter Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CapitalLetter>.Instance;
			}
		}



	}
}
