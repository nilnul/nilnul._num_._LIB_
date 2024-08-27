using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_._radix.radic_.chars_
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		oct
	public class Octet
		: Chars
	{
		public Octet() : base( nilnul.character_.cha.sortie_.plural_.Digit.TXT.Take(8))
		{

		}


		static public Octet Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Octet>.Instance;
			}
		}


	}








}
