using nilnul.num_._radix.radic;
using nilnul.num_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num_.radix_.precisioned.to_
{
	static public class _ToNumX
	{





		public static BigInteger _ToInteger_gits0nonnegs_radic1plural_ponent2nonneg(IEnumerable<BigInteger> _gits8nonnegs, BigInteger _radic8plural, BigInteger _ponent8nonneg)
		{
			return num_.radix.to_._ToNumX._ToInteger_gits0nonnegs_radic1plural(
				_gits8nonnegs,_radic8plural
			) * num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
				_radic8plural
				,
				_ponent8nonneg
			) ;
		}

		public static BigInteger _ToInteger_radic1plural_ponent2nonneg(IEnumerable<Num_ofIn> gits, BigInteger _radic8plural, BigInteger _ponent8nonneg)
		{
			return _ToInteger_gits0nonnegs_radic1plural_ponent2nonneg(gits.Select(x=>x.eeByRef),_radic8plural, _ponent8nonneg);

		}

		public static BigInteger _ToInteger_ponent2nonneg(IEnumerable<Num_ofIn> gits, ref_.vowless_.Plural radic, BigInteger _ponent8nonneg)
		{
			return _ToInteger_radic1plural_ponent2nonneg(gits,radic.eeByRef, _ponent8nonneg);

		}
		public static BigInteger ToInteger(IEnumerable<Num_ofIn> gits, ref_.vowless_.Plural radic, Num_ofIn ponent)
		{
			return _ToInteger_ponent2nonneg(gits,radic, ponent.eeByRef);
		}
		public static BigInteger ToInteger(IEnumerable<Num_ofIn> gits, Ponented ponented)
		{
			return ToInteger(
				gits,ponented.radic,ponented.ponent
			);
		}
		public static BigInteger ToInteger(Precisioned collpaseTrailingNils)
		{
			return ToInteger(
				collpaseTrailingNils.gits,collpaseTrailingNils.ponented
			);
		}
		public static Num_ofIn ToNum(Precisioned collpaseTrailingNils)
		{
			return Num_ofIn.Of( ToInteger(
				collpaseTrailingNils
			));
		}

	}


}
