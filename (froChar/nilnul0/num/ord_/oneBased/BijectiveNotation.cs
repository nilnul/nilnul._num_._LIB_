using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;

namespace nilnul.num.ord_.positive
{
	/// <summary>
	/// one based. using capital letters 
	/// </summary>
	public class BijectiveNotation
		:nilnul.num.ord_.OneBased
	{
		public BijectiveNotation(Positive1 val) : base(val)
		{
		}

		public BijectiveNotation(OrdI1 ord) : base(ord)
		{
		}

		public override string ToString()
		{
			return nilnul.character_.cha.sortie_.sown.bijectiveNumBase_.CapitalLetter.Singleton.phrase(
				(int)this.boxed.en
			);

			;
		}

		static public nilnul.num.ord_.OneBased ParseAsOneBased_bigEndian(string name)
		{

			return (nilnul.num.ord_.OneBased)(
				(
				nilnul.character_.cha.sortie_.sown.bijectiveNumBase_.CapitalLetter.Singleton.parse_bigEndian(
					name
					)
				)
			);
		}
		static public BijectiveNotation Parse_bigEndian(string name)
		{

			return new BijectiveNotation( ParseAsOneBased_bigEndian(name));
		}

	}
}
