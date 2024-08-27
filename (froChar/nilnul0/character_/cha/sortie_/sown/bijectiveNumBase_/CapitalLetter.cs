using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.character_.cha.sortie_.sown.bijectiveNumBase_
{
	public class CapitalLetter : BijectiveNumBase
	{
		public CapitalLetter() : base(
						nilnul.character_.cha.sortie_.sown_.Upper.Singleton

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
